#pragma checksum "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7cff7226c055faa9f5f9887c6383fadcc4b8740"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index1___Copy), @"mvc.1.0.view", @"/Views/Home/Index1 - Copy.cshtml")]
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
#nullable restore
#line 1 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
using Dtos.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7cff7226c055faa9f5f9887c6383fadcc4b8740", @"/Views/Home/Index1 - Copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b9d12ff03896a3fea0d450f7260943af329e6cc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index1___Copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductByTypeDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/cart/cart.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""site-wrap"">
    <!-- product section -->
    <div class=""product-section layout_padding"" data-aos=""fade-up"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8 offset-lg-2 text-center"">
                    <div class=""section-title"">
                        <h3><span class=""blue-text"">");
#nullable restore
#line 16 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
                                               Write(Model.FirstOrDefault().ProductTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                    </div>
                </div>
            </div>
            <script>
    function navigateToSignIn(productType,productId,url){
        debugger
        localStorage.setItem(""productType"",productType);
        localStorage.setItem(""productId"",productId);
        localStorage.setItem(""productURL"",url);
        location.href=""/cart/add/""+productId;
    }
</script>
            <div class=""row"">
");
#nullable restore
#line 31 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
                 if (Model.Any())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-3 col-md-4 col-sm-12\">\r\n                            <div class=\"Jewellery-box\">\r\n                        <h5>$ ");
#nullable restore
#line 37 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <i>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1376, "\"", 1447, 1);
#nullable restore
#line 39 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
WriteAttributeValue("", 1383, Url.Action("Product_Details","Products",new{productId=item.Id}), 1383, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b7cff7226c055faa9f5f9887c6383fadcc4b87406831", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1472, "~/Product/", 1472, 10, true);
#nullable restore
#line 39 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
AddHtmlAttributeValue("", 1482, item.Image, 1482, 11, false);

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
            WriteLiteral("</a>\r\n                        </i>\r\n                        <h3>");
#nullable restore
#line 41 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                       \r\n                            <a style=\"color:#fff!important;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1663, "\"", 1795, 7);
            WriteAttributeValue("", 1673, "navigateToSignIn(\'", 1673, 18, true);
#nullable restore
#line 43 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
WriteAttributeValue("", 1691, item.Name, 1691, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1701, "\',\'", 1701, 3, true);
#nullable restore
#line 43 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
WriteAttributeValue("", 1704, item.Id, 1704, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1712, "\',\'", 1712, 3, true);
#nullable restore
#line 43 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
WriteAttributeValue("", 1715, Url.Action("AddToCart", "Cart", new { Id = item.Id }, Context.Request.Scheme), 1715, 78, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1793, "\')", 1793, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"test-btn\">\r\n");
            WriteLiteral("                            Add to Cart\r\n                        </a>\r\n                    </div>  </div>\r\n");
#nullable restore
#line 48 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
                     
                    }
                    else{
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-3 col-md-4 col-sm-12\">\r\n                            <div class=\"Jewellery-box\">\r\n\r\n                                <p>No product found under this type</p>\r\n                            </div></div>\r\n");
#nullable restore
#line 57 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"view-more-products\">\r\n                    <a link asp-append-version=\"true\" rel=\"stylesheet\"");
            BeginWriteAttribute("href", " href=\"", 2592, "\"", 2640, 1);
#nullable restore
#line 59 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
WriteAttributeValue("", 2599, Url.Action("Filter_Products","Products"), 2599, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        View More
                    </a>
                </div>
            </div>
        </div>
    </div>
    <!-- end product section -->

</div>


 <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/2.2.4/jquery.min.js""></script>
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/screenfull.js/3.2.0/screenfull.min.js""></script>
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7cff7226c055faa9f5f9887c6383fadcc4b874012095", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 75 "D:\medAmbian\medAmbian\ECommerce\Views\Home\Index1 - Copy.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductByTypeDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
