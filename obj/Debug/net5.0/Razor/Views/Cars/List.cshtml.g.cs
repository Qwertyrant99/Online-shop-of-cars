#pragma checksum "D:\Studia\PWIA\ProjektNr2_Kirichenko_50412\SklepInternetowy\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e6321d968de1062dd64c865208ec24e766ae430"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
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
#line 1 "D:\Studia\PWIA\ProjektNr2_Kirichenko_50412\SklepInternetowy\Views\_ViewImports.cshtml"
using SklepInternetowy.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Studia\PWIA\ProjektNr2_Kirichenko_50412\SklepInternetowy\Views\_ViewImports.cshtml"
using SklepInternetowy.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e6321d968de1062dd64c865208ec24e766ae430", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daaa98b167cf43e9cdf81ced911ea733d0c06e4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Wszystkie samochody</h1>\r\n<h3>");
#nullable restore
#line 2 "D:\Studia\PWIA\ProjektNr2_Kirichenko_50412\SklepInternetowy\Views\Cars\List.cshtml"
Write(Model.currCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 4 "D:\Studia\PWIA\ProjektNr2_Kirichenko_50412\SklepInternetowy\Views\Cars\List.cshtml"
      
        foreach (Car car in Model.allCars)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Studia\PWIA\ProjektNr2_Kirichenko_50412\SklepInternetowy\Views\Cars\List.cshtml"
       Write(Html.Partial("AllCars", car));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Studia\PWIA\ProjektNr2_Kirichenko_50412\SklepInternetowy\Views\Cars\List.cshtml"
                                         
        }

    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n     \r\n\r\n");
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