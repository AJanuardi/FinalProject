#pragma checksum "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9ab1b31ad87534b668c26ca2ee8e877b4c1fe80"
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
#line 1 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\_ViewImports.cshtml"
using HR_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\_ViewImports.cshtml"
using HR_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ab1b31ad87534b668c26ca2ee8e877b4c1fe80", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"390e6b011c80c8aacfb8cb7c82a5633b478e25dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Import", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ab1b31ad87534b668c26ca2ee8e877b4c1fe806361", async() => {
                WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" type=""text/css"" href=""https://fonts.googleapis.com/css?family=Arimo:400,700&display=swap"">
<style>
body{
  font-family: 'Arimo', sans-serif;
}
h2{
  color:#000;
  text-align:center;
  font-size:2em;
}
.warpper{
  display:flex;
  flex-direction: column;
  align-items: center;
}
.tab{
  cursor: pointer;
  padding:20px 100px;
  margin:0px 10px;
  background:#000;
  display:inline-block;
  color:#fff;
  border-radius:3px 3px 0px 0px;
  box-shadow: 0 0.5rem 0.8rem #00000080;
}
.panels{
  background:#fff;
  box-shadow: 0 2rem 2rem #00000080;
  min-height:375px;
  width:100%;
  max-width:1200px;
  border-radius:3px;
  overflow:hidden;
  padding:20px;  
}
.panel{
  display:none;
  animation: fadein .8s;
}
.panel-title{
  font-size:1.5em;
  font-weight:bold
}
.radio{
  display:none;
}
#one:checked ~ .panels #one-panel,
#two:checked ~ .panels #two-panel,
#three:checked ~ .panels #three-panel{
  display:block
}
#one:checked ~ .t");
                WriteLiteral(@"abs #one-tab,
#two:checked ~ .tabs #two-tab,
#three:checked ~ .tabs #three-tab{
  background:#fff;
  color:#000;
  border-top: 3px solid #000;
}

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ab1b31ad87534b668c26ca2ee8e877b4c1fe809205", async() => {
                WriteLiteral(@"
<div class=""container"">
  <div class=""row"">
    <div class=""col-md-2""></div>
    <div class=""col-md-8"">
      <div class=""text-center"">
      <h1><b>Employees System</b></h1>
      <p>Be Carefuly with Employees Information</p>
      </div>
    </div>
  </div>
</div>
<div class=""container"">
  <div class=""row"">
    <div class=""col-md-2""></div>
    <div class=""col-md-8"">
      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ab1b31ad87534b668c26ca2ee8e877b4c1fe809856", async() => {
                    WriteLiteral("\n        <div class=\"form-group\">\n");
#nullable restore
#line 125 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
            
          var k = ViewBag.search;

#line default
#line hidden
#nullable disable
                    WriteLiteral("          <input class=\"form-control\" id=\"search\" name=\"search\" placeholder=\"Searching for. . .\"");
                    BeginWriteAttribute("value", " value=", 2497, "", 2506, 1);
#nullable restore
#line 127 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
WriteAttributeValue("", 2504, k, 2504, 2, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n");
                    WriteLiteral("          <div class=\"text-center\">\n            <br>\n          ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ab1b31ad87534b668c26ca2ee8e877b4c1fe8010982", async() => {
                        WriteLiteral("Search");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n          ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ab1b31ad87534b668c26ca2ee8e877b4c1fe8012612", async() => {
                        WriteLiteral("Export");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n          </div>\n        </div>\n      ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>
  </div>
</div>
<br>

<div class=""container"">
  <div class=""row"">
    <div class=""col-md-8"">
        <a href=""/Employee/Data"" class=""btn btn-info"">Add Employee</a>
        <a href=""/Employee/Export"" class=""btn btn-info"">Export (All)</a>
    </div>
    <div class=""col-md-4"">
      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9ab1b31ad87534b668c26ca2ee8e877b4c1fe8015815", async() => {
                    WriteLiteral(@"
      <div class=""input-group"">
      <div class=""custom-file"">
        <input type=""file"" class=""custom-file-input outline-success"" id=""Upload"" name=""Upload"" value=""Upload"" required>
        <label class=""custom-file-label"" for=""Upload"">Choose file. . .</label>
      </div>
      <div class=""input-group-append"">
        <button class=""btn btn-secondary"" type=""submit"">Import</button>
      </div>
      </div>
      ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>
  </div>
</div>
<br>
<br>

<div class=""warpper"">
  <input class=""radio"" id=""one"" name=""group"" type=""radio"" checked>
  <input class=""radio"" id=""two"" name=""group"" type=""radio"">
  <input class=""radio"" id=""three"" name=""group"" type=""radio"">
  <div class=""tabs"">
  <label class=""tab"" id=""one-tab"" for=""one"">Permanent</label>
  <label class=""tab"" id=""two-tab"" for=""two"">Contract</label>
  <label class=""tab"" id=""three-tab"" for=""three"">Probation</label>
  </div>
  <div class=""panels"">
  <div class=""panel"" id=""one-panel"">
    <ul class=""list-group"">
");
#nullable restore
#line 177 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
      
        var x = ViewBag.emp2;
        foreach (var i in x)
        {
            if( i.status == "Permanent")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"list-group-item\">\n                <div class=\"container\">\n                  <div class=\"row\">\n                    <div class=\"col-md-3\">\n                    Name: ");
#nullable restore
#line 187 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
                     Write(i.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-5\">\n                    Email: ");
#nullable restore
#line 190 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
                      Write(i.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-3\">\n                    Phone: ");
#nullable restore
#line 193 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
                      Write(i.phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-1\">\n                    <a");
                BeginWriteAttribute("href", " href=\'", 4841, "\'", 4875, 2);
                WriteAttributeValue("", 4848, "/Employee/Information/", 4848, 22, true);
#nullable restore
#line 196 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
WriteAttributeValue("", 4870, i.id, 4870, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-warning\">Info</a>\n                    </div>\n                  </div>\n                </div>\n                </li>\n                <br>\n");
#nullable restore
#line 202 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\n  </div>\n  <div class=\"panel\" id=\"two-panel\">\n    <ul class=\"list-group\">\n");
#nullable restore
#line 209 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
      
        var y = ViewBag.emp1;
        foreach (var i in y)
        {
            if( i.status == "Contract")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"list-group-item\">\n                <div class=\"container\">\n                  <div class=\"row\">\n                    <div class=\"col-md-3\">\n                    Name: ");
#nullable restore
#line 219 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
                     Write(i.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-5\">\n                    Email: ");
#nullable restore
#line 222 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
                      Write(i.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-3\">\n                    Phone: ");
#nullable restore
#line 225 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
                      Write(i.phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-1\">\n                    <a");
                BeginWriteAttribute("href", " href=\'", 5782, "\'", 5816, 2);
                WriteAttributeValue("", 5789, "/Employee/Information/", 5789, 22, true);
#nullable restore
#line 228 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
WriteAttributeValue("", 5811, i.id, 5811, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-warning\">Info</a>\n                    </div>\n                  </div>\n                </div>\n                </li>\n                <br>\n");
#nullable restore
#line 234 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\n  </div>\n  <div class=\"panel\" id=\"three-panel\">\n    <ul class=\"list-group\">\n");
#nullable restore
#line 241 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
      
        var z = ViewBag.emp;
        foreach (var i in z)
        {
            if( i.status == "Probation")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("               <li class=\"list-group-item\">\n                <div class=\"container\">\n                  <div class=\"row\">\n                    <div class=\"col-md-3\">\n                    Name: ");
#nullable restore
#line 251 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
                     Write(i.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-5\">\n                    Email: ");
#nullable restore
#line 254 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
                      Write(i.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-3\">\n                    Phone: ");
#nullable restore
#line 257 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
                      Write(i.phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-1\">\n                    <a");
                BeginWriteAttribute("href", " href=\'", 6724, "\'", 6758, 2);
                WriteAttributeValue("", 6731, "/Employee/Information/", 6731, 22, true);
#nullable restore
#line 260 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
WriteAttributeValue("", 6753, i.id, 6753, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-warning\">Info</a>\n                    </div>\n                  </div>\n                </div>\n                </li>\n                <br>\n");
#nullable restore
#line 266 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\n  </div>\n  </div>\n</div>\n<br>\n<br>\n\n<div class=\"container\">\n<div class=\"column\">\n<div class=\"col-lg-12 col-sm-5\">\n<nav aria-label=\"...\">\n  <ul class=\"pagination justify-content-center\">\n");
#nullable restore
#line 281 "D:\Users\bsi50130\Downloads\FinalProject-1.8.0\Views\Employee\Index.cshtml"
      
      var paging = ViewBag.page;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <li class=""page-item""><button class=""page-link"" value=""1"" id=""btn1"" onclick=""javascript:page1(this)"">1</button></li>
    <li class=""page-item""><button class=""page-link"" value=""2"" id=""btn2"" onclick=""javascript:page2(this)"">2</button></li>
    <li class=""page-item""><button class=""page-link"" value=""3"" id=""btn3"" onclick=""javascript:page3(this)"">3</button></li>
    <li class=""page-item""><button class=""page-link"" value=""4"" id=""btn4"" onclick=""javascript:page4(this)"">4</button></li>
    <li class=""page-item""><button class=""page-link"" value=""5"" id=""btn5"" onclick=""javascript:page5(this)"">5</button></li>
    <li class=""page-item""><button class=""page-link"" value=""6"" id=""btn6"" onclick=""javascript:page6(this)"">6</button></li>
");
                WriteLiteral("  </ul>\n\n");
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
            WriteLiteral(@"
</html>

<script type=""text/javascript"">
function page1(btn)
{
  var search = document.getElementById(""search"").value;
  location.href='/Employee/Index?_crntpage=1&search='+search;
}
function page2(btn)
{
  var search = document.getElementById(""search"").value;
  location.href='/Employee/Index?_crntpage=2&search='+search;
}
function page3(btn)
{
  var search = document.getElementById(""search"").value;
  location.href='/Employee/Index?_crntpage=3&search='+search;
}
function page4(btn)
{
  var search = document.getElementById(""search"").value;
  location.href='/Employee/Index?_crntpage=4&search='+search;
}
function page5(btn)
{
  var search = document.getElementById(""search"").value;
  location.href='/Employee/Index?_crntpage=5&search='+search;
}
function page6(btn)
{
  var search = document.getElementById(""search"").value;
  location.href='/Employee/Index?_crntpage=6&search='+search;
}
</script>");
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
