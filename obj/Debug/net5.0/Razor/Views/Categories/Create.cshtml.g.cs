#pragma checksum "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Categories\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac4f56ed6f8692e5f5a31697df77c2d29fe68cfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Create), @"mvc.1.0.view", @"/Views/Categories/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac4f56ed6f8692e5f5a31697df77c2d29fe68cfc", @"/Views/Categories/Create.cshtml")]
    public class Views_Categories_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Categories\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h4>Add a new task</h4>\n");
#nullable restore
#line 8 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Categories\Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Categories\Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Categories\Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add new category\" />\n");
#nullable restore
#line 13 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Categories\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 14 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Categories\Create.cshtml"
Write(Html.ActionLink("Show all categories", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 15 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Categories\Create.cshtml"
Write(Html.ActionLink("Back to Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
