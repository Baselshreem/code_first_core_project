#pragma checksum "C:\Users\basel\source\repos\project1_core\project1_core\Views\Home\news.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "082e145f93efe5461cc776c35ea61b618a162550"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_news), @"mvc.1.0.view", @"/Views/Home/news.cshtml")]
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
#line 1 "C:\Users\basel\source\repos\project1_core\project1_core\Views\_ViewImports.cshtml"
using project1_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\basel\source\repos\project1_core\project1_core\Views\_ViewImports.cshtml"
using project1_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"082e145f93efe5461cc776c35ea61b618a162550", @"/Views/Home/news.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad82bcdc4531196b30e9764ae1a416f95855783a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_news : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<news>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/about.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section id=\"about\" class=\"about\">\n    <div class=\"container aos-init aos-animate\" data-aos=\"fade-up\">\n\n        <div class=\"section-title\">\n            <h2>الاخبار ");
#nullable restore
#line 6 "C:\Users\basel\source\repos\project1_core\project1_core\Views\Home\news.cshtml"
                   Write(ViewBag.cat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\n               </div>\n\n        <div class=\"row\">\n");
#nullable restore
#line 10 "C:\Users\basel\source\repos\project1_core\project1_core\Views\Home\news.cshtml"
             foreach (var item in Model) { 
            
             

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-6 aos-init aos-animate\" data-aos=\"fade-right\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "082e145f93efe5461cc776c35ea61b618a1625504971", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n            <div class=\"col-lg-6 pt-4 pt-lg-0 content aos-init aos-animate\" data-aos=\"fade-left\">\n                <h3>");
#nullable restore
#line 17 "C:\Users\basel\source\repos\project1_core\project1_core\Views\Home\news.cshtml"
               Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h3>\n                <h4>");
#nullable restore
#line 18 "C:\Users\basel\source\repos\project1_core\project1_core\Views\Home\news.cshtml"
               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h4>\n                <p class=\"fst-italic\">\n                    ");
#nullable restore
#line 20 "C:\Users\basel\source\repos\project1_core\project1_core\Views\Home\news.cshtml"
               Write(item.topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n                \n                \n            </div>\n            <a class=\"btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 845, "\"", 876, 2);
            WriteAttributeValue("", 852, "/home/deletnews/", 852, 16, true);
#nullable restore
#line 25 "C:\Users\basel\source\repos\project1_core\project1_core\Views\Home\news.cshtml"
WriteAttributeValue("", 868, item.id, 868, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">delet</a>\n");
#nullable restore
#line 26 "C:\Users\basel\source\repos\project1_core\project1_core\Views\Home\news.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<news>> Html { get; private set; }
    }
}
#pragma warning restore 1591
