#pragma checksum "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2eab6bcfab5ec83b742a3fadff904c2d64d56bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Get), @"mvc.1.0.view", @"/Views/Customer/Get.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Get.cshtml", typeof(AspNetCore.Views_Customer_Get))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2eab6bcfab5ec83b742a3fadff904c2d64d56bb", @"/Views/Customer/Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b9ee4c373c6b6613f7e0f910e59a45c10b4928", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\Get.cshtml"
  
    ViewData["Title"] = "Get";

#line default
#line hidden
            BeginContext(60, 66, true);
            WriteLiteral("\r\n<h2>Get</h2>\r\n<h3>This is the Customer Get Action View.</h3>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\Get.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(150, 8, true);
            WriteLiteral("    <p>[");
            EndContext();
            BeginContext(159, 16, false);
#line 12 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\Get.cshtml"
   Write(Model.CustomerID);

#line default
#line hidden
            EndContext();
            BeginContext(175, 4, true);
            WriteLiteral("] - ");
            EndContext();
            BeginContext(180, 15, false);
#line 12 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\Get.cshtml"
                        Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(195, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(197, 14, false);
#line 12 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\Get.cshtml"
                                         Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(211, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\Get.cshtml"
}

#line default
#line hidden
            BeginContext(220, 10, true);
            WriteLiteral("\r\n<strong>");
            EndContext();
            BeginContext(231, 19, false);
#line 15 "C:\Users\epagl\Documents\Revature Projects\EFDemo2\June2019Week3\Demo01WebApp\Demo01WebApp\Views\Customer\Get.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(250, 13, true);
            WriteLiteral("</strong>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
