#pragma checksum "C:\Users\Slavek Power\Desktop\C#Proj\BlackBealt\Views\Home\UserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ac3e18e5e36a4b0d7f390e384f713d145a449a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserInfo), @"mvc.1.0.view", @"/Views/Home/UserInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserInfo.cshtml", typeof(AspNetCore.Views_Home_UserInfo))]
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
#line 1 "C:\Users\Slavek Power\Desktop\C#Proj\BlackBealt\Views\_ViewImports.cshtml"
using BlackBealt;

#line default
#line hidden
#line 2 "C:\Users\Slavek Power\Desktop\C#Proj\BlackBealt\Views\_ViewImports.cshtml"
using BlackBealt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac3e18e5e36a4b0d7f390e384f713d145a449a0", @"/Views/Home/UserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c9fa847f6bc95002c2fd00152575fb520749a61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Slavek Power\Desktop\C#Proj\BlackBealt\Views\Home\UserInfo.cshtml"
  
    ViewData["Title"] = "My Final Project";

#line default
#line hidden
            BeginContext(49, 192, true);
            WriteLiteral("<a style=\"float: right;\" class=\"btn btn-light\" href=\"/bright_ideas\">Home</a>   <a style=\"float: right;\" class=\"btn btn-light\" href=\"/logout\">Logout</a>\n<ul>\n  <li class=\"btn btn-light\" >Name: ");
            EndContext();
            BeginContext(242, 29, false);
#line 6 "C:\Users\Slavek Power\Desktop\C#Proj\BlackBealt\Views\Home\UserInfo.cshtml"
                              Write(ViewBag.SelectedUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(271, 42, true);
            WriteLiteral("</li>\n  <li class=\"btn btn-light\" >Alias: ");
            EndContext();
            BeginContext(314, 30, false);
#line 7 "C:\Users\Slavek Power\Desktop\C#Proj\BlackBealt\Views\Home\UserInfo.cshtml"
                               Write(ViewBag.SelectedUser.UserAlias);

#line default
#line hidden
            EndContext();
            BeginContext(344, 42, true);
            WriteLiteral("</li>\n  <li class=\"btn btn-light\" >Email: ");
            EndContext();
            BeginContext(387, 26, false);
#line 8 "C:\Users\Slavek Power\Desktop\C#Proj\BlackBealt\Views\Home\UserInfo.cshtml"
                               Write(ViewBag.SelectedUser.Email);

#line default
#line hidden
            EndContext();
            BeginContext(413, 78, true);
            WriteLiteral("</li>\n</ul>\n<hr>\n<h1><p>Total number of Ideas:<span class=\"badge badge-light\">");
            EndContext();
            BeginContext(492, 37, false);
#line 11 "C:\Users\Slavek Power\Desktop\C#Proj\BlackBealt\Views\Home\UserInfo.cshtml"
                                                        Write(ViewBag.SelectedUser.UsersIdeas.Count);

#line default
#line hidden
            EndContext();
            BeginContext(529, 75, true);
            WriteLiteral("</span> </p></h1>\n<h1><p>People Who Liked :<span class=\"badge badge-light\">");
            EndContext();
            BeginContext(605, 36, false);
#line 12 "C:\Users\Slavek Power\Desktop\C#Proj\BlackBealt\Views\Home\UserInfo.cshtml"
                                                    Write(ViewBag.SelectedUser.UserLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(641, 17, true);
            WriteLiteral("</span> </p></h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
