#pragma checksum "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f86224ad33945e6230f63d74f457033677edf370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f86224ad33945e6230f63d74f457033677edf370", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed1d286704faafb66f6c362a6279f19f91eff5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.MVModels.MVAbout>
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
#line 2 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Layout_page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""breadcrumb-area bg-img ptb-80"" style=""background-image:url(/assets/img/banner/breath.jpg);"">
    <div class=""container"">
        <div class=""breadcrumb-content text-center"">
            <h3>about us</h3>
            <ul>
                <li>
                    <a href=""/Home"">Home</a>
                </li>
                <li class=""active"">about us </li>
            </ul>
        </div>
    </div>
</div>
<div class=""about-area ptb-95"">
    <div class=""container"">
        <div class=""row d-flex align-items-center"">
            <div class=""col-lg-6"">
                <div class=""about-content pr-30"">
                    ");
#nullable restore
#line 25 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\About.cshtml"
               Write(Html.Raw(Model.SystemSetting.SystemSettingWelcomeNoteTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 26 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\About.cshtml"
               Write(Html.Raw(Model.SystemSetting.SystemSettingWelcomeNoteBreef));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <div class=\"about-peragraph\">\r\n                        ");
#nullable restore
#line 29 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\About.cshtml"
                   Write(Html.Raw(Model.SystemSetting.SystemSettingWelcomeNoteDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"default-btn-style mt-35\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1141, "\"", 1196, 1);
#nullable restore
#line 31 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\About.cshtml"
WriteAttributeValue("", 1148, Model.SystemSetting.SystemSettingWelcomeNoteUrl, 1148, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">read more</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"about-img\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f86224ad33945e6230f63d74f457033677edf3705689", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1431, "~/System_img/", 1431, 13, true);
#nullable restore
#line 38 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\About.cshtml"
AddHtmlAttributeValue("", 1444, Model.SystemSetting.SystemSettingWelcomeNoteImageUrl, 1444, 53, false);

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
            </div>
        </div>
    </div>
</div>


<div class=""services-area pt-100 pb-70 gray-bg"">
    <div class=""container"">
        <div class=""section-title text-center mb-50"">
            <h2>Our Services</h2>
            <p> Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim nostrud exercitation ullamco laboris nisi.</p>
        </div>
        <div class=""row"">


");
#nullable restore
#line 55 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\About.cshtml"
             foreach (var item in Model.MasterServices)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-4 col-sm-6 col-12\">\r\n                    <div class=\"single-service text-center mb-30\">\r\n                        ");
#nullable restore
#line 59 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\About.cshtml"
                   Write(Html.Raw(item.MasterServicesIcon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <h3>");
#nullable restore
#line 60 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\About.cshtml"
                       Write(item.MasterServicesTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p> ");
#nullable restore
#line 61 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\About.cshtml"
                       Write(item.MasterServicesDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 64 "C:\Users\96278\Desktop\last lec\SystemRestaurant\Restaurant\Views\Home\About.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant.MVModels.MVAbout> Html { get; private set; }
    }
}
#pragma warning restore 1591
