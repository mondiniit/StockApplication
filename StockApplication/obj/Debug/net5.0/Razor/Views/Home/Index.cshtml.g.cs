#pragma checksum "/Users/mondini/RiderProjects/StockApplication/StockApplication/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b13e893c0f52a67b51b4ad15cd6416e17d4f8e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "/Users/mondini/RiderProjects/StockApplication/StockApplication/Views/_ViewImports.cshtml"
using StockApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mondini/RiderProjects/StockApplication/StockApplication/Views/_ViewImports.cshtml"
using StockApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b13e893c0f52a67b51b4ad15cd6416e17d4f8e6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc8055fffc98f8162cd7aa21cc26116b98b2d7b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StockApplication.Models.Alert>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/mondini/RiderProjects/StockApplication/StockApplication/Views/Home/Index.cshtml"
  
    ViewData["Stock"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n\n    <a href=\"../Stock/Stock\" >Register Stock</a>\n</div>\n\n<!--Aki table -->\n");
#nullable restore
#line 13 "/Users/mondini/RiderProjects/StockApplication/StockApplication/Views/Home/Index.cshtml"
 using (Html.BeginForm("StockList", "Stock", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <table class=\"table table-bordered table-responsive table-hover\">\n            <tr>\n                <th>Symbol </th>\n                <th>Price </th>\n                <th>Email </th>\n                <th></th>\n            </tr>\n");
#nullable restore
#line 23 "/Users/mondini/RiderProjects/StockApplication/StockApplication/Views/Home/Index.cshtml"
             foreach (var lAlert in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 26 "/Users/mondini/RiderProjects/StockApplication/StockApplication/Views/Home/Index.cshtml"
                   Write(lAlert.Symbol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 27 "/Users/mondini/RiderProjects/StockApplication/StockApplication/Views/Home/Index.cshtml"
                   Write(lAlert.AlertPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 28 "/Users/mondini/RiderProjects/StockApplication/StockApplication/Views/Home/Index.cshtml"
                   Write(lAlert.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 29 "/Users/mondini/RiderProjects/StockApplication/StockApplication/Views/Home/Index.cshtml"
                   Write(lAlert.Sent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 31 "/Users/mondini/RiderProjects/StockApplication/StockApplication/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n    </div>\n");
#nullable restore
#line 34 "/Users/mondini/RiderProjects/StockApplication/StockApplication/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StockApplication.Models.Alert>> Html { get; private set; }
    }
}
#pragma warning restore 1591
