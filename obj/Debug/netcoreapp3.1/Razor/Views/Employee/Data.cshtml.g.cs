#pragma checksum "D:\Users\bsi50130\Desktop\HR App\Views\Employee\Data.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab653ce778045d5d4b605ae6e19657a57fb0c004"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Data), @"mvc.1.0.view", @"/Views/Employee/Data.cshtml")]
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
#line 1 "D:\Users\bsi50130\Desktop\HR App\Views\_ViewImports.cshtml"
using HR_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bsi50130\Desktop\HR App\Views\_ViewImports.cshtml"
using HR_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab653ce778045d5d4b605ae6e19657a57fb0c004", @"/Views/Employee/Data.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e62f4c30eaf77b3d4a4ed88d606bfa61e364d6d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Data : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddNew", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Users\bsi50130\Desktop\HR App\Views\Employee\Data.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab653ce778045d5d4b605ae6e19657a57fb0c0046045", async() => {
                WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<style>
body {font-family: Arial;}

/* Style the tab */
.tab {
  overflow: hidden;
  border: 1px solid #ccc;
  background-color: #f1f1f1;
}

/* Style the buttons inside the tab */
.tab button {
  background-color: inherit;
  float: left;
  border: none;
  outline: none;
  cursor: pointer;
  padding: 14px 16px;
  transition: 0.3s;
  font-size: 17px;
}

/* Change background color of buttons on hover */
.tab button:hover {
  background-color: #ddd;
}

/* Create an active/current tablink class */
.tab button.active {
  background-color: #ccc;
}

/* Style the tab content */
.tabcontent {
  display: none;
  padding: 6px 12px;
  border: 1px solid #ccc;
  border-top: none;
}
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab653ce778045d5d4b605ae6e19657a57fb0c0047809", async() => {
                WriteLiteral(@"

<div class=""text-center"">
<h2>Employee Information Form</h2>
<p>Be Careful with Sensitive Data Information and Privacy</p>
</div>

<button type=""button"" class=""btn btn-primary"" onclick=""javascript: add(this)"">Save</button>
<button type=""button"" class=""btn btn-primary"" onclick=""javascript: addnew(this)"">Save & Add New</button>
<button type=""button"" class=""btn btn-primary"" onclick=""window.location.href ='/Employee'"">Cancel</button>
<br>
<br>

<div class=""tab"">
  <button class=""tablinks"" onclick=""openTab(event, 'Profile')"" id=""defaultopen"">Profile</button>
  <button class=""tablinks"" onclick=""openTab(event, 'Occupation')"">Occupation</button>
  <button class=""tablinks"" onclick=""openTab(event, 'Address')"">Address</button>
  <button class=""tablinks"" onclick=""openTab(event, 'Emergency')"">Emergency</button>
  <button class=""tablinks"" onclick=""openTab(event, 'Aggrements')"">Aggrements</button>
</div>


");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab653ce778045d5d4b605ae6e19657a57fb0c0049037", async() => {
                    WriteLiteral(@"
<div id=""Profile"" class=""tabcontent"">
  <input type=""file"" id=""photo"" name=""photo"" onchange=""showImagePreview(this)"">
  <img id=""imgPreview"" alt=""Preview Image"" style=""width: 200px; height: 300px;"">
  <input placeholder=""Name"" id=""name"" name=""name"" required>
  <input placeholder=""Email"" id=""email"" name=""email"" required>
  <input placeholder=""Phone"" id=""phone"" name=""phone"" required>
  <input placeholder=""Gender"" id=""gender"" name=""gender"" required>
  <input type=""datetime"" placeholder=""date"" id=""date"" name=""date"" required>
  <input placeholder=""place"" id=""place"" name=""place"" required>
</div>

<div id=""Occupation"" class=""tabcontent"">
  <input placeholder=""Position"" id=""position"" name=""position"" required>
  <input placeholder=""Department"" id=""department"" name=""department"" required>
</div>

<div id=""Address"" class=""tabcontent"">
  <input placeholder=""Address"" id=""address"" name=""address"" required>
</div>

<div id=""Emergency"" class=""tabcontent"">
  <input placeholder=""Person Name"" id=""nameugd1"" ");
                    WriteLiteral(@"name=""nameugd1"" required>
  <input placeholder=""Emergency 1"" id=""emergency1"" name=""emergency1"" required>
  <input placeholder=""Person Name"" id=""nameugd2"" name=""nameugd2"" required>
  <input placeholder=""Emergency 2"" id=""emergency2"" name=""emergency2"" required>
  <input placeholder=""Person Name"" id=""nameugd3"" name=""nameugd3"" required>
  <input placeholder=""Emergency 3"" id=""emergency3"" name=""emergency3"" required>
</div>

<div id=""Aggrements"" class=""tabcontent"">
  <input placeholder=""Status"" id=""status"" name=""status"" required>
  <input type=""datetime"" placeholder=""Contract"" id=""contract"" name=""contract"" required>
  ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab653ce778045d5d4b605ae6e19657a57fb0c00411133", async() => {
                        WriteLiteral("Save");
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
                    WriteLiteral("\r\n  ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab653ce778045d5d4b605ae6e19657a57fb0c00412755", async() => {
                        WriteLiteral("Save");
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
                    WriteLiteral("\r\n</div>\r\n");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

<script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://code.jquery.com/jquery-3.1.1.min.js""></script>
<script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script> 

<script type=""text/javascript"" src=""http://code.jquery.com/jquery-1.8.2.js""></script>
  <script type=""text/javascript"">
  function showImagePreview(input) {
  if (input.files && input.files[0]) {
  var filerdr = new FileReader();
  filerdr.onload = function (e) {
  $('#imgPreview').attr('src', e.target.result);
  }
  filerdr.readAsDataURL(input.files[0]);
  }
  }
  </script>

<script type=""text/javascript"">
function add(btn)
{
  alert(""Are you Sure Everthing is Okay?"");
  var name = document.getElementById(""name"").value;
  var email = document.getElementById(""email"").value;
  ");
                WriteLiteral(@"var phone = document.getElementById(""phone"").value;
  var gender = document.getElementById(""gender"").value;
  var date = document.getElementById(""date"").value;
  var place = document.getElementById(""place"").value;
  var position = document.getElementById(""position"").value;
  var department = document.getElementById(""department"").value;
  var address = document.getElementById(""address"").value;
  var nameugd1 = document.getElementById(""nameugd1"").value;
  var nameugd2 = document.getElementById(""nameugd2"").value;
  var nameugd3 = document.getElementById(""nameugd3"").value;
  var emergency1 = document.getElementById(""emergency1"").value;
  var emergency2 = document.getElementById(""emergency2"").value;
  var emergency3 = document.getElementById(""emergency3"").value;
  var status = document.getElementById(""status"").value;
  var contract = document.getElementById(""contract"").value;
  location.href = '/Employee/Add?name='+name+'&email='+email+'&phone='+phone+'&gender='+gender+'&date='+date+'&place='+place+");
                WriteLiteral(@"'&position='+position+'&department='+department+'&address='+address+'&nameugd1='+nameugd1+'&nameugd2='+nameugd2+'&nameugd2='+nameugd2+'&nameugd3='+nameugd3+'&emergency1='+emergency1+'&emergency2='+emergency2+'&emergency3='+emergency3+'&status='+status+'&contract='+contract;
}
function addnew(btn)
{
  alert(""Are you Sure Everthing is Okay?"");
  var name = document.getElementById(""name"").value;
  var email = document.getElementById(""email"").value;
  var phone = document.getElementById(""phone"").value;
  var gender = document.getElementById(""gender"").value;
  var date = document.getElementById(""date"").value;
  var place = document.getElementById(""place"").value;
  var position = document.getElementById(""position"").value;
  var department = document.getElementById(""department"").value;
  var address = document.getElementById(""address"").value;
  var nameugd1 = document.getElementById(""nameugd1"").value;
  var nameugd2 = document.getElementById(""nameugd2"").value;
  var nameugd3 = document.getElementById");
                WriteLiteral(@"(""nameugd3"").value;
  var emergency1 = document.getElementById(""emergency1"").value;
  var emergency2 = document.getElementById(""emergency2"").value;
  var emergency3 = document.getElementById(""emergency3"").value;
  var status = document.getElementById(""status"").value;
  var contract = document.getElementById(""contract"").value;
  location.href = '/Employee/AddNew?name='+name+'&email='+email+'&phone='+phone+'&gender='+gender+'&date='+date+'&place='+place+'&position='+position+'&department='+department+'&address='+address+'&nameugd1='+nameugd1+'&nameugd2='+nameugd2+'&nameugd2='+nameugd2+'&nameugd3='+nameugd3+'&emergency1='+emergency1+'&emergency2='+emergency2+'&emergency3='+emergency3+'&status='+status+'&contract='+contract;
}
</script>
<script>
function openTab(evt, log) {
  var i, tabcontent, tablinks;
  tabcontent = document.getElementsByClassName(""tabcontent"");
  for (i = 0; i < tabcontent.length; i++) {
    tabcontent[i].style.display = ""none"";
  }
  tablinks = document.getElementsByClassName");
                WriteLiteral(@"(""tablinks"");
  for (i = 0; i < tablinks.length; i++) {
    tablinks[i].className = tablinks[i].className.replace("" active"", """");
  }
  document.getElementById(log).style.display = ""block"";
  evt.currentTarget.className += "" active"";
}
document.getElementById(""defaultopen"").click();
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
            WriteLiteral("\r\n</html> \r\n");
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