#pragma checksum "C:\Users\Dad S. Wonkulah Jr\source\repos\ExampleEmptySol\ExampleEmpty.UI\Views\Account\AddPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82e7b812f91e59f754980100e2c090f302490446"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AddPasswordConfirmation), @"mvc.1.0.view", @"/Views/Account/AddPasswordConfirmation.cshtml")]
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
#line 1 "C:\Users\Dad S. Wonkulah Jr\source\repos\ExampleEmptySol\ExampleEmpty.UI\Views\_ViewImports.cshtml"
using ExampleEmpty.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dad S. Wonkulah Jr\source\repos\ExampleEmptySol\ExampleEmpty.UI\Views\_ViewImports.cshtml"
using ExampleEmpty.UI.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dad S. Wonkulah Jr\source\repos\ExampleEmptySol\ExampleEmpty.UI\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dad S. Wonkulah Jr\source\repos\ExampleEmptySol\ExampleEmpty.UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dad S. Wonkulah Jr\source\repos\ExampleEmptySol\ExampleEmpty.UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82e7b812f91e59f754980100e2c090f302490446", @"/Views/Account/AddPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30da0b89ce35c5db3833c43b67d342a91fcf4939", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AddPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dad S. Wonkulah Jr\source\repos\ExampleEmptySol\ExampleEmpty.UI\Views\Account\AddPasswordConfirmation.cshtml"
   
    ViewData["Title"] = "Add password confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""border backgroundWhite container shadow"" style=""margin-top:30px;"">
    <h2 class=""text-success""><i class=""fas fa-key""></i>&nbsp;Change Password</h2>
    <hr />
    <div class=""alert alert-info"">
        <p>
            You have successfully set a local password.
            You can now use either your local user account 
            or external account to login!
        </p>
    </div>
</div>");
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