using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        Context Context = new Context();
       FoodRepository foodRepository = new FoodRepository(); 
        public IActionResult Index(int page=1)
        {
            
            return View(foodRepository.TList("Category").ToPagedList(page,3));
        }
        [HttpGet]
        public IActionResult AddFood()
        {
            List<SelectListItem> values = (from x in Context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddFood(UrunEkle food)
        {
            Food f = new Food();
            if (food.ImageUrl != null)
            {
                var extension = Path.GetExtension(food.ImageUrl.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/resimler/",newImageName);
                var stream = new FileStream(location, FileMode.Create);
                food.ImageUrl.CopyTo(stream);
                f.ImageUrl = newImageName;
            }
            f.Name = food.Name;
            f.Price = food.Price;
            f.Stock = food.Stock;
            f.CategoryID = food.CategoryID;
            f.ShortDescription = food.Description;
            foodRepository.TAdd(f);
            return Redirect("/Food/Index");
        }
        public IActionResult DeleteFood(int id)
        {
            foodRepository.TDelete(new Food { FoodID=id});
            return Redirect("/Food/Index");
        }
        public IActionResult FoodGet(int id)
        {
            var x = foodRepository.TGet(id);
            List<SelectListItem> values = (from y in Context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            Food f = new Food()
            {
                FoodID=x.FoodID,
                CategoryID = x.CategoryID,
                Name = x.Name,
                Price = x.Price,
                Stock=x.Stock,
                ShortDescription = x.ShortDescription,
                ImageUrl = x.ImageUrl
            };

            return View(f);

        }
        public IActionResult FoodUpdate(Food p)
        {
            var x = foodRepository.TGet(p.FoodID);
            x.Name = p.Name;
            x.Stock = p.Stock;
            x.Price = p.Price;
            x.ImageUrl = p.ImageUrl;
            x.ShortDescription = p.ShortDescription;
            x.CategoryID = p.CategoryID;
            foodRepository.TUpdate(x);
            return Redirect("/Food/Index");

        }
    }
}
