#pragma checksum "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Items.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7fff7a4819322e436923d1a5cd1beb061c4cc8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Items), @"mvc.1.0.view", @"/Views/Home/Items.cshtml")]
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
#line 1 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\_ViewImports.cshtml"
using SmiteAPIWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\_ViewImports.cshtml"
using SmiteAPIWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7fff7a4819322e436923d1a5cd1beb061c4cc8e", @"/Views/Home/Items.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a099de83da058b5cea0b2e062015ec9a22b3b343", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Items : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmiteAPIWebsite.ItemsInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Items.cshtml"
  
    ViewData["Title"] = "Items";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Items</h1>\r\n\r\n<div class=\"card-columns\">\r\n");
#nullable restore
#line 10 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Items.cshtml"
     foreach (var item in Smite.items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-dark mb-3\">\r\n            <div class=\"row no-gutters\">\r\n                <div class=\"col-md-4\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 357, "\"", 381, 1);
#nullable restore
#line 15 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Items.cshtml"
WriteAttributeValue("", 363, item.itemIcon_URL, 363, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 19 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Items.cshtml"
                                          Write(item.DeviceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p>");
#nullable restore
#line 20 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Items.cshtml"
                      Write(item.ItemDescription.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 21 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Items.cshtml"
                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 22 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Items.cshtml"
                      Write(item.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\nuryn\Desktop\CodingProjects\SmiteAPIWebsite\Views\Home\Items.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmiteAPIWebsite.ItemsInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
