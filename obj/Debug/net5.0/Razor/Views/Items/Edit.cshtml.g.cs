#pragma checksum "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Items\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e00434dec0720f97089f5a52703ac5bd10d95e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Edit), @"mvc.1.0.view", @"/Views/Items/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e00434dec0720f97089f5a52703ac5bd10d95e5", @"/Views/Items/Edit.cshtml")]
    public class Views_Items_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Items\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this task: ");
#nullable restore
#line 9 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Items\Edit.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Items\Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Items\Edit.cshtml"
Write(Html.HiddenFor(model => model.ItemId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Items\Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Items\Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Items\Edit.cshtml"
Write(Html.LabelFor(model => model.Category));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Items\Edit.cshtml"
Write(Html.DropDownList("CategoryId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 22 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Items\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 24 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Items\Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 25 "C:\Users\brook\Desktop\database-basics-test-project\ToDoList\Views\Items\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
