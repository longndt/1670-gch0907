#pragma checksum "D:\workspace\1670-gch0907\1670\web3\Views\Home\Razor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d804c35eb02e781aa484421440db8d0dda65d0a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Razor), @"mvc.1.0.view", @"/Views/Home/Razor.cshtml")]
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
#line 1 "D:\workspace\1670-gch0907\1670\web3\Views\_ViewImports.cshtml"
using web3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\workspace\1670-gch0907\1670\web3\Views\_ViewImports.cshtml"
using web3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d804c35eb02e781aa484421440db8d0dda65d0a9", @"/Views/Home/Razor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4888d945e93a8d7929c269bbeb65a2e606cabad", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Razor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!--\r\n    comment bằng HTML\r\n-->\r\n\r\n");
#nullable restore
#line 9 "D:\workspace\1670-gch0907\1670\web3\Views\Home\Razor.cshtml"
  
    //comment bằng C# (single line)
    /*
     * comment bằng C#
     * (multiple line)
     */
    var fpt = "FPT Cooperation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>In ra giá trị của biến (dùng 1 a) : ");
#nullable restore
#line 18 "D:\workspace\1670-gch0907\1670\web3\Views\Home\Razor.cshtml"
                                   Write(fpt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n<h2>In ra ký tự a (dùng 2 a) : ");
            WriteLiteral("@fpt </h2>\r\n\r\n");
#nullable restore
#line 21 "D:\workspace\1670-gch0907\1670\web3\Views\Home\Razor.cshtml"
  
    //gõ code của C# ngay trong Razor
    int a = 3;
    int b = 4;
    int c = 2;
    int max = 0;

    //if ... else
    if (a>=b && a>=c) {
        max = a;
    } else if (b>=a && b>=c) {
        max = b;
    } else {
        max = c;
    }
    // switch ... case
    var menu = 1;
    var text = "";
    switch(menu) {
        case 1:
            text = "You have selected menu 1";
            break;
        case 2:
            text = "You have selected menu 2";
            break;
        case 3:
            text = "You have selected menu 3";
            break;
        default:
            text = "Invalid menu";
            break;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Max is ");
#nullable restore
#line 54 "D:\workspace\1670-gch0907\1670\web3\Views\Home\Razor.cshtml"
      Write(max);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n<h4>");
#nullable restore
#line 55 "D:\workspace\1670-gch0907\1670\web3\Views\Home\Razor.cshtml"
Write(text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h5>Yêu cầu: In ra chuỗi số từ 1 đến 10 (dùng for)</h5>\r\n");
#nullable restore
#line 57 "D:\workspace\1670-gch0907\1670\web3\Views\Home\Razor.cshtml"
  
    for(int i=1; i<=10; i++) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h6>");
#nullable restore
#line 59 "D:\workspace\1670-gch0907\1670\web3\Views\Home\Razor.cshtml"
       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6> \r\n");
#nullable restore
#line 60 "D:\workspace\1670-gch0907\1670\web3\Views\Home\Razor.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h5>Yêu cầu: In ra chuỗi số từ 1 đến 10 (dùng while)</h5>\r\n");
#nullable restore
#line 63 "D:\workspace\1670-gch0907\1670\web3\Views\Home\Razor.cshtml"
  
    int j = 1;
    while(j<=10) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h6>");
#nullable restore
#line 66 "D:\workspace\1670-gch0907\1670\web3\Views\Home\Razor.cshtml"
       Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <p hidden>");
#nullable restore
#line 67 "D:\workspace\1670-gch0907\1670\web3\Views\Home\Razor.cshtml"
              Write(j++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 67 "D:\workspace\1670-gch0907\1670\web3\Views\Home\Razor.cshtml"
                            ;
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
