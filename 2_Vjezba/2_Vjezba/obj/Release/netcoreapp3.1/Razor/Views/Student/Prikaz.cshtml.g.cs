#pragma checksum "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1187464e39136348bf5ad7377100599678344a76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Prikaz), @"mvc.1.0.view", @"/Views/Student/Prikaz.cshtml")]
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
#line 1 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\_ViewImports.cshtml"
using _2_Vjezba;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\_ViewImports.cshtml"
using _2_Vjezba.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
using _2_Vjezba.EntityModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1187464e39136348bf5ad7377100599678344a76", @"/Views/Student/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7838028048b5f6377129220c9b31e7136af82f0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentPrikazVM>
    {
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
#line 4 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
  
    ViewData["Title"] = "Prikaz";
    //List<Student> studenti = (List<Student>)ViewData["Studenti"];
    //StudentPrikazVM m = Model; --Mozemo koristiti samo varijablu Model
    //string filter = (string)ViewData["Filter"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"display-4\">Pregled liste studenata</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1187464e39136348bf5ad7377100599678344a764110", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"input-group col\">\r\n            <input class=\"form-control\" name=\"filter\"");
                BeginWriteAttribute("value", " value=\"", 472, "\"", 493, 1);
#nullable restore
#line 16 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
WriteAttributeValue("", 480, Model.filter, 480, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            <div class=""input-group-append"">
                <input class=""btn btn-outline-secondary rounded"" type=""submit"" value=""Pretraži"" />
            </div>
            <button class=""btn btn-outline-secondary col-5 ml-2"" type=""button"" onclick=""window.location='/Student/DodajUredi'"">Dodaj studenta</button>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<br />

<table class=""table table-hover"">
    <thead class=""thead-dark text-center"">
        <tr>
            <th>ID</th>
            <th>Broj indeksa</th>
            <th>Ime</th>
            <th>Prezime</th>
            <th>Općina rođenja</th>
            <th>Općina prebivališta</th>
            <th>Opcije</th>
        </tr>

    </thead>

    <tbody class=""text-center"">
");
#nullable restore
#line 42 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
         foreach (StudentPrikazVM.Row s in Model.studenti)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 45 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
                                    Write(s.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 46 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
                                    Write(s.BrojIndeksa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 47 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
                                    Write(s.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 48 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
                                    Write(s.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 49 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
                                    Write(s.OpcinaRodjenja);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 50 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
                                    Write(s.OpcinaPrebivalista);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <div class=\"btn-group\">\r\n                        <button class=\"btn btn-outline-primary col mr-1\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1852, "\"", 1909, 3);
            WriteAttributeValue("", 1862, "window.location=\'/Student/DodajUredi?sID=", 1862, 41, true);
#nullable restore
#line 53 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
WriteAttributeValue("", 1903, s.ID, 1903, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1908, "\'", 1908, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Uredi</button>\r\n                        <button class=\"btn btn-outline-danger col\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2007, "\"", 2060, 3);
            WriteAttributeValue("", 2017, "window.location=\'/Student/Obrisi?sID=", 2017, 37, true);
#nullable restore
#line 54 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
WriteAttributeValue("", 2054, s.ID, 2054, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2059, "\'", 2059, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Obriši</button>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 58 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591