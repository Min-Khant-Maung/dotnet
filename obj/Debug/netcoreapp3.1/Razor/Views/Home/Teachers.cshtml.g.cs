#pragma checksum "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Home\Teachers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82e1a957daa7de581a6bfe22fc94744c596da802"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Teachers), @"mvc.1.0.view", @"/Views/Home/Teachers.cshtml")]
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
#line 1 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\_ViewImports.cshtml"
using SFMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\_ViewImports.cshtml"
using SFMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\_ViewImports.cshtml"
using SFMS.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82e1a957daa7de581a6bfe22fc94744c596da802", @"/Views/Home/Teachers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"186a325e9be5884874025fb3b979139569bc8ee5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Teachers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/teacher.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"    <!-- Header Start -->
<div class=""container-fluid page-header"" style=""margin-bottom: 90px;"">
    <div class=""container"">
        <div class=""d-flex flex-column justify-content-center"" style=""min-height: 300px"">
            <h3 class=""display-4 text-white text-uppercase"">Teachers</h3>
            <div class=""d-inline-flex text-white"">
                <p class=""m-0 text-uppercase""><a class=""text-white""");
            BeginWriteAttribute("href", " href=\"", 413, "\"", 420, 0);
            EndWriteAttribute();
            WriteLiteral(@">Home</a></p>
                <i class=""fa fa-angle-double-right pt-1 px-3""></i>
                <p class=""m-0 text-uppercase"">Teachers</p>
            </div>
        </div>
    </div>
</div>
<!-- Header End -->
<!-- Team Start -->
<div class=""container-fluid py-5"">
    <div class=""container pt-5 pb-3"">
        <div class=""text-center mb-5"">
            <h5 class=""text-primary text-uppercase mb-3"" style=""letter-spacing: 5px;"">Teachers</h5>
            <h1>Meet Our Teachers</h1>
        </div>
        <div class=""row"">
");
#nullable restore
#line 23 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Home\Teachers.cshtml"
             foreach (var t in ViewBag.Teachers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-3 text-center team mb-4\">\r\n                    <div class=\"team-item rounded overflow-hidden mb-2\">\r\n                        <div class=\"team-img position-relative\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82e1a957daa7de581a6bfe22fc94744c596da8025924", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""team-social"">
                                <a class=""btn btn-outline-light btn-square mx-1"" href=""#""><i class=""fab fa-twitter""></i></a>
                                <a class=""btn btn-outline-light btn-square mx-1"" href=""#""><i class=""fab fa-facebook-f""></i></a>
                                <a class=""btn btn-outline-light btn-square mx-1"" href=""#""><i class=""fab fa-linkedin-in""></i></a>
                            </div>
                        </div>
                        <div class=""bg-secondary p-4"">
                            <h5>");
#nullable restore
#line 36 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Home\Teachers.cshtml"
                           Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"m-0\">");
#nullable restore
#line 37 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Home\Teachers.cshtml"
                                      Write(t.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 41 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Home\Teachers.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<!-- Team End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591