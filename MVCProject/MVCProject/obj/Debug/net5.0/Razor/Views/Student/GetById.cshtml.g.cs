#pragma checksum "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9199074e83f7572ce2b436ad664fce05c318ca6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_GetById), @"mvc.1.0.view", @"/Views/Student/GetById.cshtml")]
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
#line 1 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9199074e83f7572ce2b436ad664fce05c318ca6d", @"/Views/Student/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"def5f48ba7d1e2063d3a843314af9bddc97c4dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 1 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetById.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 42, "\"", 59, 1);
#nullable restore
#line 2 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetById.cshtml"
WriteAttributeValue("", 50, Model.Id, 50, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<h3>");
#nullable restore
#line 3 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetById.cshtml"
Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
#nullable restore
#line 4 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetById.cshtml"
Write(Model.Track_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
#nullable restore
#line 5 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetById.cshtml"
Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
#nullable restore
#line 6 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetById.cshtml"
Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n \r\n\r\n");
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
