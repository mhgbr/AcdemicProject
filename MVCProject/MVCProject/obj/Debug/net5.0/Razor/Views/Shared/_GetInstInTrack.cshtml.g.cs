#pragma checksum "C:\Users\Dell\AcdemicProject\MVCProject\MVCProject\Views\Shared\_GetInstInTrack.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dab096bf8eeadca0743206679de6588d1502a8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GetInstInTrack), @"mvc.1.0.view", @"/Views/Shared/_GetInstInTrack.cshtml")]
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
#line 1 "C:\Users\Dell\AcdemicProject\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\AcdemicProject\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dell\AcdemicProject\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dell\AcdemicProject\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dab096bf8eeadca0743206679de6588d1502a8e", @"/Views/Shared/_GetInstInTrack.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"def5f48ba7d1e2063d3a843314af9bddc97c4dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GetInstInTrack : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Instructor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-dark table-striped text-center\" width=\"50%\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Age</th>\r\n        <th>Address</th>\r\n        <th>Salary</th>\r\n        <th>PhoneNumber</th>\r\n        <th>TrackId</th>\r\n    </tr>\r\n");
#nullable restore
#line 12 "C:\Users\Dell\AcdemicProject\MVCProject\MVCProject\Views\Shared\_GetInstInTrack.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\Dell\AcdemicProject\MVCProject\MVCProject\Views\Shared\_GetInstInTrack.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\Dell\AcdemicProject\MVCProject\MVCProject\Views\Shared\_GetInstInTrack.cshtml"
           Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\Dell\AcdemicProject\MVCProject\MVCProject\Views\Shared\_GetInstInTrack.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\Dell\AcdemicProject\MVCProject\MVCProject\Views\Shared\_GetInstInTrack.cshtml"
           Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Dell\AcdemicProject\MVCProject\MVCProject\Views\Shared\_GetInstInTrack.cshtml"
           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Dell\AcdemicProject\MVCProject\MVCProject\Views\Shared\_GetInstInTrack.cshtml"
           Write(item.Track_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Dell\AcdemicProject\MVCProject\MVCProject\Views\Shared\_GetInstInTrack.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Instructor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
