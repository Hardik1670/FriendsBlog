#pragma checksum "C:\Users\navne\source\repos\MVCFriendsSiteHardik\MvcFriendsSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08c01ffb77560345f53eeef9b1733fcf25839147"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\navne\source\repos\MVCFriendsSiteHardik\MvcFriendsSite\Views\_ViewImports.cshtml"
using MvcFriendsSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\navne\source\repos\MVCFriendsSiteHardik\MvcFriendsSite\Views\_ViewImports.cshtml"
using MvcFriendsSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\navne\source\repos\MVCFriendsSiteHardik\MvcFriendsSite\Views\Home\Index.cshtml"
using MvcFriendsSite.Views.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c01ffb77560345f53eeef9b1733fcf25839147", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70fd8139143b69b26e014234da80b4183942d5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\navne\source\repos\MVCFriendsSiteHardik\MvcFriendsSite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

    IList<BlogModel> blogs = new List<BlogModel>();
    UserModel user = new UserModel
    {



    };

    blogs.Add(new BlogModel
    {
        Author = new UserModel { userName = "David", email = "david@gmail.com" },
        Name = "Culture",
        Headline = "Christmas Around",
        Content = "Jingle Bell Jingle Bell",


    });
    blogs.Add(new BlogModel
    {
        Author = new UserModel
        {
            userName = "Andrew",
            email = "andrew@gmail.com"

        },


        Name = "Movies",
        Headline = "Pirates Of Carribean",
        Content = "To Be Released Soon"
    });






#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
#nullable restore
#line 49 "C:\Users\navne\source\repos\MVCFriendsSiteHardik\MvcFriendsSite\Views\Home\Index.cshtml"
Write(await Html.RenderComponentAsync<BlogList>(RenderMode.ServerPrerendered, new BlogList { ModelList = blogs }));

#line default
#line hidden
#nullable disable
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
