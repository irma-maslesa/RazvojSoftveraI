#pragma checksum "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Detalji.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9df7269d9c133d6eed765c23b97e103eef4932d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Detalji), @"mvc.1.0.view", @"/Views/Student/Detalji.cshtml")]
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
#line 1 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Detalji.cshtml"
using _2_Vjezba.EntityModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9df7269d9c133d6eed765c23b97e103eef4932d", @"/Views/Student/Detalji.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7838028048b5f6377129220c9b31e7136af82f0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Detalji : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StudentDetaljiVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Detalji.cshtml"
  
    ViewData["Title"] = "Prikaz";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""display-4"">Detalji o studentu</h1>

<br/>
<table class=""table table-hover"">
    <thead class=""thead-dark text-center"">
        <tr>
            <th>Predmet</th>
            <th>Ocjena</th>
            <th>Datum</th>
        </tr>

    </thead>

    <tbody class=""text-center"">
");
#nullable restore
#line 23 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Detalji.cshtml"
         foreach (StudentDetaljiVM s in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 26 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Detalji.cshtml"
                                    Write(s.NazivPredmeta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 27 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Detalji.cshtml"
                                    Write(s.OcjenaBroj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 28 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Detalji.cshtml"
                                    Write(s.Datum.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "D:\OneDrive - Faculty of Information Technologies\Desktop\RazvojSoftveraI\2_Vjezba\2_Vjezba\Views\Student\Detalji.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StudentDetaljiVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591