#pragma checksum "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f8110cb9cdf8a7dd2cef967b4d450f291a2016"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu), @"mvc.1.0.view", @"/Views/Home/Menu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f8110cb9cdf8a7dd2cef967b4d450f291a2016", @"/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed1d286704faafb66f6c362a6279f19f91eff5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.MVModels.MV_Front>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Layout_page";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""breadcrumb-area bg-img ptb-80"" style=""background-image:url(/assets/img/banner/breath.jpg);"">
    <div class=""container"">
        <div class=""breadcrumb-content text-center"">
            <h3>menu</h3>
            <ul>
                <li>
                    <a href=""/Home"">Home</a>
                </li>
                <li class=""active"">menu page </li>
            </ul>
        </div>
    </div>
</div>
<div class=""product-menu-area pt-100 pb-70 gray-bg"">
    <div class=""container"">
        <div class=""section-title text-center mb-50"">
            <h2>Our Food Menu</h2>
            <p> Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim nostrud exercitation ullamco laboris nisi.</p>
        </div>
        <div class=""menu-tab-wrap mb-50"">
            <div class=""menu-tab-list nav text-center"">
                <a class=""active"" href=""#tab1"" data-bs-toggle=""tab"">
                    All ");
            WriteLiteral("item\r\n                </a>\r\n\r\n");
#nullable restore
#line 33 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
                 foreach (var item in Model.MasterCategoryMenu)
                {

                     

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 1299, "\"", 1335, 2);
            WriteAttributeValue("", 1306, "#", 1306, 1, true);
#nullable restore
#line 37 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
WriteAttributeValue("", 1307, item.MasterCategoryMenuName, 1307, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"tab\" >\r\n                            ");
#nullable restore
#line 38 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
                       Write(item.MasterCategoryMenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n");
#nullable restore
#line 40 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
             
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            </div>\r\n\r\n\r\n        <div class=\"tab-content jump\">\r\n            <div id=\"tab1\" class=\"tab-pane active\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 51 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
                     foreach (var items in Model.MasterItemMenu)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-6\">\r\n                            <div class=\"single-menu-product mb-30\">\r\n                                <div class=\"menu-product-img\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "99f8110cb9cdf8a7dd2cef967b4d450f291a20166501", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1984, "~/Item_Image/", 1984, 13, true);
#nullable restore
#line 57 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
AddHtmlAttributeValue("", 1997, items.MasterItemMenuImageUrl, 1997, 29, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""menu-product-content"">
                                    <div class=""menu-title-price"">
                                        <div class=""menu-title"">
                                            <h4>
                                                ");
#nullable restore
#line 63 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
                                           Write(items.MasterItemMenuTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </h4>\r\n                                        </div>\r\n                                        <div class=\"menu-price\">\r\n                                            <span>$");
#nullable restore
#line 67 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
                                              Write(items.MasterItemMenuPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                    <p>");
#nullable restore
#line 70 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
                                  Write(items.MasterItemMenuDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 74 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 79 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
                     foreach (var item in Model.MasterCategoryMenu)
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("id", " id=\"", 3115, "\"", 3148, 1);
#nullable restore
#line 83 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
WriteAttributeValue("", 3120, item.MasterCategoryMenuName, 3120, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"tab-pane\">\r\n                            <div class=\"row\">\r\n");
#nullable restore
#line 85 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
                                 foreach (var items in Model.MasterItemMenu.Where(x => x.MasterCategoryMenu.MasterCategoryMenuName == item.MasterCategoryMenuName))
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""col-lg-6"">
                                        <div class=""single-menu-product mb-30"">
                                            <div class=""menu-product-img"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "99f8110cb9cdf8a7dd2cef967b4d450f291a201611455", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3700, "~/Item_Image/", 3700, 13, true);
#nullable restore
#line 91 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
AddHtmlAttributeValue("", 3713, items.MasterItemMenuImageUrl, 3713, 29, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                            <div class=""menu-product-content"">
                                                <div class=""menu-title-price"">
                                                    <div class=""menu-title"">
                                                        <h4>
                                                            ");
#nullable restore
#line 97 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
                                                       Write(items.MasterItemMenuTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        </h4>
                                                    </div>
                                                    <div class=""menu-price"">
                                                        <span>$");
#nullable restore
#line 101 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
                                                          Write(items.MasterItemMenuPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    </div>\r\n                                                </div>\r\n                                                <p>");
#nullable restore
#line 104 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
                                              Write(items.MasterItemMenuDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 108 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"


                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 114 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n<div class=\"brand-logo-area ptb-100\">\r\n    <div class=\"container\">\r\n        <div class=\"brand-logo-active owl-carousel\">\r\n\r\n");
#nullable restore
#line 124 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
             foreach (var item in @Model.MasterPartner)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"single-brand-logo\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "99f8110cb9cdf8a7dd2cef967b4d450f291a201616005", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5306, "~/Partner_img/", 5306, 14, true);
#nullable restore
#line 127 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
AddHtmlAttributeValue("", 5320, item.MasterPartnerLogoImageUrl, 5320, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 129 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\Menu.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant.MVModels.MV_Front> Html { get; private set; }
    }
}
#pragma warning restore 1591
