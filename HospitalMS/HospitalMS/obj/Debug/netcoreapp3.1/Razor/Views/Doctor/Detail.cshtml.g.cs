#pragma checksum "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Views\Doctor\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e9fa1eb4e1c0a05e2a5e4f352fcb683bb23a527"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Detail), @"mvc.1.0.view", @"/Views/Doctor/Detail.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Views\_ViewImports.cshtml"
using HospitalMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Views\_ViewImports.cshtml"
using HospitalMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Views\_ViewImports.cshtml"
using HospitalMS.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e9fa1eb4e1c0a05e2a5e4f352fcb683bb23a527", @"/Views/Doctor/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f64fe9899ad51afadbcb32136b0c3a88f28d3dde", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Doctor_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorDetailViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
      <section id=""CardsSection"" class=""my-5"">
        <div class=""container"">
          <div class=""row d-flex flex-column align-items-center"">
            <div class=""col-lg-4 col-md-6 mb-2"">
              <div class=""card"">
               <a>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7e9fa1eb4e1c0a05e2a5e4f352fcb683bb23a5274398", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 333, "~/uploads/doctors/", 333, 18, true);
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Views\Doctor\Detail.cshtml"
AddHtmlAttributeValue("", 351, Model.Doctor.Image, 351, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n               </a>\r\n                <div class=\"card-body\">\r\n                  <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Views\Doctor\Detail.cshtml"
                                     Write(Model.Doctor.Name + " " + Model.Doctor.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                  <p class=\"card-text my-3\">\r\n                  Profession: ");
#nullable restore
#line 18 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Views\Doctor\Detail.cshtml"
                         Write(Model.Doctor.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </p>\r\n                   <p class=\"card-text my-3\">\r\n                  Experience: ");
#nullable restore
#line 21 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Views\Doctor\Detail.cshtml"
                         Write(Model.Doctor.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </p>\r\n                  <div\r\n                    class=\"card-body d-flex align-items-center justify-content-between\"\r\n                  >\r\n                   <input type=\"hidden\" name=\"doctorId\"");
            BeginWriteAttribute("value", " value=\"", 1073, "\"", 1097, 1);
#nullable restore
#line 26 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Views\Doctor\Detail.cshtml"
WriteAttributeValue("", 1081, Model.Doctor.Id, 1081, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                   ");
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Views\Doctor\Detail.cshtml"
              Write(await Html.PartialAsync("_DoctorAppointmentPartialView", Model.DoctorAppointment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   <span>Customers :</span> <span>");
#nullable restore
#line 28 "C:\Users\ASUS\Desktop\HospitalManagementSystem\HospitalMS\HospitalMS\Views\Doctor\Detail.cshtml"
                                             Write(Model.DoctorAppointments.Where(x=>x.Status==true).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
