#pragma checksum "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\Shared\Components\RezomeComponent\Rezome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aea888598711daeb893aa05f62f86edf84c728a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RezomeComponent_Rezome), @"mvc.1.0.view", @"/Views/Shared/Components/RezomeComponent/Rezome.cshtml")]
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
#line 1 "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\_ViewImports.cshtml"
using ShetaPersonal.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\_ViewImports.cshtml"
using ShetaPersonal.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\Shared\Components\RezomeComponent\Rezome.cshtml"
using ShetaPersonal.Core.Serevices.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\Shared\Components\RezomeComponent\Rezome.cshtml"
using ShetaPersonal.Data.Model.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aea888598711daeb893aa05f62f86edf84c728a", @"/Views/Shared/Components/RezomeComponent/Rezome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83aefe6ac8de5dae828725c09f02a8210262cc0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RezomeComponent_Rezome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShetaPersonal.Core.DTO.RezomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"">
    <!-- Blog Section -->
    <div class=""blog-section row"">
        <!-- Section Title -->
        <div class=""section-title text-center col-xs-12"">
            <h2><span>نمونه کار</span></h2>
        </div>
        <!-- Blog Wrapper -->
        <div class=""blog-wrapper clear-fix "">

");
#nullable restore
#line 15 "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\Shared\Components\RezomeComponent\Rezome.cshtml"
             foreach (var rezome in Model.Rezomes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-sm-6 col-xs-12 mb-30 float-right\">\r\n                    <div class=\"blog-post\">\r\n                        <div class=\"post-image\"><img");
            BeginWriteAttribute("src", " src=\"", 724, "\"", 759, 2);
            WriteAttributeValue("", 730, "/Site/img/", 730, 10, true);
#nullable restore
#line 19 "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\Shared\Components\RezomeComponent\Rezome.cshtml"
WriteAttributeValue("", 740, rezome.RezomeImage, 740, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 760, "\"", 766, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"content fix\">\r\n                            <h2 class=\"post-title\"><a href=\"blog-details.html\">");
#nullable restore
#line 21 "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\Shared\Components\RezomeComponent\Rezome.cshtml"
                                                                          Write(rezome.RezomeTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                            <ul class=\"post-info float-right\">\r\n                                <li><h5>استفاده از:</h5></li>\r\n                            </ul>\r\n                            <ul class=\"post-info \">\r\n");
#nullable restore
#line 26 "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\Shared\Components\RezomeComponent\Rezome.cshtml"
                                 foreach (var tecn in Model.RezomeTecses.Where(t => t.RezomeId == rezome.RezomeId))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"float-right\"><a href=\"#\">");
#nullable restore
#line 28 "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\Shared\Components\RezomeComponent\Rezome.cshtml"
                                                                   Write(tecn.TecTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 29 "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\Shared\Components\RezomeComponent\Rezome.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                            <br />\r\n                        </div>\r\n                        <div class=\"clear-fix\"></div>\r\n");
            WriteLiteral("                        <h5 style=\"text-align: center;\">");
#nullable restore
#line 35 "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\Shared\Components\RezomeComponent\Rezome.cshtml"
                                                   Write(_Service.getVaziyatByvaziyatId(rezome.VaziyatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1785, "\"", 1820, 2);
            WriteAttributeValue("", 1792, "/ShowRezome/", 1792, 12, true);
#nullable restore
#line 37 "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\Shared\Components\RezomeComponent\Rezome.cshtml"
WriteAttributeValue("", 1804, rezome.RezomeId, 1804, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\" btn btn-success btn-block read-more\">جزئیات</a>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 41 "E:\P\ProjectOne\ShetaPersonal\ShetaPersonal.Web\Views\Shared\Components\RezomeComponent\Rezome.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IService _Service { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IService Service { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShetaPersonal.Core.DTO.RezomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
