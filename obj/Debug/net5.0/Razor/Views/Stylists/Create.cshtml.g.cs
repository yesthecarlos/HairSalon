#pragma checksum "/Users/carlosmendez/Desktop/HairSalon/Views/Stylists/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b0826b96125a22cb69cc0b50093b1104d9bf556"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Create), @"mvc.1.0.view", @"/Views/Stylists/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b0826b96125a22cb69cc0b50093b1104d9bf556", @"/Views/Stylists/Create.cshtml")]
    public class Views_Stylists_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EauClaire.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/carlosmendez/Desktop/HairSalon/Views/Stylists/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h4>Add a new stylist</h4>\n\n");
#nullable restore
#line 9 "/Users/carlosmendez/Desktop/HairSalon/Views/Stylists/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/carlosmendez/Desktop/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.LabelFor(model => model.StylistName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/carlosmendez/Desktop/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.TextBoxFor(model => model.StylistName));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Add new stylist\" />\n");
#nullable restore
#line 14 "/Users/carlosmendez/Desktop/HairSalon/Views/Stylists/Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 15 "/Users/carlosmendez/Desktop/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.ActionLink("Show all stylists", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EauClaire.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
