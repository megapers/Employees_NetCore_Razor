#pragma checksum "C:\Users\megap\Desktop\Everything\Job Search\PrevueHR\RazorPagesApp\RazorPagesApp\Pages\Shared\Components\HeadCount\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9101e79a7ee9ec9c983d5a6743af9fc113d8c935"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesApp.Pages.Shared.Components.HeadCount.Pages_Shared_Components_HeadCount_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/HeadCount/Default.cshtml")]
namespace RazorPagesApp.Pages.Shared.Components.HeadCount
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
#line 1 "C:\Users\megap\Desktop\Everything\Job Search\PrevueHR\RazorPagesApp\RazorPagesApp\Pages\_ViewImports.cshtml"
using RazorPagesApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\megap\Desktop\Everything\Job Search\PrevueHR\RazorPagesApp\RazorPagesApp\Pages\_ViewImports.cshtml"
using RazorPagesTutorial.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9101e79a7ee9ec9c983d5a6743af9fc113d8c935", @"/Pages/Shared/Components/HeadCount/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a3ef93365889758803577b8f042176705ccf0da", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_HeadCount_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DptHeadCount>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Employee Head Count Summary</h3>\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead class=\"thead-light\">\r\n        <tr>\r\n            <th>Department</th>\r\n            <th>Head Count</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\megap\Desktop\Everything\Job Search\PrevueHR\RazorPagesApp\RazorPagesApp\Pages\Shared\Components\HeadCount\Default.cshtml"
         foreach(var deptHeadCount in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\megap\Desktop\Everything\Job Search\PrevueHR\RazorPagesApp\RazorPagesApp\Pages\Shared\Components\HeadCount\Default.cshtml"
               Write(deptHeadCount.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\megap\Desktop\Everything\Job Search\PrevueHR\RazorPagesApp\RazorPagesApp\Pages\Shared\Components\HeadCount\Default.cshtml"
               Write(deptHeadCount.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 19 "C:\Users\megap\Desktop\Everything\Job Search\PrevueHR\RazorPagesApp\RazorPagesApp\Pages\Shared\Components\HeadCount\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DptHeadCount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
