#pragma checksum "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojoSurveyWithModel/Views/Result/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3887f9427c5f0eba02dbf2352c7f6fbe1e01e734"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Result_Result), @"mvc.1.0.view", @"/Views/Result/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Result/Result.cshtml", typeof(AspNetCore.Views_Result_Result))]
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
#line 1 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojoSurveyWithModel/Views/_ViewImports.cshtml"
using dojoSurveyWithModel;

#line default
#line hidden
#line 1 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojoSurveyWithModel/Views/Result/Result.cshtml"
using dojoSurveyWithModel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3887f9427c5f0eba02dbf2352c7f6fbe1e01e734", @"/Views/Result/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e903845cad5c5e62700f1452843d7fe4f56bd80", @"/Views/_ViewImports.cshtml")]
    public class Views_Result_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(81, 417, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3887f9427c5f0eba02dbf2352c7f6fbe1e01e7343359", async() => {
                BeginContext(87, 404, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">

    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Result</title>
");
                EndContext();
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
            EndContext();
            BeginContext(498, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(499, 327, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3887f9427c5f0eba02dbf2352c7f6fbe1e01e7344938", async() => {
                BeginContext(505, 59, true);
                WriteLiteral("\n    <div>\n        <h2>Submitted Info</h2>\n        <p>Name:");
                EndContext();
                BeginContext(565, 10, false);
#line 16 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojoSurveyWithModel/Views/Result/Result.cshtml"
           Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(575, 30, true);
                WriteLiteral("</p>\n        <p>Dojo Location:");
                EndContext();
                BeginContext(606, 14, false);
#line 17 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojoSurveyWithModel/Views/Result/Result.cshtml"
                    Write(Model.Location);

#line default
#line hidden
                EndContext();
                BeginContext(620, 34, true);
                WriteLiteral("</p>\n        <p>Favorite Language:");
                EndContext();
                BeginContext(655, 14, false);
#line 18 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojoSurveyWithModel/Views/Result/Result.cshtml"
                        Write(Model.Language);

#line default
#line hidden
                EndContext();
                BeginContext(669, 24, true);
                WriteLiteral("</p>\n        <p>Comment:");
                EndContext();
                BeginContext(694, 13, false);
#line 19 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojoSurveyWithModel/Views/Result/Result.cshtml"
              Write(Model.Comment);

#line default
#line hidden
                EndContext();
                BeginContext(707, 112, true);
                WriteLiteral("</p>\n    </div>\n    <a class=\"btn btn-primary\" href=\"/\"><button class=\"btn btn-primary\">Back</button></a> \n    \n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(826, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
