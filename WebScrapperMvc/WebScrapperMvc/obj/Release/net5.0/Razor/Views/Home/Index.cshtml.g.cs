#pragma checksum "C:\Users\T-Gamer\source\repos\WebScrapperMVC\WebScrapperMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fa8af288068d8a38e8b6c4bd20a60afb6741e42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\T-Gamer\source\repos\WebScrapperMVC\WebScrapperMVC\Views\_ViewImports.cshtml"
using WebScrapperMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T-Gamer\source\repos\WebScrapperMVC\WebScrapperMVC\Views\_ViewImports.cshtml"
using WebScrapperMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fa8af288068d8a38e8b6c4bd20a60afb6741e42", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8f7c07730d4aaf9badcbc9a1837a89d6ccdbcb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\T-Gamer\source\repos\WebScrapperMVC\WebScrapperMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Web Scrapper</h1>
</div>

<div class="" input-group "" style=""margin-top:100px;"">
    <input type=""text"" class=""form-control"" id=""txtBusca"" placeholder=""Digitar Url..."" aria-describedby=""button-addon"" >
    <div class=""input-group-append"" id=""button-addon"">
        <button class=""btn btn-outline-secondary botao"" id=""BtnBusca""  type=""button""><i class=""fa fa-search""></i></button>
    </div>
</div>

<div style=""margin-top:50px;"" class=""row"" id=""divResultado"" >
    <div class=""col-md-8"" id=""containerImagens"">
        
    </div>
    <div class=""col-md-4"">
        <p>
            <table class=""table table-striped table-hover table-bordered"" id=""tabelaPalavras"">
                <tbody>
                    <tr>
                        
                    </tr>
                    <tr>
                       
                    </tr>
                </tbody>
            </table>
        </p>
    </div>
</div>



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
