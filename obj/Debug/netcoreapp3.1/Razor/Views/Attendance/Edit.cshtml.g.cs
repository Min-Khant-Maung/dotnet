#pragma checksum "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "918ce69969a07895f0d542223f11578bc913fc5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendance_Edit), @"mvc.1.0.view", @"/Views/Attendance/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"918ce69969a07895f0d542223f11578bc913fc5b", @"/Views/Attendance/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"186a325e9be5884874025fb3b979139569bc8ee5", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendance_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AttendanceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/attendance/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "918ce69969a07895f0d542223f11578bc913fc5b5534", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "918ce69969a07895f0d542223f11578bc913fc5b5796", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>Attendance Entry</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "918ce69969a07895f0d542223f11578bc913fc5b7717", async() => {
                WriteLiteral("\r\n    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 230, "\"", 247, 1);
#nullable restore
#line 7 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
WriteAttributeValue("", 238, Model.Id, 238, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Id\" hidden />\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">AttendanceDate</label>\r\n        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 399, "\"", 451, 1);
#nullable restore
#line 10 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
WriteAttributeValue("", 407, Model.AttendanceDate.ToString("yyyy-MM-dd"), 407, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"AttendanceDate\" required>\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">InTime</label>\r\n        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 619, "\"", 640, 1);
#nullable restore
#line 14 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
WriteAttributeValue("", 627, Model.Intime, 627, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"InTime\" required>\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">OutTime</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"OutTime\"");
                BeginWriteAttribute("value", " value=\"", 816, "\"", 838, 1);
#nullable restore
#line 18 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
WriteAttributeValue("", 824, Model.OutTime, 824, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required>\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">IsLeave</label>\r\n        <input type=\"radio\" class=\"form-control\" name=\"IsLeave\" value=\"Leave\"");
                BeginWriteAttribute("checked", " checked=", 1015, "", 1038, 1);
#nullable restore
#line 22 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
WriteAttributeValue("", 1024, Model.IsLeave, 1024, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">IsLate</label>\r\n        <input type=\"radio\" class=\"form-control\" name=\"IsLate\" value=\"Late\"");
                BeginWriteAttribute("checked", " checked=", 1202, "", 1224, 1);
#nullable restore
#line 26 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
WriteAttributeValue("", 1211, Model.IsLate, 1211, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Student</label>\r\n        <select name=\"StudentId\" class=\"form-control\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "918ce69969a07895f0d542223f11578bc913fc5b11363", async() => {
#nullable restore
#line 31 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
                                        Write(Model.StudentName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
               WriteLiteral(Model.StudentId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
             foreach (var item in ViewBag.StudentList)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "918ce69969a07895f0d542223f11578bc913fc5b13501", async() => {
#nullable restore
#line 34 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
                                       Write(item.Text);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
                   WriteLiteral(item.Value);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n    </div>\r\n    <div class=\"mb-3\">\r\n");
#nullable restore
#line 39 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
         if (Model.IsLate.Equals("True"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label class=\"form-label\">IsLate</label>\r\n            <input type=\"radio\" class=\"form-control\" name=\"IsLate\" value=\"Late\" id=\"rdoIsLate\" checked />\r\n");
#nullable restore
#line 43 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label class=\"form-label\">IsLate</label>\r\n            <input type=\"radio\" class=\"form-control\" name=\"IsLate\" value=\"Late\" id=\"rdoIsLate\" />\r\n");
#nullable restore
#line 48 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
         if (Model.IsLeave.Equals("True"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label class=\"form-label\">IsLeave</label>\r\n            <input type=\"radio\" class=\"form-control\" name=\"IsLeave\" value=\"Leave\" id=\"rdoIsLeave\" checked>\r\n");
#nullable restore
#line 53 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label class=\"form-label\">IsLeave</label>\r\n            <input type=\"radio\" class=\"form-control\" name=\"IsLeave\" value=\"Leave\" id=\"rdoIsLeave\">\r\n");
#nullable restore
#line 58 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Attendance\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </div>

    <div class=""mb-3"">
        <div class=""row"">
            <div class=""col"">
                <input type=""submit"" class=""btn btn-success"" value=""Entry"" />
            </div>
            <div class=""col"">
                <input type=""reset"" class=""btn btn-secondary"" value=""Cancel"" />
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        $('#rdoIsLate').click(function () {
            $(""#rdoIsLeave"").prop(""checked"", false);
        });
        $('#rdoIsLeave').click(function () {
            $(""#rdoIsLate"").prop(""checked"", false);
        });
    });
</script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "918ce69969a07895f0d542223f11578bc913fc5b19597", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AttendanceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
