#pragma checksum "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\Shop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd8fec6d85b4405022c44474a963a72d81385c16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Details), @"mvc.1.0.view", @"/Views/Shop/Details.cshtml")]
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
#line 1 "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\_ViewImports.cshtml"
using ShopApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\_ViewImports.cshtml"
using ShopApp.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\_ViewImports.cshtml"
using ShopApp.Entites;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd8fec6d85b4405022c44474a963a72d81385c16", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b8625fe3f7872933458ecdd375ed6557262f77", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\Shop\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 181, "\"", 215, 2);
            WriteAttributeValue("", 187, "/img/", 187, 5, true);
#nullable restore
#line 10 "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\Shop\Details.cshtml"
WriteAttributeValue("", 192, Model.product.ImageUrl, 192, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 216, "\"", 241, 1);
#nullable restore
#line 10 "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\Shop\Details.cshtml"
WriteAttributeValue("", 222, Model.product.Name, 222, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"mb-3\">\r\n            ");
#nullable restore
#line 14 "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\Shop\Details.cshtml"
       Write(Model.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n        <hr />\r\n");
#nullable restore
#line 17 "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\Shop\Details.cshtml"
         foreach (var category in Model.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"#\" class=\"btn btn-link p-0 mb-3\">");
#nullable restore
#line 19 "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\Shop\Details.cshtml"
                                                 Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 20 "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\Shop\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    <div class=\"mb-3\">\r\n        <h4 class=\"text-primary mb-3\">\r\n            ");
#nullable restore
#line 24 "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\Shop\Details.cshtml"
       Write(Model.product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL\r\n        </h4>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd8fec6d85b4405022c44474a963a72d81385c167264", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 817, "\"", 842, 1);
#nullable restore
#line 28 "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\Shop\Details.cshtml"
WriteAttributeValue("", 825, Model.product.Id, 825, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            <div class=""input-group mb-3"" >
            <input type=""number"" name=""quantity"" class=""form-control"" min=""1"" value=""1"" step=""1"" style=""width:100px""/>
               
            <div class=""input-group-append"">
                <button type=""submit"" class=""btn btn-primary"">
                    <i class=""fas fa-cart-plus"">
                        Add To Cart
                    </i>
                </button>
            </div>
            </div>    
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <p class=\"p-3\">\r\n            ");
#nullable restore
#line 47 "C:\Users\merta\Desktop\WebProje\ShopApp\ShopApp.Web\Views\Shop\Details.cshtml"
       Write(Html.Raw(Model.product.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
