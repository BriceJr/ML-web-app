#pragma checksum "C:\Users\samki\source\repos\WebECApp\WebECApp\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c29e372a905bfd57c914f88999ce931784390a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebECApp.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
namespace WebECApp.Pages
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
#line 1 "C:\Users\samki\source\repos\WebECApp\WebECApp\Pages\_ViewImports.cshtml"
using WebECApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c29e372a905bfd57c914f88999ce931784390a8", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd620144c5b481032c85c67a76033f764b672563", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Admin/Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""smallcontainer"">
    <div class=""row"">
        <div class=""myplayer"">
            <video id=""myvideo"" autoplay>
                <source src=""/images/company-update-copy.mp4"" type=""video/mp4"">
            </video>
            <br>
            <div class=""controls"">
                <button id=""playbttn"">Pause</button>
                <button id=""stopbttn"">Stop</button>
                <input id=""slider"" type=""range"" min=""0"" max=""100"" value=""0"">
                <span id=""currenttime""></span> / <span id=""durationtime""></span>
                <button id=""volctrl"">Mute</button>
                <input id=""volslide"" type=""range"" min=""0"" max=""100"" value=""100"">
            </div>
        </div>
    </div>
    <br />
</div>
<br />
<br />
<div class=""smallcontainer"">
    <div class=""row"">
        <h3 class=""title"">Return Policy</h3>
        <p>
            Mills legacy has a maintained a direct customer centric policy over the years. Products which
            our customers find diss");
            WriteLiteral(@"atisying or which arrive with unforseen damages may be shipped back within a 15day time
            frame. A <a href=""Return""><small>return form</small></a> is made available for our customers to help manage this. It should be notted that
            Mills legacy doesnt do full cash refund on payments made but will allow customers pick an article of same
            or atleast three quarters the value of the originally purchased item and the difference will be paid to them
            through the initial method of payment.
        </p>
    </div>
</div>
<div class=""row"">
    <a href=""Return"" class=""bot"" >Return form</a>
</div>
<div class=""row"">
    <hr />
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c29e372a905bfd57c914f88999ce931784390a84935", async() => {
                WriteLiteral("<small>Privacy</small>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>


<script type=""text/javascript"">
    // set object refernces
    var vid = document.getElementById(""myvideo"");
    var currenttime = document.getElementById(""currenttime"");
    var durationtime = document.getElementById(""durationtime"");
    var plbttn = document.getElementById(""playbttn"");
    var vol = document.getElementById(""volctrl"");
    var stopbtn = document.getElementById(""stopbttn"");
    var slide = document.getElementById(""slider"");
    var volslide = document.getElementById(""volslide"");

    //play/pause vid function
    function playvid() {
        if (vid.paused) {
            vid.play();
            plbttn.innerHTML = ""Pause"";
        } else {
            vid.pause();
            plbttn.innerHTML = ""Play"";
        }
    }
    // stop function
    function stopvid() {
        vid.pause();
        vid.currentTime = 0;
        plbttn.innerHTML = ""Play"";
    }
    //volume function
    function volvid() {
        if (vid.muted) {
            vid.muted = fal");
            WriteLiteral(@"se;
            volslide.value = 100;
            vol.innerHTML = ""Mute"";
        } else {
            vid.muted = true;
            volslide.value = 0;
            vol.innerHTML = ""Unmute"";
        }
    }
    // volume slider
    function volslidvid() {
        vid.volume = volslide.value / 100;

    }
    // video slider(clicking)
    function slidevid() {
        vid.currentTime = vid.duration * (slide.value / 100);
    }
    // video slider(pulling)
    function movevid() {
        slide.value = vid.currentTime * (100 / vid.duration);
        var mins = Math.floor(vid.currentTime / 60);
        var secs = Math.floor(vid.currentTime - mins * 60);
        var duramins = Math.floor(vid.duration / 60);
        var durasecs = Math.floor(vid.duration - mins * 60);
        if (secs < 10) {
            secs = ""0"" + secs;
        }
        if (durasecs < 10) {
            durasecs = ""0"" + durasecs;
        }
        if (mins < 10) {
            mins = ""0"" + mins;
        }
      ");
            WriteLiteral(@"  if (duramins < 10) {
            duramins = ""0"" + duramins;
        }
        currenttime.innerHTML = mins + "":"" + secs;
        durationtime.innerHTML = duramins + "":"" + durasecs;
    }

    // adding event listeners
    plbttn.addEventListener(""click"", playvid);
    vol.addEventListener(""click"", volvid);
    stopbtn.addEventListener(""click"", stopvid);
    slide.addEventListener(""change"", slidevid);
    vid.addEventListener(""timeupdate"", movevid);
    volslide.addEventListener(""change"", volslidvid);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebECApp.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebECApp.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebECApp.Pages.AboutModel>)PageContext?.ViewData;
        public WebECApp.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
