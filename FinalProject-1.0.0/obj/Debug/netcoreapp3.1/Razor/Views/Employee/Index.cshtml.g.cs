#pragma checksum "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bee83057ea3e6b6f71c26ca6678a2a4ba9ebb18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\_ViewImports.cshtml"
using HR_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\_ViewImports.cshtml"
using HR_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bee83057ea3e6b6f71c26ca6678a2a4ba9ebb18", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"390e6b011c80c8aacfb8cb7c82a5633b478e25dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Import", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bee83057ea3e6b6f71c26ca6678a2a4ba9ebb186046", async() => {
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bee83057ea3e6b6f71c26ca6678a2a4ba9ebb187756", async() => {
                WriteLiteral("\n<a href=\"/Employee/Data\" class=\"btn btn-success\">Add New Employee</a>\n<a class=\"btn btn-success\" href=\"/Employee/Export\">Export CSV(All)</a>\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bee83057ea3e6b6f71c26ca6678a2a4ba9ebb188163", async() => {
                    WriteLiteral("\n    <input  type=\"file\" id=\"Upload\" name=\"Upload\" value=\"Upload\">\n    <button type=\"submit\" class=\"btn btn-success\">Import</button>\n");
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
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bee83057ea3e6b6f71c26ca6678a2a4ba9ebb1810107", async() => {
                    WriteLiteral("\n  <input type=\"text\" name=\"search\" id=\"search\" placeholder=\"Type What You Searching For\">\n  ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bee83057ea3e6b6f71c26ca6678a2a4ba9ebb1810473", async() => {
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
                    WriteLiteral("\n  ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bee83057ea3e6b6f71c26ca6678a2a4ba9ebb1812095", async() => {
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
                    WriteLiteral("\n");
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

<button class=""tablink"" onclick=""openPage('News', this, 'green')"" id=""defaultOpen"">Permanent</button>
<button class=""tablink"" onclick=""openPage('Contact', this, 'teal')"">Contract</button>
<button class=""tablink"" onclick=""openPage('About', this, 'orange')"">Probation</button>

<div id=""News"" class=""tabcontent"">
    <ul>
");
#nullable restore
#line 69 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
      
        var x = ViewBag.emp;
        foreach (var i in x)
        {
            if( i.status == "Permanent")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\n                ");
#nullable restore
#line 76 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
           Write(i.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                ");
#nullable restore
#line 77 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
           Write(i.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                ");
#nullable restore
#line 78 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
           Write(i.phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                <a");
                BeginWriteAttribute("href", " href=\'", 2074, "\'", 2108, 2);
                WriteAttributeValue("", 2081, "/Employee/Information/", 2081, 22, true);
#nullable restore
#line 79 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
WriteAttributeValue("", 2103, i.id, 2103, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\">Info</a>\n                </li>\n");
#nullable restore
#line 81 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\n</div>\n\n<div id=\"Contact\" class=\"tabcontent\">\n  <ul>\n");
#nullable restore
#line 89 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
      
        var y = ViewBag.emp;
        foreach (var i in y)
        {
            if( i.status == "Contract")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\n                ");
#nullable restore
#line 96 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
           Write(i.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                ");
#nullable restore
#line 97 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
           Write(i.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                ");
#nullable restore
#line 98 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
           Write(i.phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                <a class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href=\'", 2524, "\'", 2558, 2);
                WriteAttributeValue("", 2531, "/Employee/Information/", 2531, 22, true);
#nullable restore
#line 99 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
WriteAttributeValue("", 2553, i.id, 2553, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Info</a>\n                </li>\n");
#nullable restore
#line 101 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\n</div>\n\n<div id=\"About\" class=\"tabcontent\">\n  <ul>\n");
#nullable restore
#line 109 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
      
        var z = ViewBag.emp;
        foreach (var i in z)
        {
            if( i.status == "Probation")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\n                ");
#nullable restore
#line 116 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
           Write(i.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                ");
#nullable restore
#line 117 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
           Write(i.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                ");
#nullable restore
#line 118 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
           Write(i.phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                <a class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href =\'", 2949, "\'", 2984, 2);
                WriteAttributeValue("", 2957, "/Employee/Information/", 2957, 22, true);
#nullable restore
#line 119 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
WriteAttributeValue("", 2979, i.id, 2979, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Info</a>\n                </li>\n");
#nullable restore
#line 121 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\n</div>\n\n<div class=\"container\">\n<div class=\"column\">\n<div class=\"col-lg-12 col-sm-5\">\n<nav aria-label=\"...\">\n  <ul class=\"pagination marginleft\">\n");
#nullable restore
#line 132 "C:\Users\ASUS\Downloads\FinalProject-1.0.0\Views\Employee\Index.cshtml"
      
      var paging = ViewBag.page;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <li class=""page-item"">
      <a class=""page-link"" href=""/Home/Paging?prev=1"">Previous</a>
    </li>
    <li class=""page-item""><a class=""page-link"" value=""1"" id=""btn1"" href=""/Employee/Index?_crntpage=1"">1</a></li>
    <li class=""page-item""><a class=""page-link"" value=""2"" id=""btn2"" href=""/Employee/Index?_crntpage=2"">2</a></li>
    <li class=""page-item""><a class=""page-link"" value=""3"" id=""btn3"" href=""/Employee/Index?_crntpage=3"">3</a></li>
    <li class=""page-item""><a class=""page-link"" value=""4"" id=""btn4"" href=""/Employee/Index?_crntpage=4"">4</a></li>
    <li class=""page-item""><a class=""page-link"" value=""5"" id=""btn5"" href=""/Employee/Index?_crntpage=5"">5</a></li>
    <li class=""page-item""><a class=""page-link"" value=""6"" id=""btn6"" href=""/Employee/Index?_crntpage=6"">6</a></li>
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
            WriteLiteral("\n</html> ");
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
