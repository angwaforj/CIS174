#pragma checksum "E:\ASP.NET Core\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dff22854c1903b220e89880eabc832da0887226"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Student), @"mvc.1.0.view", @"/Views/Student/Student.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Student.cshtml", typeof(AspNetCore.Views_Student_Student))]
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
#line 1 "E:\ASP.NET Core\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp;

#line default
#line hidden
#line 2 "E:\ASP.NET Core\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dff22854c1903b220e89880eabc832da0887226", @"/Views/Student/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b0c89835ffd0a30fcde2417f863d02f1a9e8dc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StudentModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\ASP.NET Core\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
  
    ViewData["Title"] = "Student Details";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(105, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(112, 17, false);
#line 8 "E:\ASP.NET Core\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(129, 17, true);
            WriteLiteral("</h2>\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 14 "E:\ASP.NET Core\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
 foreach (var student in Model)
{
    
    
    
    

#line default
#line hidden
            BeginContext(206, 13, true);
            WriteLiteral("         <li>");
            EndContext();
            BeginContext(220, 17, false);
#line 20 "E:\ASP.NET Core\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
        Write(student.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(237, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(239, 16, false);
#line 20 "E:\ASP.NET Core\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
                           Write(student.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(255, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(257, 14, false);
#line 20 "E:\ASP.NET Core\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
                                             Write(student.Grades);

#line default
#line hidden
            EndContext();
            BeginContext(271, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 21 "E:\ASP.NET Core\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Student\Student.cshtml"
  
}

#line default
#line hidden
            BeginContext(285, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StudentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
