#pragma checksum "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\Faktura\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f546b600d72cd70c5f2852e6a51108222260c84d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faktura_Index), @"mvc.1.0.view", @"/Views/Faktura/Index.cshtml")]
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
#line 1 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\_ViewImports.cshtml"
using RS1_Faktura;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\Faktura\Index.cshtml"
using RS1_Faktura.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f546b600d72cd70c5f2852e6a51108222260c84d", @"/Views/Faktura/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25a3da0b819ed89bc36829902b6bfaf4dac19480", @"/Views/_ViewImports.cshtml")]
    public class Views_Faktura_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FakturaPrikazVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\Faktura\Index.cshtml"
  
    ViewData["Title"] = "Prikaz fakture";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-5"">
        <button class=""btn btn-dark"" onclick=""window.location='/Faktura/Dodaj'"">Dodaj fakturu</button>
    </div>
</div>

<br />

<table class=""table table-hover"">
    <thead class=""thead-dark text-center"">
        <tr>
            <th>Faktura ID</th>
            <th>Datum</th>
            <th>Klijent</th>
            <th>Opcije</th>
        </tr>
    </thead>
    <tbody class=""text-center"">
");
#nullable restore
#line 26 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\Faktura\Index.cshtml"
         foreach (FakturaPrikazVM.Row f in Model.Fakture)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 29 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\Faktura\Index.cshtml"
                                    Write(f.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 30 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\Faktura\Index.cshtml"
                                    Write(f.Datum.ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 31 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\Faktura\Index.cshtml"
                                    Write(f.Klijent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <div class=\"btn-group\">\r\n");
            WriteLiteral("                        <button class=\"btn btn-outline-info col mr-1\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1142, "\"", 1195, 3);
            WriteAttributeValue("", 1152, "window.location=\'/Faktura/Obrisi?fID=", 1152, 37, true);
#nullable restore
#line 35 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\Faktura\Index.cshtml"
WriteAttributeValue("", 1189, f.ID, 1189, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1194, "\'", 1194, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Obriši</button>\r\n                        <button class=\"btn btn-outline-info col\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1292, "\"", 1346, 3);
            WriteAttributeValue("", 1302, "window.location=\'/Faktura/Detalji?fID=", 1302, 38, true);
#nullable restore
#line 36 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\Faktura\Index.cshtml"
WriteAttributeValue("", 1340, f.ID, 1340, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1345, "\'", 1345, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Detalji</button>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\Faktura\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FakturaPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
