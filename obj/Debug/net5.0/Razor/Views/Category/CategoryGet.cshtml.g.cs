#pragma checksum "C:\Users\Huri\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffb0eaa52d6c13bbc1ff5c32a8fca774a8da32a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryGet), @"mvc.1.0.view", @"/Views/Category/CategoryGet.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffb0eaa52d6c13bbc1ff5c32a8fca774a8da32a6", @"/Views/Category/CategoryGet.cshtml")]
    public class Views_Category_CategoryGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Huri\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
  
    ViewData["Title"] = "CategoryGet";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Category Edit</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\Huri\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
 using (Html.BeginForm("CategoryUpdate", "Category", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Huri\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.LabelFor(x => x.CategoryID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Huri\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.TextBoxFor(x => x.CategoryID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\Huri\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.LabelFor(x => x.CategoryName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Huri\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Huri\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.ValidationMessageFor(x => x.CategoryName, "", new { @style = "color:red " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\Huri\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.LabelFor(x => x.CategoryDescription));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Huri\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.TextBoxFor(x => x.CategoryDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Update</button>\r\n");
#nullable restore
#line 23 "C:\Users\Huri\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
