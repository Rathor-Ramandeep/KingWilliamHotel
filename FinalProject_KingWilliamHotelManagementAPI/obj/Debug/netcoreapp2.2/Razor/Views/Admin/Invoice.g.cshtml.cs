#pragma checksum "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d7ded3efef8ff8329374d03fbd8184fa4ae087a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Invoice), @"mvc.1.0.view", @"/Views/Admin/Invoice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Invoice.cshtml", typeof(AspNetCore.Views_Admin_Invoice))]
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
#line 1 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\_ViewImports.cshtml"
using KingWilliamHotelManagementAPI;

#line default
#line hidden
#line 2 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\_ViewImports.cshtml"
using KingWilliamHotelManagementAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d7ded3efef8ff8329374d03fbd8184fa4ae087a", @"/Views/Admin/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97f87d3c73012df5c59ab0a95617ae7a8cbf1c1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KingWilliamHotelManagementAPI.Models.InvoiceModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InvoiceView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Invoice.cshtml"
  
    ViewData["Title"] = "Invoice";

#line default
#line hidden
            BeginContext(116, 410, true);
            WriteLiteral(@"
<h1>Invoice</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Customer:
            </th>
            <th>
                Room #:
            </th>
            <th>
                Start & End Date:
            </th>
            <th>
                Invoice Create Date:
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 28 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Invoice.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(575, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(624, 54, false);
#line 32 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Invoice.cshtml"
           Write(Html.DisplayFor(modelItem => item.TblPerson.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(678, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(680, 53, false);
#line 32 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Invoice.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.TblPerson.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(733, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(789, 54, false);
#line 35 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Invoice.cshtml"
           Write(Html.DisplayFor(modelItem => item.TblRooms.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(843, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(899, 61, false);
#line 38 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Invoice.cshtml"
           Write(Html.DisplayFor(modelItem => item.TblGuestStay.StartDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(960, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(964, 59, false);
#line 38 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Invoice.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => item.TblGuestStay.EndDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1079, 66, false);
#line 41 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Invoice.cshtml"
           Write(Html.DisplayFor(modelItem => item.TblGuestInvoice.InvoiceDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1200, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d7ded3efef8ff8329374d03fbd8184fa4ae087a7978", async() => {
                BeginContext(1275, 4, true);
                WriteLiteral("View");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Invoice.cshtml"
                                              WriteLiteral(item.TblGuestInvoice.InvoiceId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1283, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 47 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Invoice.cshtml"
            
        }

#line default
#line hidden
            BeginContext(1344, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KingWilliamHotelManagementAPI.Models.InvoiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
