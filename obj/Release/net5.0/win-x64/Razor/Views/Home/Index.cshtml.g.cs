#pragma checksum "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f2938ae25849a8db48fa320ad9bc4ed864d5ee7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f2938ae25849a8db48fa320ad9bc4ed864d5ee7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed1d286704faafb66f6c362a6279f19f91eff5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.MVModels.MV_Front>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"slider-area\">\r\n    <div class=\"slider-active owl-dot-style owl-carousel\">\r\n");
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
         foreach (var item in @Model.MasterSliders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"single-slider bg-img height-100vh d-flex align-items-center justify-content-center\"");
            BeginWriteAttribute("style", " style=\"", 340, "\"", 414, 5);
            WriteAttributeValue("", 348, "background-image:", 348, 17, true);
            WriteAttributeValue(" ", 365, "url(\'/Sider_image/", 366, 19, true);
#nullable restore
#line 11 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
WriteAttributeValue("", 384, item.MasterSliderImageUrl, 384, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 410, "\'", 410, 1, true);
            WriteAttributeValue(" ", 411, ");", 412, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                <div class=\"slider-content-wrap slider-animated-1\">\r\n                    <div class=\"slider-content pt-100\">\r\n                        ");
#nullable restore
#line 15 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                   Write(Html.Raw(item.MasterSliderTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                   Write(Html.Raw(item.MasterSliderBreef));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 17 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                   Write(Html.Raw(item.MasterSliderDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"slider-btn mt-20\">\r\n                            <a class=\"animated\" href=\"product-details.html\">read more</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"about-area ptb-95\">\r\n    <div class=\"container\">\r\n        <div class=\"row d-flex align-items-center\">\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"about-content pr-30\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
               Write(Html.Raw(Model.SystemSetting.SystemSettingWelcomeNoteTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
               Write(Html.Raw(Model.SystemSetting.SystemSettingWelcomeNoteBreef));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <div class=\"about-peragraph\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.SystemSetting.SystemSettingWelcomeNoteDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"default-btn-style mt-35\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1601, "\"", 1656, 1);
#nullable restore
#line 38 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
WriteAttributeValue("", 1608, Model.SystemSetting.SystemSettingWelcomeNoteUrl, 1608, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">read more</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"about-img\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f2938ae25849a8db48fa320ad9bc4ed864d5ee79266", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1891, "~/System_img/", 1891, 13, true);
#nullable restore
#line 45 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1904, Model.SystemSetting.SystemSettingWelcomeNoteImageUrl, 1904, 53, false);

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
<div class=""popular-product gray-bg pt-100 pb-100"">
    <div class=""container"">
        <div class=""section-title text-center mb-50"">
            <h2>Our Popular Dishes</h2>
            <p> Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim nostrud exercitation ullamco laboris nisi.</p>
        </div>
        <div class=""product-slider-active owl-carousel"">

");
#nullable restore
#line 59 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
             foreach (var item in @Model.MasterItemMenu)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"product-style-wrap\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f2938ae25849a8db48fa320ad9bc4ed864d5ee711826", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2663, "~/Item_Image/", 2663, 13, true);
#nullable restore
#line 63 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2676, item.MasterItemMenuImageUrl, 2676, 28, false);

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
            WriteLiteral("\r\n                    <div class=\"product-content text-center\">\r\n                        <h4>\r\n                            ");
#nullable restore
#line 66 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                       Write(item.MasterItemMenuTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h4>\r\n                        <p>");
#nullable restore
#line 68 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                      Write(item.MasterItemMenuBreef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <span>$");
#nullable restore
#line 69 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                          Write(item.MasterItemMenuPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 72 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"popular-bg-img\">\r\n        <img");
            BeginWriteAttribute("alt", " alt=\"", 3151, "\"", 3157, 0);
            EndWriteAttribute();
            WriteLiteral(@" src=""assets/img/banner/popular.png"">
    </div>
</div>
<div class=""book-table ptb-100 bg-img"" id=""book"" style=""background-image:url(/assets/img/banner/book-a-table.jpg);"">
    <div class=""container"">
        <div class=""section-title text-center mb-50"">
            <h2>book a table</h2>
            <p> Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim nostrud exercitation ullamco laboris nisi.</p>
        </div>
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""reserve-form"">
                    <h3 class=""reserv-title"">Reservation Form</h3>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2938ae25849a8db48fa320ad9bc4ed864d5ee715769", async() => {
                WriteLiteral(@"
                        <div class=""reserve-form-top"">
                            <input type=""text"" placeholder=""Full name"">
                            <input type=""email"" placeholder=""Email address"">
                            <input type=""text"" placeholder=""Mobile number"">
                            <div class=""date-time"">
                                <select>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2938ae25849a8db48fa320ad9bc4ed864d5ee716458", async() => {
                    WriteLiteral("Select Date And Time");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2938ae25849a8db48fa320ad9bc4ed864d5ee717610", async() => {
                    WriteLiteral("26 Dec - 10.00pm");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2938ae25849a8db48fa320ad9bc4ed864d5ee718671", async() => {
                    WriteLiteral("2 Jan - 10.00pm");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2938ae25849a8db48fa320ad9bc4ed864d5ee719731", async() => {
                    WriteLiteral("17 Dec - 10.00pm");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""reserve-submit mt-40"">
                            <button type=""submit""> submit </button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"book-img\">\r\n                    <img src=\"/assets/img/banner/table.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5048, "\"", 5054, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""testimonial-area ptb-100 gray-bg"">
    <div class=""container"">
        <div class=""section-title text-center mb-50"">
            <h2>what people say</h2>
            <p> Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim nostrud exercitation ullamco laboris nisi.</p>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""testimonial-image-slider text-center"">
                    <div class=""single-testi-text"">
                        <p>The point of using Lorem Ipsum is that more-or-less normal distribution of letters, as opposed to using</p>
                    </div>
                    <div class=""single-testi-text"">
                        <p>The point of using Lorem Ipsum is that more-or-less normal distribution of letters, as opposed to using</p>
           ");
            WriteLiteral(@"         </div>
                    <div class=""single-testi-text"">
                        <p>The point of using Lorem Ipsum is that more-or-less normal distribution of letters, as opposed to using</p>
                    </div>
                    <div class=""single-testi-text"">
                        <p>The point of using Lorem Ipsum is that more-or-less normal distribution of letters, as opposed to using</p>
                    </div>
                </div>
                <div class=""testimonial-text-slider text-center"">
                    <div class=""single-testi-img"">
                        <img src=""/assets/img/team/tesi-1.png"" alt=""testi 1"" />
                        <h3>William Patel</h3>
                        <h5>customer</h5>
                    </div>
                    <div class=""single-testi-img"">
                        <img src=""/assets/img/team/tesi-2.png"" alt=""testi 1"" />
                        <h3>Diane Walsh</h3>
                        <h5>customer</h5>
        ");
            WriteLiteral(@"            </div>
                    <div class=""single-testi-img"">
                        <img src=""/assets/img/team/tesi-1.png"" alt=""testi 1"" />
                        <h3>Carl Carr</h3>
                        <h5>customer</h5>
                    </div>
                    <div class=""single-testi-img"">
                        <img src=""/assets/img/team/tesi-2.png"" alt=""testi 1"" />
                        <h3>Linda Nelson</h3>
                        <h5>customer</h5>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
 
    <div class=""offer-area gray-bg ptb-100 bg-img""");
            BeginWriteAttribute("style", " style=\"", 7755, "\"", 7825, 5);
            WriteAttributeValue("", 7763, "background-image:", 7763, 17, true);
            WriteAttributeValue(" ", 7780, "url(\'/Offer_image/", 7781, 19, true);
#nullable restore
#line 166 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
WriteAttributeValue("", 7799, Model.MasterOffer_img, 7799, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7821, "\'", 7821, 1, true);
            WriteAttributeValue(" ", 7822, ");", 7823, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n \r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n\r\n\r\n");
#nullable restore
#line 173 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                 foreach (var item in Model.MasterOffer)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"xl-auto col-xl-5 ms-auto col-lg-6 col-md-12\">\r\n                        <div class=\"offer-content\">\r\n                            <h5>");
#nullable restore
#line 177 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                           Write(item.MasterOfferTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <h2>");
#nullable restore
#line 178 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                           Write(item.MasterOfferBreef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>");
#nullable restore
#line 179 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                          Write(item.MasterOfferDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <div class=""default-btn-style book-btn mt-35"">
                                <a class=""scroll-up"" href=""#book"">Book Now</a>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 185 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"brand-logo-area ptb-100\">\r\n        <div class=\"container\">\r\n            <div class=\"brand-logo-active owl-carousel\">\r\n\r\n");
#nullable restore
#line 197 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                 foreach (var item in @Model.MasterPartner)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single-brand-logo\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f2938ae25849a8db48fa320ad9bc4ed864d5ee728552", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8928, "~/Partner_img/", 8928, 14, true);
#nullable restore
#line 200 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 8942, item.MasterPartnerLogoImageUrl, 8942, 31, false);

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
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 202 "C:\Users\ASUS\Desktop\Finalproject\FianlProjectAhmed\Menu\SystemRestaurant\Restaurant\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
