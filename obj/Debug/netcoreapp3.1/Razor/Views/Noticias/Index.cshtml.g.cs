#pragma checksum "C:\Users\saman\OneDrive\Documentos\Aula37 Eplayers\Views\Noticias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6e09b3bfc3152069a445e16d8d1744d800d91a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Noticias_Index), @"mvc.1.0.view", @"/Views/Noticias/Index.cshtml")]
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
#line 1 "C:\Users\saman\OneDrive\Documentos\Aula37 Eplayers\Views\_ViewImports.cshtml"
using Aula37_Eplayers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saman\OneDrive\Documentos\Aula37 Eplayers\Views\_ViewImports.cshtml"
using Aula37_Eplayers.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6e09b3bfc3152069a445e16d8d1744d800d91a", @"/Views/Noticias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fb5a4faa1650d4acb13d26abdc543285881a16c", @"/Views/_ViewImports.cshtml")]
    public class Views_Noticias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- model Noticias \r\n");
#nullable restore
#line 2 "C:\Users\saman\OneDrive\Documentos\Aula37 Eplayers\Views\Noticias\Index.cshtml"
  
    ViewData["Title"] = "Noticias";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form action=\"");
#nullable restore
#line 6 "C:\Users\saman\OneDrive\Documentos\Aula37 Eplayers\Views\Noticias\Index.cshtml"
         Write(Url.Action("Cadastrar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" method=""post"">

<label for=""IdNoticias"">Noticia</label>
<input type=""text"" name=""IdNoticias"" id=""IdNoticias"">

<label for=""Titulo"">Título</label>
<input type=""text"" name=""Titulo"" id=""Titulo"">

<label for=""Texto"">Texto</label>
<input type=""text"" name=""Texto"" id=""Texto"">

<label for=""Imagem"">Imagem</label>
<input type=""text"" name=""Imagem"" id=""Imagem"">



<button type=""submit"">Ver Noticias</button>

</form>

<table class = ""table table-responsive table-striped"">

    <thead>
        <th>Notica</th>
        <th>Titulo</th>
        <th>Texto<th>
        <th>Imagem<th>
    </thead>

    <tbody>
");
#nullable restore
#line 36 "C:\Users\saman\OneDrive\Documentos\Aula37 Eplayers\Views\Noticias\Index.cshtml"
         foreach (var item in ViewBag.Noticias)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr> \r\n                <td>");
#nullable restore
#line 39 "C:\Users\saman\OneDrive\Documentos\Aula37 Eplayers\Views\Noticias\Index.cshtml"
               Write(item.IdNoticias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                <td>");
#nullable restore
#line 40 "C:\Users\saman\OneDrive\Documentos\Aula37 Eplayers\Views\Noticias\Index.cshtml"
               Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                <td>");
#nullable restore
#line 41 "C:\Users\saman\OneDrive\Documentos\Aula37 Eplayers\Views\Noticias\Index.cshtml"
               Write(item.Texto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                <td>");
#nullable restore
#line 42 "C:\Users\saman\OneDrive\Documentos\Aula37 Eplayers\Views\Noticias\Index.cshtml"
               Write(item.Imagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\saman\OneDrive\Documentos\Aula37 Eplayers\Views\Noticias\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
