#pragma checksum "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c7a8676027c1666b4b2bbfc1c3f596e33f8f4e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applicant_Index), @"mvc.1.0.view", @"/Views/Applicant/Index.cshtml")]
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
#line 1 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\_ViewImports.cshtml"
using HR_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\_ViewImports.cshtml"
using HR_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c7a8676027c1666b4b2bbfc1c3f596e33f8f4e3", @"/Views/Applicant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"390e6b011c80c8aacfb8cb7c82a5633b478e25dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Applicant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Import", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Applicant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c7a8676027c1666b4b2bbfc1c3f596e33f8f4e35932", async() => {
                WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<style>
* {box-sizing: border-box}

/* Set height of body and the document to 100% */
body, html {
  height: 100%;
  margin: 0;
  font-family: Arial;
}

/* Style tab links */
.tablink {
  background-color: #555;
  color: white;
  float: left;
  border: none;
  outline: none;
  cursor: pointer;
  padding: 14px 16px;
  font-size: 17px;
  width: 33.33%;
}

.tablink:hover {
  background-color: #777;
}

/* Style the tab content (and add height:100% for full page content) */
.tabcontent {
  color: white;
  display: none;
  padding: 100px 20px;
  height: 100%;
}

#News {background-color: green;}
#Contact {background-color: teal;}
#About {background-color: orange;}
</style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c7a8676027c1666b4b2bbfc1c3f596e33f8f4e37685", async() => {
                WriteLiteral("\r\n<a href=\"/Applicant/Data\" class=\"btn btn-success\">Add New Applicant</a>\r\n<a class=\"btn btn-success\" href=\"/Applicant/Export\">Export CSV(All)</a>\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c7a8676027c1666b4b2bbfc1c3f596e33f8f4e38101", async() => {
                    WriteLiteral("\r\n    <input  type=\"file\" id=\"Upload\" name=\"Upload\" value=\"Upload\">\r\n    <button type=\"submit\" class=\"btn btn-success\">Import</button>\r\n");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c7a8676027c1666b4b2bbfc1c3f596e33f8f4e310053", async() => {
                    WriteLiteral("\r\n  <input type=\"text\" name=\"search\" id=\"search\" placeholder=\"Type What You Searching For\">\r\n  ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c7a8676027c1666b4b2bbfc1c3f596e33f8f4e310423", async() => {
                        WriteLiteral("Search");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n  ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c7a8676027c1666b4b2bbfc1c3f596e33f8f4e312047", async() => {
                        WriteLiteral("CSV");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
<br>

<button class=""tablink"" onclick=""openPage('News', this, 'green')"" id=""defaultOpen"">Unproccessed</button>
<button class=""tablink"" onclick=""openPage('Contact', this, 'teal')"">Psycho Test</button>
<button class=""tablink"" onclick=""openPage('About', this, 'orange')"">Interview</button>

<div id=""News"" class=""tabcontent"">
    <ul>
");
#nullable restore
#line 65 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
      
        var x = ViewBag.app;
        foreach (var i in x)
        {
            if( i.status == "unprocessed")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\r\n                ");
#nullable restore
#line 72 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
           Write(i.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 73 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
           Write(i.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 74 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
           Write(i.phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <a");
                BeginWriteAttribute("href", " href=\'", 2119, "\'", 2154, 2);
                WriteAttributeValue("", 2126, "/Applicant/Information/", 2126, 23, true);
#nullable restore
#line 75 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
WriteAttributeValue("", 2149, i.id, 2149, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\">Info</a>\r\n                </li>\r\n");
#nullable restore
#line 77 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n</div>\r\n\r\n<div id=\"Contact\" class=\"tabcontent\">\r\n  <ul>\r\n");
#nullable restore
#line 85 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
      
        var y = ViewBag.app;
        foreach (var i in y)
        {
            if( i.status == "psychotest")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\r\n                ");
#nullable restore
#line 92 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
           Write(i.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 93 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
           Write(i.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 94 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
           Write(i.phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <a class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href=\'", 2592, "\'", 2627, 2);
                WriteAttributeValue("", 2599, "/Applicant/Information/", 2599, 23, true);
#nullable restore
#line 95 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
WriteAttributeValue("", 2622, i.id, 2622, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Info</a>\r\n                </li>\r\n");
#nullable restore
#line 97 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n</div>\r\n\r\n<div id=\"About\" class=\"tabcontent\">\r\n  <ul>\r\n");
#nullable restore
#line 105 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
      
        var z = ViewBag.app;
        foreach (var i in z)
        {
            if( i.status == "interview")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\r\n                ");
#nullable restore
#line 112 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
           Write(i.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 113 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
           Write(i.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 114 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
           Write(i.phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <a class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href =\'", 3038, "\'", 3074, 2);
                WriteAttributeValue("", 3046, "/Applicant/Information/", 3046, 23, true);
#nullable restore
#line 115 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
WriteAttributeValue("", 3069, i.id, 3069, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Info</a>\r\n                </li>\r\n");
#nullable restore
#line 117 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n</div>\r\n\r\n<div class=\"container\">\r\n<div class=\"column\">\r\n<div class=\"col-lg-12 col-sm-5\">\r\n<nav aria-label=\"...\">\r\n  <ul class=\"pagination marginleft\">\r\n");
#nullable restore
#line 128 "D:\Users\bsi50130\Downloads\FinalProject-1.1.0\FinalProject-1.0.0\Views\Applicant\Index.cshtml"
      
      var paging = ViewBag.page;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <li class=""page-item"">
      <a class=""page-link"" href=""/Home/Paging?prev=1"">Previous</a>
    </li>
    <li class=""page-item""><a class=""page-link"" value=""1"" id=""btn1"" href=""/Applicant/Index?_crntpage=1"">1</a></li>
    <li class=""page-item""><a class=""page-link"" value=""2"" id=""btn2"" href=""/Applicant/Index?_crntpage=2"">2</a></li>
    <li class=""page-item""><a class=""page-link"" value=""3"" id=""btn3"" href=""/Applicant/Index?_crntpage=3"">3</a></li>
    <li class=""page-item""><a class=""page-link"" value=""4"" id=""btn4"" href=""/Applicant/Index?_crntpage=4"">4</a></li>
    <li class=""page-item""><a class=""page-link"" value=""5"" id=""btn5"" href=""/Applicant/Index?_crntpage=5"">5</a></li>
    <li class=""page-item""><a class=""page-link"" value=""6"" id=""btn6"" href=""/Applicant/Index?_crntpage=6"">6</a></li>
    <li class=""page-item"">
      <a class=""page-link"" href=""/Home/Paging?next=1"">Next</a>
    </li> ");
                WriteLiteral(@"  </ul>

<script>
function openPage(pageName,elmnt,color) {
  var i, tabcontent, tablinks;
  tabcontent = document.getElementsByClassName(""tabcontent"");
  for (i = 0; i < tabcontent.length; i++) {
    tabcontent[i].style.display = ""none"";
  }
  tablinks = document.getElementsByClassName(""tablink"");
  for (i = 0; i < tablinks.length; i++) {
    tablinks[i].style.backgroundColor = """";
  }
  document.getElementById(pageName).style.display = ""block"";
  elmnt.style.backgroundColor = color;
}

// Get the element with id=""defaultOpen"" and click on it
document.getElementById(""defaultOpen"").click();
</script>
   
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html> ");
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