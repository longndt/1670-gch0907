#pragma checksum "D:\workspace\FGW-1670\1670-gch0907\1670\web2\Views\Demo\PassData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6e12a220d1085f5af90f89876784802d9bacb8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_PassData), @"mvc.1.0.view", @"/Views/Demo/PassData.cshtml")]
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
#line 1 "D:\workspace\FGW-1670\1670-gch0907\1670\web2\Views\_ViewImports.cshtml"
using web2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\workspace\FGW-1670\1670-gch0907\1670\web2\Views\_ViewImports.cshtml"
using web2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6e12a220d1085f5af90f89876784802d9bacb8c", @"/Views/Demo/PassData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f0d3e607999d9f0dbeff71de83083377b731857", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Demo_PassData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Tuổi: ");
#nullable restore
#line 1 "D:\workspace\FGW-1670\1670-gch0907\1670\web2\Views\Demo\PassData.cshtml"
     Write(ViewData["Age"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Giới tính: ");
#nullable restore
#line 2 "D:\workspace\FGW-1670\1670-gch0907\1670\web2\Views\Demo\PassData.cshtml"
          Write(ViewData["Gender"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Điện thoại: ");
#nullable restore
#line 3 "D:\workspace\FGW-1670\1670-gch0907\1670\web2\Views\Demo\PassData.cshtml"
           Write(ViewData["Phone"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Name</th>\r\n    </tr>\r\n");
#nullable restore
#line 9 "D:\workspace\FGW-1670\1670-gch0907\1670\web2\Views\Demo\PassData.cshtml"
     foreach (var student in ViewBag.Students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 12 "D:\workspace\FGW-1670\1670-gch0907\1670\web2\Views\Demo\PassData.cshtml"
           Write(student);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 14 "D:\workspace\FGW-1670\1670-gch0907\1670\web2\Views\Demo\PassData.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
