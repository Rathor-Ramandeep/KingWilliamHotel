#pragma checksum "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa4b799d8a1399453c3584f9e1ae8503ae3939fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Employee), @"mvc.1.0.view", @"/Views/Admin/Employee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Employee.cshtml", typeof(AspNetCore.Views_Admin_Employee))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa4b799d8a1399453c3584f9e1ae8503ae3939fd", @"/Views/Admin/Employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97f87d3c73012df5c59ab0a95617ae7a8cbf1c1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KingWilliamHotelManagementAPI.Models.TblPerson>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Employee.cshtml"
  
    ViewData["Title"] = "Employee";

#line default
#line hidden
            BeginContext(114, 44, true);
            WriteLiteral("\r\n<h1>List of all Employee</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(158, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa4b799d8a1399453c3584f9e1ae8503ae3939fd4193", async() => {
                BeginContext(186, 80, true);
                WriteLiteral("<button type=\"button\" class=\"btn btn-outline-dark btn-sl\"> New Employee</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(270, 29, true);
            WriteLiteral("\r\n</p>\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 14 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Employee.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(340, 167, true);
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <br/>\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
            EndContext();
            BeginContext(508, 14, false);
#line 20 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Employee.cshtml"
                                      Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(522, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(524, 13, false);
#line 20 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Employee.cshtml"
                                                      Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(537, 69, true);
            WriteLiteral("</h5>\r\n                    <h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(607, 17, false);
#line 21 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Employee.cshtml"
                                                         Write(item.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(624, 48, true);
            WriteLiteral("</h6>\r\n                    <p class=\"card-text\">");
            EndContext();
            BeginContext(673, 16, false);
#line 22 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Employee.cshtml"
                                    Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(689, 79, true);
            WriteLiteral("</p>\r\n                    <div class=\"text-center\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 768, "\"", 806, 2);
            WriteAttributeValue("", 775, "./UpdateEmployee/", 775, 17, true);
#line 24 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Employee.cshtml"
WriteAttributeValue("", 792, item.PersonId, 792, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(807, 186, true);
            WriteLiteral(" class=\"card-link\"><button type=\"button\" class=\"btn btn-outline-dark btn-sl\"> Edit </button></a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 29 "C:\Durham College\Fall - 2019\DBAS\Content\Final Project\KingWilliamHotelSolution\FinalProject_KingWilliamHotelManagementAPI\Views\Admin\Employee.cshtml"
    }

#line default
#line hidden
            BeginContext(1000, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KingWilliamHotelManagementAPI.Models.TblPerson>> Html { get; private set; }
    }
}
#pragma warning restore 1591
