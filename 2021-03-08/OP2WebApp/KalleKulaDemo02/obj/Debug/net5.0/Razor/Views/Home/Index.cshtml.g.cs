#pragma checksum "C:\Users\Administrator\Desktop\Code\YSYS-OP2\2021-03-08\OP2WebApp\KalleKulaDemo02\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07ff966d7ddc2240718e73687b6b5c798e283fe7"
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
#line 1 "C:\Users\Administrator\Desktop\Code\YSYS-OP2\2021-03-08\OP2WebApp\KalleKulaDemo02\Views\_ViewImports.cshtml"
using KalleKulaDemo02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\Code\YSYS-OP2\2021-03-08\OP2WebApp\KalleKulaDemo02\Views\_ViewImports.cshtml"
using KalleKulaDemo02.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07ff966d7ddc2240718e73687b6b5c798e283fe7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9731b7a1e72b1ccfe2e0367701e38f532284a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KalleKulaDemo02.Models.ViewModels.Home.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Code\YSYS-OP2\2021-03-08\OP2WebApp\KalleKulaDemo02\Views\Home\Index.cshtml"
      
    ViewData["Title"] = "Home Page";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h2 class=\"display-4\">Welcome</h2>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07ff966d7ddc2240718e73687b6b5c798e283fe74014", async() => {
                WriteLiteral("\r\n            <input type=\"text\" name=\"city\" id=\"city\" />\r\n            <input type=\"text\" name=\"city2\" id=\"city2\" />\r\n            <input type=\"submit\" value=\"Kolla tempen\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Administrator\Desktop\Code\YSYS-OP2\2021-03-08\OP2WebApp\KalleKulaDemo02\Views\Home\Index.cshtml"
         if (Model.HasCustomTemp)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>I ");
#nullable restore
#line 18 "C:\Users\Administrator\Desktop\Code\YSYS-OP2\2021-03-08\OP2WebApp\KalleKulaDemo02\Views\Home\Index.cshtml"
            Write(Model.CustomTempName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" har det ");
#nullable restore
#line 18 "C:\Users\Administrator\Desktop\Code\YSYS-OP2\2021-03-08\OP2WebApp\KalleKulaDemo02\Views\Home\Index.cshtml"
                                          Write(Model.CustomTemp);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Celsius</p>\r\n");
#nullable restore
#line 19 "C:\Users\Administrator\Desktop\Code\YSYS-OP2\2021-03-08\OP2WebApp\KalleKulaDemo02\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <h3>Karlstad</h3>\r\n            <p>");
#nullable restore
#line 25 "C:\Users\Administrator\Desktop\Code\YSYS-OP2\2021-03-08\OP2WebApp\KalleKulaDemo02\Views\Home\Index.cshtml"
          Write(Model.KarlstadTemp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col\">\r\n            <h3>Stockholm</h3>\r\n            <p>");
#nullable restore
#line 29 "C:\Users\Administrator\Desktop\Code\YSYS-OP2\2021-03-08\OP2WebApp\KalleKulaDemo02\Views\Home\Index.cshtml"
          Write(Model.StockholmTemp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col\">\r\n            <h3>Lund</h3>\r\n            <p>");
#nullable restore
#line 33 "C:\Users\Administrator\Desktop\Code\YSYS-OP2\2021-03-08\OP2WebApp\KalleKulaDemo02\Views\Home\Index.cshtml"
          Write(Model.LundTemp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col\">\r\n            <h3>Buxtehude</h3>\r\n            <p>");
#nullable restore
#line 37 "C:\Users\Administrator\Desktop\Code\YSYS-OP2\2021-03-08\OP2WebApp\KalleKulaDemo02\Views\Home\Index.cshtml"
          Write(Model.BuxtehudeTemp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KalleKulaDemo02.Models.ViewModels.Home.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
