#pragma checksum "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\DisplayOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a53dd737d1f27712f326ac8ed2c1bb3a4a3d50ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_DisplayOrder), @"mvc.1.0.view", @"/Views/Customer/DisplayOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/DisplayOrder.cshtml", typeof(AspNetCore.Views_Customer_DisplayOrder))]
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
#line 1 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\_ViewImports.cshtml"
using Demo01WebApp;

#line default
#line hidden
#line 2 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\_ViewImports.cshtml"
using Demo01WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a53dd737d1f27712f326ac8ed2c1bb3a4a3d50ff", @"/Views/Customer/DisplayOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b9ee4c373c6b6613f7e0f910e59a45c10b4928", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_DisplayOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo01WebApp.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\DisplayOrder.cshtml"
  
    ViewData["Title"] = "DisplayOrder";

#line default
#line hidden
            BeginContext(84, 100, true);
            WriteLiteral("\r\n<h2>DisplayOrder</h2>\r\n\r\n\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n");
            EndContext();
#line 14 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\DisplayOrder.cshtml"
         if ((bool)ViewData["DisplayId"] == true)
        {

#line default
#line hidden
            BeginContext(246, 34, true);
            WriteLiteral("            <dt>\r\n                ");
            EndContext();
            BeginContext(281, 38, false);
#line 17 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\DisplayOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(319, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(375, 34, false);
#line 20 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\DisplayOrder.cshtml"
           Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(409, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 22 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\DisplayOrder.cshtml"
        }

#line default
#line hidden
            BeginContext(441, 26, true);
            WriteLiteral("        <dt>\r\n            ");
            EndContext();
            BeginContext(468, 45, false);
#line 24 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\DisplayOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(513, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(557, 41, false);
#line 27 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\DisplayOrder.cshtml"
       Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(598, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(642, 46, false);
#line 30 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\DisplayOrder.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(688, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(732, 42, false);
#line 33 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\DisplayOrder.cshtml"
       Write(Html.DisplayFor(model => model.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(774, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(822, 68, false);
#line 38 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\DisplayOrder.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(890, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(898, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da80328a457943bbabbd14a0f4e5f109", async() => {
                BeginContext(920, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(936, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo01WebApp.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591