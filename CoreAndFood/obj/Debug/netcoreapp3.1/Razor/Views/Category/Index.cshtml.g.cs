#pragma checksum "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4683ebb7b9ae84e1b584fc3658da597c2368d599"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\_ViewImports.cshtml"
using CoreAndFood;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\_ViewImports.cshtml"
using CoreAndFood.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4683ebb7b9ae84e1b584fc3658da597c2368d599", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eca523975dc9d6067030284f78c87d6956189e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreAndFood.Models.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Category List</h2>\r\n<br />\r\n");
#nullable restore
#line 7 "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
 using(Html.BeginForm()){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Food Name:");
#nullable restore
#line 8 "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
            Write(Html.TextBox("p"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <input type=\"submit\" value=\"Find\"/>\r\n    </p>\r\n");
#nullable restore
#line 11 "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Category Name</th>\r\n        <th>Status</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
     foreach (var x in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(x.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(x.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(x.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 603, "\"", 648, 2);
            WriteAttributeValue("", 610, "/Category/CategoryDelete/", 610, 25, true);
#nullable restore
#line 25 "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 635, x.CategoryID, 635, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 708, "\"", 750, 2);
            WriteAttributeValue("", 715, "/Category/CategoryGet/", 715, 22, true);
#nullable restore
#line 26 "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 737, x.CategoryID, 737, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\lokum\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Category/CategoryAdd/\" class=\"btn btn-primary\">New Category</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreAndFood.Models.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
