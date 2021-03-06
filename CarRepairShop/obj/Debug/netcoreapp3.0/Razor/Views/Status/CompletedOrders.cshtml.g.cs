#pragma checksum "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07fa3a742b912a606e4d727719bb33f88ce2d499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Status_CompletedOrders), @"mvc.1.0.view", @"/Views/Status/CompletedOrders.cshtml")]
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
#line 1 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\_ViewImports.cshtml"
using CarRepairShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\_ViewImports.cshtml"
using CarRepairShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\_ViewImports.cshtml"
using CarRepairShop.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07fa3a742b912a606e4d727719bb33f88ce2d499", @"/Views/Status/CompletedOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91e077a85471e08300bbedab3452c4bb1408a8bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Status_CompletedOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CustomerService>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
  
    ViewData["Title"] = "CompletedOrders";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card border-primary mb-3"">
    <div class=""card-header"">Completed Orders</div>
    <div class=""card-body"">
        <div class=""card-text"">

            <table class=""table table-hover table-bordered table-striped table-responsive-md"">
                <thead>
                    <tr class=""table-danger"">
                        <th scope=""col"">First Name</th>
                        <th scope=""col"">Last Name</th>
                        <th scope=""col"">Email</th>
                        <th scope=""col"">Phone</th>
                        <th scope=""col"">Make</th>
                        <th scope=""col"">Model</th>
                        <th scope=""col"">Year</th>
                        <th scope=""col"">Total Cost</th>
                        <th scope=""col"">Total Paid</th>
                        <th scope=""col"">Balance</th>
                        <th scope=""col"">Status</th>
                    
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 29 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
                     foreach (var customerService in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 32 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
                           Write(customerService.Customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
                           Write(customerService.Customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
                           Write(customerService.Customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
                           Write(customerService.Customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
                           Write(customerService.Customer.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
                           Write(customerService.Customer.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
                           Write(customerService.Customer.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
                           Write(customerService.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
                           Write(customerService.TotalPaid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
                            Write(Math.Round(customerService.TotalCost, 2,MidpointRounding.AwayFromZero) - Math.Round(customerService.TotalPaid, 2,MidpointRounding.AwayFromZero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
                           Write(customerService.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              \r\n                        </tr>\r\n");
#nullable restore
#line 45 "C:\BootCamp2020\CarRepairShop\CarRepairShop\Views\Status\CompletedOrders.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CustomerService>> Html { get; private set; }
    }
}
#pragma warning restore 1591
