#pragma checksum "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\Book\DetailBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f156a0d671898fa27d2e95c2c9155d6716469837"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_DetailBook), @"mvc.1.0.view", @"/Views/Book/DetailBook.cshtml")]
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
#line 1 "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\_ViewImports.cshtml"
using VitaBookStrore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\_ViewImports.cshtml"
using VitaBookStrore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\_ViewImports.cshtml"
using VitaBookStrore.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\_ViewImports.cshtml"
using VitaBookStrore.ViewModels.User;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f156a0d671898fa27d2e95c2c9155d6716469837", @"/Views/Book/DetailBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad89b0f7b70d54a9e943e8f911364c9fd9cbe25", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_DetailBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\Book\DetailBook.cshtml"
   var avatarPath = $"/images/{ (Model.book.AvatarPath ?? "nonavatar.png")}";


#line default
#line hidden
#nullable disable
            WriteLiteral("<from>\r\n    <div class=\" row\">\r\n        <div class=\"col-sm-4\">\r\n            <div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 216, "\"", 233, 1);
#nullable restore
#line 9 "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\Book\DetailBook.cshtml"
WriteAttributeValue("", 222, avatarPath, 222, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width="" 300"" , height="" 500"">
            </div>
        </div>

        <div class="" col-8 table"">

            <table class="" table-primary"">
                <tr>
                    <th width="" 150"">
                        <h6> Tên sách: </h6>

                    </th>
                    <th>
                        <h6> ");
#nullable restore
#line 22 "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\Book\DetailBook.cshtml"
                        Write(Model.book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                    </th>\r\n                </tr>\r\n                <tr>\r\n                    <th>\r\n                        <h6>Tác giả: </h6>\r\n\r\n                    </th>\r\n                    <th>\r\n                        <h6> ");
#nullable restore
#line 32 "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\Book\DetailBook.cshtml"
                        Write(Model.book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                    </th>\r\n                </tr>\r\n                <tr>\r\n                    <th>\r\n                        <h6> Giá bìa: </h6>\r\n\r\n                    </th>\r\n                    <th>\r\n                        <h6> ");
#nullable restore
#line 42 "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\Book\DetailBook.cshtml"
                        Write(Model.book.Price.ToString("#,##0 VNĐ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                    </th>\r\n                </tr>\r\n                <tr>\r\n                    <th>\r\n                        <h6>Thể loại:</h6>\r\n\r\n                    </th>\r\n                    <th>\r\n                        <h6> ");
#nullable restore
#line 52 "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\Book\DetailBook.cshtml"
                        Write(Model.book.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                    </th>\r\n                </tr>\r\n                <tr>\r\n                    <th>\r\n                        <h6>Giới thiệu: </h6>\r\n\r\n                    </th>\r\n                    <th>\r\n                        <h6> ");
#nullable restore
#line 62 "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\Book\DetailBook.cshtml"
                        Write(Model.book.Depscrip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                    </th>\r\n                </tr>\r\n\r\n            </table>\r\n\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f156a0d671898fa27d2e95c2c9155d67164698378166", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\Book\DetailBook.cshtml"
                                                           WriteLiteral(Model.book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f156a0d671898fa27d2e95c2c9155d671646983710640", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "G:\codegym\module2\VitaBookStrore\VitaBookStrore\Views\Book\DetailBook.cshtml"
                                                                   WriteLiteral(Model.book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n     </div>\r\n\r\n</from>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591