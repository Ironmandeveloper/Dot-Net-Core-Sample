#pragma checksum "D:\medAmbian\medAmbian\ECommerce\Views\Faq\_AddPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "910ca2353f44711535ff29897e07b72bfc44c561"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faq__AddPartial), @"mvc.1.0.view", @"/Views/Faq/_AddPartial.cshtml")]
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
#line 1 "D:\medAmbian\medAmbian\ECommerce\Views\_ViewImports.cshtml"
using E_Comm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\medAmbian\medAmbian\ECommerce\Views\_ViewImports.cshtml"
using E_Comm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"910ca2353f44711535ff29897e07b72bfc44c561", @"/Views/Faq/_AddPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b9d12ff03896a3fea0d450f7260943af329e6cc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Faq__AddPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\medAmbian\medAmbian\ECommerce\Views\Faq\_AddPartial.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <style>
        .mt-33{
            margin-top:33px;
        }
    </style>

<div class=""col-12"">
    <div class=""card shadow "">
        <div class=""form-row card-body"">

            <div class=""form-group col-md-6"">
                <div>
                    <label for=""firstname"">Question</label>
                    <input type=""text"" id=""Question"" class=""form-control"">
                    <small id=""QuestionErr"" class=""text-danger""></small>
                </div>
                
                <div class=""mt-1"">
                    <label for=""firstname"">Answer</label>
                    <textarea class=""form-control"" id=""Answer"" rows=""4""></textarea>
                    <small id=""AnswerErr"" class=""text-danger""></small>
                </div>
              
            </div>
           <div class=""form-group col-md-3"">
                <div class=""custom-control custom-checkbox mt-33"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""active"">
  ");
            WriteLiteral("                  <label class=\"custom-control-label\" for=\"active\">Active/inActive</label>\r\n                </div>\r\n               \r\n            </div>\r\n            <div class=\"form-group col-md-3 text-right mt-4\">\r\n                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1414, "\"", 1465, 3);
            WriteAttributeValue("", 1424, "SaveFaq(\'", 1424, 9, true);
#nullable restore
#line 41 "D:\medAmbian\medAmbian\ECommerce\Views\Faq\_AddPartial.cshtml"
WriteAttributeValue("", 1433, Url.Action("AddOrEdit","Faq"), 1433, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1463, "\')", 1463, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-primary\">Submit</button>\r\n                <button type=\"button\" onclick=\"Clear()\" class=\"btn btn-secondary\">Reset</button>\r\n            </div>\r\n\r\n </div>\r\n\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
