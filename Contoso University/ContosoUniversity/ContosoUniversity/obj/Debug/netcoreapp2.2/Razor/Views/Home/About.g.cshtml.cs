#pragma checksum "Z:\Visual Studio 2019 Projects\.NET-CIT365\Contoso University\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65c66ab65807efdc9546c3781400dad9a71790e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "Z:\Visual Studio 2019 Projects\.NET-CIT365\Contoso University\ContosoUniversity\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#line 2 "Z:\Visual Studio 2019 Projects\.NET-CIT365\Contoso University\ContosoUniversity\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65c66ab65807efdc9546c3781400dad9a71790e0", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8c63dad9db0b17e31c66667dec1a52add46bdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContosoUniversity.Models.SchoolViewModels.EnrollmentDateGroup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "Z:\Visual Studio 2019 Projects\.NET-CIT365\Contoso University\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Student Body Statistics";

#line default
#line hidden
            BeginContext(144, 194, true);
            WriteLiteral("\r\n<h2>Student Body Statistics</h2>\r\n\r\n<table class=\"table2\">\r\n    <tr>\r\n        <th>\r\n            Enrollment Date\r\n        </th>\r\n        <th>\r\n            Students\r\n        </th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 19 "Z:\Visual Studio 2019 Projects\.NET-CIT365\Contoso University\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(379, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(428, 49, false);
#line 23 "Z:\Visual Studio 2019 Projects\.NET-CIT365\Contoso University\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(477, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(533, 17, false);
#line 26 "Z:\Visual Studio 2019 Projects\.NET-CIT365\Contoso University\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
           Write(item.StudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(550, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 29 "Z:\Visual Studio 2019 Projects\.NET-CIT365\Contoso University\ContosoUniversity\ContosoUniversity\Views\Home\About.cshtml"
    }

#line default
#line hidden
            BeginContext(593, 75, true);
            WriteLiteral("</table>\r\n\r\n<p>Name: Jeremy Alkire</p>\r\n<p>Contact: alkireson@gmail.com</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContosoUniversity.Models.SchoolViewModels.EnrollmentDateGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
