#pragma checksum "C:\Users\Администратор.000\source\repos\FirstApp\FirstApp\Views\Home\Change.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7436dc5e235b061d2ef1e00530593501c9d3bc28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Change), @"mvc.1.0.view", @"/Views/Home/Change.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Change.cshtml", typeof(AspNetCore.Views_Home_Change))]
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
#line 1 "C:\Users\Администратор.000\source\repos\FirstApp\FirstApp\Views\_ViewImports.cshtml"
using FirstApp;

#line default
#line hidden
#line 2 "C:\Users\Администратор.000\source\repos\FirstApp\FirstApp\Views\_ViewImports.cshtml"
using FirstApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7436dc5e235b061d2ef1e00530593501c9d3bc28", @"/Views/Home/Change.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b951a5d3431184d260cd5fa679540aa680aa4c0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Change : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Администратор.000\source\repos\FirstApp\FirstApp\Views\Home\Change.cshtml"
   
    ViewData["Title"]= "Изменение данных";

#line default
#line hidden
            BeginContext(52, 47, true);
            WriteLiteral("\r\n        <h2>Внесите изменения:</h2>\r\n        ");
            EndContext();
            BeginContext(99, 2128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ea81f5449854beb9bac006f58328a50", async() => {
                BeginContext(155, 34, true);
                WriteLiteral("\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 189, "\"", 215, 1);
#line 7 "C:\Users\Администратор.000\source\repos\FirstApp\FirstApp\Views\Home\Change.cshtml"
WriteAttributeValue("", 197, ViewBag.PersonaID, 197, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(216, 2004, true);
                WriteLiteral(@" name=""PersonaID"" />
            
            <div class=""form-group"">
                <label for=""FirstName"" class=""col-md-2 control-label"">Имя:</label>
                <div class=""col-md-4"">
                    <input type=""text"" name=""FirstName"" class=""form-control"" />
                </div>
            </div>
            <div class=""form-group"">
                <label for=""LastName"" class=""col-md-2 control-label"">Фамилия:</label>
                <div class=""col-md-4"">
                    <input type=""text"" name=""LastName"" class=""form-control"" />
                </div>
            </div>
            <div class=""form-group"">
                <label for=""FatherName"" class=""col-md-2 control-label"">Отчество:</label>
                <div class=""col-md-4"">
                    <input type=""text"" name=""FatherName"" class=""form-control"" />
                </div>
            </div>
            <div class=""form-group"">
                <label for=""Phone"" class=""col-md-2 control-label"">Телефон:</labe");
                WriteLiteral(@"l>
                <div class=""col-md-4"">
                    <input type=""number"" name=""Phone"" class=""form-control"" />
                </div>
            </div>
            <div class=""form-group"">
                <label for=""Sex"" class=""col-md-2 control-label"">Пол:</label>
                <div class=""col-md-4"">
                    <input type=""text"" name=""Sex"" class=""form-control"" />
                </div>
            </div>
            <div class=""form-group"">
                <label for=""Country"" class=""col-md-2 control-label"">Страна проживания:</label>
                <div class=""col-md-4"">
                    <input type=""text"" name=""Country"" class=""form-control"" />
                </div>
            </div>
            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" class=""btn btn-default"" value=""Внести изменения"" />
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2227, 8, true);
            WriteLiteral("\r\n    \r\n");
            EndContext();
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