#pragma checksum "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11d25ea7386367af28cea99c5ef25ecd6159ac4e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11d25ea7386367af28cea99c5ef25ecd6159ac4e", @"/Views/Student/Prikaz.cshtml")]
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

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"display-3\">Pregled liste studenata</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11d25ea7386367af28cea99c5ef25ecd6159ac4e3916", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"input-group col\">\r\n            <input class=\"form-control\" name=\"filter\"");
                BeginWriteAttribute("value", " value=\"", 278, "\"", 299, 1);
#nullable restore
#line 13 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
WriteAttributeValue("", 286, Model.filter, 286, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            <div class=""input-group-append"">
                <input class=""btn btn-outline-secondary rounded"" type=""submit"" value=""Pretraži"" />
            </div>
            <button class=""btn btn-outline-secondary col-3 ml-2 mr-2"" type=""button"" onclick=""window.location='/Student/DodajUredi'"">Dodaj studenta</button>
            <button class=""btn btn-outline-secondary col-3"" type=""button"" onclick=""window.location='/TestniPodaci/GenerisiPodatke'"">Generiši podatke</button>
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
#line 41 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
         foreach (StudentPrikazVM.Row s in Model.studenti)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 44 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
                                    Write(s.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 45 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
                                    Write(s.BrojIndeksa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 46 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
                                    Write(s.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 47 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
                                    Write(s.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 48 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
                                    Write(s.OpcinaRodjenja);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 49 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
                                    Write(s.OpcinaPrebivalista);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <div class=\"btn-group\">\r\n                        <button class=\"btn btn-outline-primary col mr-1\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1824, "\"", 1881, 3);
            WriteAttributeValue("", 1834, "window.location=\'/Student/DodajUredi?sID=", 1834, 41, true);
#nullable restore
#line 52 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
WriteAttributeValue("", 1875, s.ID, 1875, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1880, "\'", 1880, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Uredi</button>\r\n                        <button class=\"btn btn-outline-danger col\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1979, "\"", 2032, 3);
            WriteAttributeValue("", 1989, "window.location=\'/Student/Obrisi?sID=", 1989, 37, true);
#nullable restore
#line 53 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
WriteAttributeValue("", 2026, s.ID, 2026, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2031, "\'", 2031, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Obriši</button>\r\n                        <button class=\"btn btn-outline-info col ml-1 mr-1\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2139, "\"", 2169, 3);
            WriteAttributeValue("", 2149, "PrikaziOcjene(", 2149, 14, true);
#nullable restore
#line 54 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
WriteAttributeValue("", 2163, s.ID, 2163, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2168, ")", 2168, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Ocjene</button>\r\n                        <button class=\"btn btn-outline-info col\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2266, "\"", 2299, 3);
            WriteAttributeValue("", 2276, "PrikaziPrisustvo(", 2276, 17, true);
#nullable restore
#line 55 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
WriteAttributeValue("", 2293, s.ID, 2293, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2298, ")", 2298, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Prisustvo</button>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 59 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Prikaz.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<br />

<div id=""informacije""></div>

<script>
    //AJAX poziv - učitava dio stranice on demand
    function PrikaziOcjene(sID) {

        var url = ""/StudentOcjene/Prikaz?sID="" + sID;

        $.get(url, function (sadrzaj) {
            $(""#informacije"").html(sadrzaj);
        });
    }

    function PrikaziPrisustvo(sID) {

        var url = ""/StudentPrisustvo/Prikaz?sID="" + sID;

        $.get(url, function (sadrzaj) {
            $(""#informacije"").html(sadrzaj);
        });
    }

    
</script>

");
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
