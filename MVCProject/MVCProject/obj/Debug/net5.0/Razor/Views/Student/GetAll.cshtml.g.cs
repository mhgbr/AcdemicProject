#pragma checksum "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddb35c7f092dc3c150607ad0ca82179f87a0df93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_GetAll), @"mvc.1.0.view", @"/Views/Student/GetAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddb35c7f092dc3c150607ad0ca82179f87a0df93", @"/Views/Student/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"def5f48ba7d1e2063d3a843314af9bddc97c4dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--Strong Type View-->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddb35c7f092dc3c150607ad0ca82179f87a0df934493", async() => {
                WriteLiteral("Add new Student");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table class=""table table-dark table-striped text-center"" width=""50%"">
    <tr>
        <th>
            Name
        </th>
        <th>
            Age
        </th>
        <th>
            Address
        </th>
        <th>
            Track
        </th>
        <th>
            Details
        </th>
        <th>
            Edit
        </th>
    </tr>
");
#nullable restore
#line 26 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetAll.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetAll.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetAll.cshtml"
           Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetAll.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 32 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetAll.cshtml"
             foreach(var i in ViewBag.Trs)
            {
                if(i.Id == item.Track_Id)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 36 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetAll.cshtml"
                   Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetAll.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td> <a");
            BeginWriteAttribute("href", " href=\"", 896, "\"", 928, 2);
            WriteAttributeValue("", 903, "/Student/GetById/", 903, 17, true);
#nullable restore
#line 39 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetAll.cshtml"
WriteAttributeValue("", 920, item.Id, 920, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Details</a></td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 990, "\"", 1021, 2);
            WriteAttributeValue("", 997, "/Student/Update/", 997, 16, true);
#nullable restore
#line 40 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetAll.cshtml"
WriteAttributeValue("", 1013, item.Id, 1013, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Alli\Desktop\AcdemicProject\MVCProject\MVCProject\Views\Student\GetAll.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
