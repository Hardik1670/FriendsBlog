#pragma checksum "C:\Users\navne\source\repos\MvcIdentityAuthentication\MvcFriendsSite\Views\Components\BlogEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b9763d0b32dbc6d858087ed76c935d98987a6ff"
// <auto-generated/>
#pragma warning disable 1591
namespace MvcFriendsSite.Views.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\navne\source\repos\MvcIdentityAuthentication\MvcFriendsSite\Views\Components\BlogEdit.razor"
using MvcFriendsSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\navne\source\repos\MvcIdentityAuthentication\MvcFriendsSite\Views\Components\BlogEdit.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    public partial class BlogEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BlogEdit</h3>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddAttribute(2, "action", 
#nullable restore
#line 4 "C:\Users\navne\source\repos\MvcIdentityAuthentication\MvcFriendsSite\Views\Components\BlogEdit.razor"
               url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "method", "post");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "hidden");
            __builder.AddAttribute(7, "name", "Id");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 5 "C:\Users\navne\source\repos\MvcIdentityAuthentication\MvcFriendsSite\Views\Components\BlogEdit.razor"
                                           blog.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-group");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, "<label for=\"name\" class=\"control-label\">Name:</label>\r\n        ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "name", "name");
            __builder.AddAttribute(16, "class", "form-control");
            __builder.AddAttribute(17, "value", 
#nullable restore
#line 9 "C:\Users\navne\source\repos\MvcIdentityAuthentication\MvcFriendsSite\Views\Components\BlogEdit.razor"
                                                        blog.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "type", "text");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<label for=\"headline\" class=\"control-label\">Headline:</label>\r\n        ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "name", "headline");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "value", 
#nullable restore
#line 14 "C:\Users\navne\source\repos\MvcIdentityAuthentication\MvcFriendsSite\Views\Components\BlogEdit.razor"
                                                            blog.Headline

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "type", "text");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group");
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddMarkupContent(35, "<label for=\"Content\" class=\"control-label\">Content:</label>\r\n        ");
            __builder.OpenElement(36, "textarea");
            __builder.AddAttribute(37, "name", "Content");
            __builder.AddContent(38, 
#nullable restore
#line 19 "C:\Users\navne\source\repos\MvcIdentityAuthentication\MvcFriendsSite\Views\Components\BlogEdit.razor"
                                  blog.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n\r\n    ");
            __builder.OpenElement(41, "h1");
            __builder.AddContent(42, "Author Name :");
            __builder.OpenElement(43, "span");
            __builder.AddContent(44, 
#nullable restore
#line 26 "C:\Users\navne\source\repos\MvcIdentityAuthentication\MvcFriendsSite\Views\Components\BlogEdit.razor"
                            blog.Author.userName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "hidden");
            __builder.AddAttribute(48, "name", "Author.Id");
            __builder.AddAttribute(49, "value", 
#nullable restore
#line 27 "C:\Users\navne\source\repos\MvcIdentityAuthentication\MvcFriendsSite\Views\Components\BlogEdit.razor"
                                                  blog.Author.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n\r\n    ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "submit");
            __builder.AddAttribute(53, "name", "submit");
            __builder.AddAttribute(54, "value", 
#nullable restore
#line 44 "C:\Users\navne\source\repos\MvcIdentityAuthentication\MvcFriendsSite\Views\Components\BlogEdit.razor"
                                               buttonMode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\navne\source\repos\MvcIdentityAuthentication\MvcFriendsSite\Views\Components\BlogEdit.razor"
       




    private BlogModel _blog = new BlogModel();
    protected string url
    {
        get
        {
            if (_blog.Id < 1)
            {
                return baseUrl.Concat("/Create").ToString().Replace("//", "/");
            }
            else
            {
                return baseUrl.Concat("/Edit/").Concat(_blog.Id.ToString()).ToString().Replace("//", "/");
            }
        }
    }

    private IEnumerable<UserModel> _authors
    {
        get
        {
            return new List<UserModel>();

        }
    }


    protected string buttonMode
    {
        get
        {
            if(_blog.Id < 1)
            {
                return "Create New Post";
            }
            else
            {
                return "Update Post";
            }


        }
    }


    private bool isAuthorAvailable
    {
        get
        {
            if (_blog.Id < 1)
            {
                return false;
            }
            return true;

        }
    }


    [Parameter]
    public BlogModel blog {
        set
        {
            _blog = value;

        }

        get
        {
            return _blog;
        }


    }

    [Parameter]
    public string baseUrl { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591