#pragma checksum "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "373d1ad5177b4b0c9349f36547881504c7924304"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 2 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\_ViewImports.cshtml"
using fiorella.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\_ViewImports.cshtml"
using fiorella.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\_ViewImports.cshtml"
using fiorella.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\_ViewImports.cshtml"
using fiorella.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\_ViewImports.cshtml"
using fiorella.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\_ViewImports.cshtml"
using fiorella.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"373d1ad5177b4b0c9349f36547881504c7924304", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be121f4a2adb768ec9fa82d2fb006cbe4dc9f61a", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<main class=""main pages"">
    <div class=""page-header breadcrumb-wrap"">
        <div class=""container"">
            <div class=""breadcrumb"">
                <a href=""index.html"" rel=""nofollow""><i class=""fi-rs-home mr-5""></i>Home</a>
                <span></span> Pages <span></span> About us
            </div>
        </div>
    </div>
    <div class=""page-content pt-50"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-10 col-lg-12 m-auto"">
                    <section class=""row align-items-center mb-50"">
                        <div class=""col-lg-6"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 717, "\"", 764, 2);
            WriteAttributeValue("", 723, "assets/imgs/page/", 723, 17, true);
#nullable restore
#line 23 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
WriteAttributeValue("", 740, Model.WelcomeNest.Image, 740, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 765, "\"", 771, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""border-radius-15 mb-md-3 mb-lg-0 mb-sm-4"" />
                        </div>
                        <div class=""col-lg-6"">
                            <div class=""pl-25"">
                                <h2 class=""mb-30"">Welcome to Nest</h2>
                                <p class=""mb-25"">");
#nullable restore
#line 28 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                            Write(Model.WelcomeNest.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"mb-50\">");
#nullable restore
#line 29 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                            Write(Model.WelcomeNest.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                
                            </div>
                        </div>
                    </section>
                    <section class=""text-center mb-50"">
                        <h2 class=""title style-3 mb-40"">What We Provide?</h2>
                        <div class=""row"">

");
#nullable restore
#line 38 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                             foreach (var item in Model.Provides)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-4 col-md-6 mb-24\">\r\n                                <div class=\"featured-card\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1780, "\"", 1821, 2);
            WriteAttributeValue("", 1786, "assets/imgs/theme/icons/", 1786, 24, true);
#nullable restore
#line 42 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
WriteAttributeValue("", 1810, item.Image, 1810, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1822, "\"", 1828, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <h4>");
#nullable restore
#line 43 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 44 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <a href=\"#\">Read more</a>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 48 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                          
                        </div>
                    </section>
                    <section class=""row align-items-center mb-50"">
                        <div class=""row mb-50 align-items-center"">
                            <div class=""col-lg-7 pr-30"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 2448, "\"", 2499, 2);
            WriteAttributeValue("", 2454, "assets/imgs/page/", 2454, 17, true);
#nullable restore
#line 56 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
WriteAttributeValue("", 2471, Model.OurPerformances.Image, 2471, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2500, "\"", 2506, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mb-md-3 mb-lg-0 mb-sm-4"" />
                            </div>
                            <div class=""col-lg-5"">
                                <h4 class=""mb-20 text-muted"">Our performance</h4>
                                <h1 class=""heading-1 mb-40""></h1>
                                <p class=""mb-30"">");
#nullable restore
#line 61 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                            Write(Model.OurPerformances.Descriptoion1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>");
#nullable restore
#line 62 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                              Write(Model.OurPerformances.Descriptoion2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-4 pr-30 mb-md-5 mb-lg-0 mb-sm-5"">
                                <h3 class=""mb-30"">Who we are</h3>
                                <p>Volutpat diam ut venenatis tellus in metus. Nec dui nunc mattis enim ut tellus eros donec ac odio orci ultrices in. ellus eros donec ac odio orci ultrices in.</p>
                            </div>
                            <div class=""col-lg-4 pr-30 mb-md-5 mb-lg-0 mb-sm-5"">
                                <h3 class=""mb-30"">Our history</h3>
                                <p>Volutpat diam ut venenatis tellus in metus. Nec dui nunc mattis enim ut tellus eros donec ac odio orci ultrices in. ellus eros donec ac odio orci ultrices in.</p>
                            </div>
                            <div class=""col-lg-4"">
                                <h3 class=""mb-30"">Our mission</h3>
                  ");
            WriteLiteral(@"              <p>Volutpat diam ut venenatis tellus in metus. Nec dui nunc mattis enim ut tellus eros donec ac odio orci ultrices in. ellus eros donec ac odio orci ultrices in.</p>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
        </div>
        <section class=""container mb-50 d-none d-md-block"">
            <div class=""row about-count"">
                <div class=""col-lg-1-5 col-md-6 text-center mb-lg-0 mb-md-5"">
                    <h1 class=""heading-1""><span class=""count"">12</span>+</h1>
                    <h4>Glorious years</h4>
                </div>
                <div class=""col-lg-1-5 col-md-6 text-center"">
                    <h1 class=""heading-1""><span class=""count"">36</span>+</h1>
                    <h4>Happy clients</h4>
                </div>
                <div class=""col-lg-1-5 col-md-6 text-center"">
                    <h1 class=""heading-1""><span class=""count"">58</span>+</h1>
");
            WriteLiteral(@"                    <h4>Projects complete</h4>
                </div>
                <div class=""col-lg-1-5 col-md-6 text-center"">
                    <h1 class=""heading-1""><span class=""count"">24</span>+</h1>
                    <h4>Team advisor</h4>
                </div>
                <div class=""col-lg-1-5 text-center d-none d-lg-block"">
                    <h1 class=""heading-1""><span class=""count"">26</span>+</h1>
                    <h4>Products Sale</h4>
                </div>
            </div>
        </section>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-10 col-lg-12 m-auto"">
                    <section class=""mb-50"">
                        <h2 class=""title style-3 mb-40 text-center"">Our Team</h2>
                        <div class=""row"">
                            <div class=""col-lg-4 mb-lg-0 mb-md-5 mb-sm-5"">
                                <h6 class=""mb-5 text-brand"">Our Team</h6>
                                <h1 clas");
            WriteLiteral("s=\"mb-30\">");
#nullable restore
#line 115 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                             Write(Model.ExpertMeet.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                <p class=\"mb-30\">");
#nullable restore
#line 116 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                            Write(Model.ExpertMeet.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"mb-30\">");
#nullable restore
#line 117 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                            Write(Model.ExpertMeet.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <a href=\"#\" class=\"btn\">View All Members</a>\r\n                            </div>\r\n                            <div class=\"col-lg-8\">\r\n                                <div class=\"row\">\r\n\r\n");
#nullable restore
#line 123 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                     foreach (var item in Model.OurTeams)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-lg-6 col-md-6\">\r\n                                        <div class=\"team-card\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 6743, "\"", 6777, 2);
            WriteAttributeValue("", 6749, "assets/imgs/page/", 6749, 17, true);
#nullable restore
#line 128 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
WriteAttributeValue("", 6766, item.Image, 6766, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6778, "\"", 6784, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            <div class=\"content text-center\">\r\n                                                <h4 class=\"mb-5\">");
#nullable restore
#line 130 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                                            Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                                <span>");
#nullable restore
#line 131 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                                 Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                <div class=\"social-network mt-20\">\r\n");
#nullable restore
#line 133 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                                     if (item.PinttLink.Count() > 0)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 7329, "\"", 7374, 2);
            WriteAttributeValue("", 7335, "assets/imgs/theme/icons/", 7335, 24, true);
#nullable restore
#line 135 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
WriteAttributeValue("", 7359, item.PinttLink, 7359, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7375, "\"", 7381, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n");
#nullable restore
#line 136 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"

                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 139 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                                     if (item.VimeoLink.Count() > 0)
                                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 7665, "\"", 7710, 2);
            WriteAttributeValue("", 7671, "assets/imgs/theme/icons/", 7671, 24, true);
#nullable restore
#line 142 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
WriteAttributeValue("", 7695, item.VimeoLink, 7695, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7711, "\"", 7717, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n");
#nullable restore
#line 143 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                                     if (item.TwtLink.Count() > 0)
                                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 7995, "\"", 8038, 2);
            WriteAttributeValue("", 8001, "assets/imgs/theme/icons/", 8001, 24, true);
#nullable restore
#line 147 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
WriteAttributeValue("", 8025, item.TwtLink, 8025, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8039, "\"", 8045, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n");
#nullable restore
#line 148 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"

                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                                     if (item.Fblink.Count() > 0)
                                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 8320, "\"", 8362, 2);
            WriteAttributeValue("", 8326, "assets/imgs/theme/icons/", 8326, 24, true);
#nullable restore
#line 153 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
WriteAttributeValue("", 8350, item.Fblink, 8350, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8363, "\"", 8369, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n");
#nullable restore
#line 154 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 159 "C:\Users\ROG\source\repos\Fiorella\fiorella\Views\About\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                   
                                </div>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
        </div>
    </div>
</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
