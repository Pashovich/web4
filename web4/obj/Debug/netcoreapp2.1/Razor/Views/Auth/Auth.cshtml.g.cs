#pragma checksum "C:\Users\USER\source\repos\web4\web4\Views\Auth\Auth.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dcc80d782d8650eb326e7dbf7a12147485a159e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Auth), @"mvc.1.0.view", @"/Views/Auth/Auth.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/Auth.cshtml", typeof(AspNetCore.Views_Auth_Auth))]
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
#line 1 "C:\Users\USER\source\repos\web4\web4\Views\_ViewImports.cshtml"
using web4;

#line default
#line hidden
#line 2 "C:\Users\USER\source\repos\web4\web4\Views\_ViewImports.cshtml"
using web4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dcc80d782d8650eb326e7dbf7a12147485a159e", @"/Views/Auth/Auth.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96711db60cf0259b5d6df80dd7ebfe36bf465174", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Auth : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<web4.Models.ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\USER\source\repos\web4\web4\Views\Auth\Auth.cshtml"
  
    ViewData["Title"] = "Sign Up";

#line default
#line hidden
            BeginContext(75, 19, true);
            WriteLiteral("<h2>Auth</h2>\r\n\r\n\r\n");
            EndContext();
            BeginContext(94, 280, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4356926fb5b4762aed598d75cf0fca5", async() => {
                BeginContext(163, 10, true);
                WriteLiteral("\r\n    <div");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 173, "\"", 209, 2);
                WriteAttributeValue("", 181, "display:", 181, 8, true);
#line 10 "C:\Users\USER\source\repos\web4\web4\Views\Auth\Auth.cshtml"
WriteAttributeValue("", 189, ViewBag.visibleuser, 189, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(210, 11, true);
                WriteLiteral(">\r\n        ");
                EndContext();
                BeginContext(222, 25, false);
#line 11 "C:\Users\USER\source\repos\web4\web4\Views\Auth\Auth.cshtml"
   Write(Html.Partial("_UserForm"));

#line default
#line hidden
                EndContext();
                BeginContext(247, 22, true);
                WriteLiteral("\r\n    </div>\r\n    <div");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 269, "\"", 308, 2);
                WriteAttributeValue("", 277, "display:", 277, 8, true);
#line 13 "C:\Users\USER\source\repos\web4\web4\Views\Auth\Auth.cshtml"
WriteAttributeValue("", 285, ViewBag.visibleprivate, 285, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(309, 11, true);
                WriteLiteral(">\r\n        ");
                EndContext();
                BeginContext(321, 32, false);
#line 14 "C:\Users\USER\source\repos\web4\web4\Views\Auth\Auth.cshtml"
   Write(Html.Partial("_PrivateUserForm"));

#line default
#line hidden
                EndContext();
                BeginContext(353, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
#line 9 "C:\Users\USER\source\repos\web4\web4\Views\Auth\Auth.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<web4.Models.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
