#pragma checksum "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\DoctorArea\InfoAppointment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6678224d1ded3e409aad50e6170c4649f4ab1f85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_DoctorArea_InfoAppointment), @"mvc.1.0.view", @"/Areas/Manage/Views/DoctorArea/InfoAppointment.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\_ViewImports.cshtml"
using HospitalMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\_ViewImports.cshtml"
using HospitalMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\_ViewImports.cshtml"
using HospitalMS.Areas.Manage.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6678224d1ded3e409aad50e6170c4649f4ab1f85", @"/Areas/Manage/Views/DoctorArea/InfoAppointment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"862aec472cb1c06309c139ae7d893354401614fb", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manage_Views_DoctorArea_InfoAppointment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorAppointment>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptAppointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 class=""text-center mt-4"">Information about Comment</h1>

<div class=""container mt-5"">
    <div class=""row"">
        <div class=""col-lg-8 mx-auto d-flex justify-content-center"">
            <div class=""card"" style=""background-color: #cff4fc; width:100%;"">
                <div class=""card-body"">
                    <h5 class=""card-title"">FullName: ");
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\DoctorArea\InfoAppointment.cshtml"
                                                Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5 class=\"card-title\">Email: ");
#nullable restore
#line 11 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\DoctorArea\InfoAppointment.cshtml"
                                             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5 class=\"card-title\">Doctor name: ");
#nullable restore
#line 12 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\DoctorArea\InfoAppointment.cshtml"
                                                   Write(Model.Doctor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5 class=\"card-title\">Date: ");
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\DoctorArea\InfoAppointment.cshtml"
                                            Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5 class=\"card-title\">Time: ");
#nullable restore
#line 14 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\DoctorArea\InfoAppointment.cshtml"
                                            Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5 class=\"card-title\">Status: <span style=\"color:green\"");
            BeginWriteAttribute("class", " class=\"", 769, "\"", 821, 3);
            WriteAttributeValue("", 777, "badge", 777, 5, true);
            WriteAttributeValue(" ", 782, "badge-", 783, 7, true);
#nullable restore
#line 15 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\DoctorArea\InfoAppointment.cshtml"
WriteAttributeValue("", 789, Model.Status?"success":"info", 789, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\DoctorArea\InfoAppointment.cshtml"
                                                                                                                              Write(Model.Status?"Confirmed":"Waiting");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n");
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\DoctorArea\InfoAppointment.cshtml"
                     if (!Model.Status)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6678224d1ded3e409aad50e6170c4649f4ab1f859221", async() => {
                WriteLiteral("\r\n                            <input name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1082, "\"", 1099, 1);
#nullable restore
#line 19 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\DoctorArea\InfoAppointment.cshtml"
WriteAttributeValue("", 1090, Model.Id, 1090, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" />\r\n                            <button type=\"submit\" class=\"btn btn-success\">Accept</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Areas\Manage\Views\DoctorArea\InfoAppointment.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6678224d1ded3e409aad50e6170c4649f4ab1f8511817", async() => {
                WriteLiteral("Go to back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorAppointment> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
