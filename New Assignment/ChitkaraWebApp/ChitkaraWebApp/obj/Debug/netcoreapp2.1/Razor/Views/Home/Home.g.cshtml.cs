#pragma checksum "C:\Users\sabin.nepali\Desktop\New Assignment\ChitkaraWebApp\ChitkaraWebApp\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ecf9c057029d8a2d241dfd8c4c3a6ed64d05f34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "C:\Users\sabin.nepali\Desktop\New Assignment\ChitkaraWebApp\ChitkaraWebApp\Views\_ViewImports.cshtml"
using ChitkaraWebApp;

#line default
#line hidden
#line 2 "C:\Users\sabin.nepali\Desktop\New Assignment\ChitkaraWebApp\ChitkaraWebApp\Views\_ViewImports.cshtml"
using ChitkaraWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ecf9c057029d8a2d241dfd8c4c3a6ed64d05f34", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b3f2e12c421d66504629c42972062d66aa8b6ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\sabin.nepali\Desktop\New Assignment\ChitkaraWebApp\ChitkaraWebApp\Views\Home\Home.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(42, 196, true);
            WriteLiteral("<br /><br />\r\n<button onclick=\"get_All_Result_To()\" type=\"button\">Get all Records</button><br /><br />\r\n<button onclick=\"getResultTo()\" type=\"button\">Get a single Record</button><br /><br />\r\n\r\n\r\n");
            EndContext();
            BeginContext(238, 363, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9610241ea34aea9c66b02937c3bca8", async() => {
                BeginContext(267, 327, true);
                WriteLiteral(@"
    <input id=""Name"" placeholder=""Student's Name"" />
    <input id=""Age"" placeholder=""Student's Age"" />
    <input id=""Contact"" placeholder=""Student's Contact"" />
    <input id=""Department"" placeholder=""Student's Department"" />
    <button onclick=""postResultTo()"" id=""#btn2"" type=""button"">Update single record</button>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(601, 1996, true);
            WriteLiteral(@"<br />



<input id=""elmnt"" type=""text"" />
<button onclick=""dataFrom()"" type=""button"">Search the data</button>
<br /><br />
<p id=""msg""></p>



<div id=""container""></div>

<script src=""https://code.jquery.com/jquery-3.3.1.min.js"" type=""text/javascript"">
    function get_All_Result_To() {
        $.ajax({
            type: ""GET"",
            url: ""/Home/GetStudentDetails"",
            success: function (msg) {
                var data = JSON.stringify(msg);
                document.getElementById('container').innerHTML = data;
            },
            error: function (req, status, error) {
                alert(error);
            }
        });
    }

    function getResultTo() {
        $.ajax({
            type: ""GET"",
            url: ""/Home/GetStudentDetailsByIdAsync"",
            data: { ""id"": 5 },
            dataType: ""json"",
            success: function (msg) {
                var data = JSON.stringify(msg);
                document.getElementById('container').inn");
            WriteLiteral(@"erHTML = data;
            },
            error: function (req, status, error) {
                alert(error);
            }
        });
    }
    function postResultTo() {
        var data = {
            StudentName: $(""#Name"").val(),
            StudentAge: $(""#Age"").val(),
            StudentContact: $(""#Contact"").val(),
            StudentDepartment: $(""#Department"").val()
        }
        console.log(data);
        var msg = JSON.stringify(data);
        document.getElementById('container').innerHTML = msg;
        document.getElementById('container');
        $.ajax({
            type: ""POST"",
            url: ""/Home/PostStudent"",
            contentType: ""application/json; charset=utf-16"",
            data: JSON.stringify(data),
            success: function (msg) {
                console.log(msg);
            },
            error: function (req, status, error) {
                alert(error);
            }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
