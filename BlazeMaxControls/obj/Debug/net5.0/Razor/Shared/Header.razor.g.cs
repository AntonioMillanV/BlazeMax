#pragma checksum "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\Header.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c368a1d5cde1e546ded82c8f828f7cb7ae95cbf"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazeMaxControls.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using BlazeMaxControls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using BlazeMaxControls.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using veXMAX.Shared.Attributes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\_Imports.razor"
using veXMAX.Shared.Models.Transactions;

#line default
#line hidden
#nullable disable
    public partial class Header : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar header-navbar p-0");
            __builder.AddAttribute(2, "b-a9pfudx3qs");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "navbar-toggler bg-primary d-block");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\Header.razor"
                                                                OnToggleClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "b-a9pfudx3qs");
            __builder.AddMarkupContent(7, "<span class=\"navbar-toggler-icon\" b-a9pfudx3qs></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"ms-3 fw-bold title pe-4\" b-a9pfudx3qs>BlazeMaxControls</div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\Header.razor"
       
    [Parameter] public bool ToggleOn { get; set; }
    [Parameter] public EventCallback<bool> ToggleOnChanged { get; set; }

    async Task OnToggleClick() => await Toggle();

    async Task Toggle(bool? value = null) {
        var newValue = value ?? !ToggleOn;
        if(ToggleOn != newValue) {
            ToggleOn = newValue;
            await ToggleOnChanged.InvokeAsync(ToggleOn);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
