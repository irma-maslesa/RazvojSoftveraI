#pragma checksum "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\FakturaStavka\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4084f0f9e0713492d802543dc1935fa8dbbeefc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FakturaStavka_Index), @"mvc.1.0.view", @"/Views/FakturaStavka/Index.cshtml")]
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
#line 1 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\FakturaStavka\Index.cshtml"
using RS1_Faktura.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4084f0f9e0713492d802543dc1935fa8dbbeefc6", @"/Views/FakturaStavka/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25a3da0b819ed89bc36829902b6bfaf4dac19480", @"/Views/_ViewImports.cshtml")]
    public class Views_FakturaStavka_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FakturaStavkaPrikazVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\FakturaStavka\Index.cshtml"
  
    ViewData["Title"] = "Prikaz detalja o fakturi";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />

<table class=""table table-hover"">
    <thead class=""thead-dark text-center"">
        <tr>
            <th>Proizvod</th>
            <th>Cijena</th>
            <th>Kolicina</th>
            <th>Popust</th>
            <th>Iznos</th>
            <th>Akcija</th>
        </tr>
    </thead>
    <tbody class=""text-center"">
");
#nullable restore
#line 22 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\FakturaStavka\Index.cshtml"
         foreach (FakturaStavkaPrikazVM.Row fs in Model.Stavke)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 25 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\FakturaStavka\Index.cshtml"
                                    Write(fs.Proizvod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 26 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\FakturaStavka\Index.cshtml"
                                    Write(fs.Cijena);

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 27 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\FakturaStavka\Index.cshtml"
                                    Write(fs.Kolicina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 28 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\FakturaStavka\Index.cshtml"
                                    Write(fs.Popust);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 29 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\FakturaStavka\Index.cshtml"
                                    Write(fs.Iznos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM</td>\r\n                <td>\r\n                    <div class=\"btn-group\">\r\n                        <button class=\"btn btn-outline-info col mr-1\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1012, "\"", 1072, 3);
            WriteAttributeValue("", 1022, "window.location=\'/FakturaStavka/Obrisi?fID=", 1022, 43, true);
#nullable restore
#line 32 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\FakturaStavka\Index.cshtml"
WriteAttributeValue("", 1065, fs.ID, 1065, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1071, "\'", 1071, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Obriši</button>\r\n                        <button class=\"btn btn-outline-info col\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1169, "\"", 1230, 3);
            WriteAttributeValue("", 1179, "window.location=\'/FakturaStavka/Detalji?fID=", 1179, 44, true);
#nullable restore
#line 33 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\FakturaStavka\Index.cshtml"
WriteAttributeValue("", 1223, fs.ID, 1223, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1229, "\'", 1229, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Detalji</button>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "D:\OneDrive - Faculty of Information Technologies\Desktop\FAKTURA\RS1-Faktura\RS1-Faktura\Views\FakturaStavka\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FakturaStavkaPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
