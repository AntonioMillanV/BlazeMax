#pragma checksum "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c910c5e31f52c893b18e4973bfe98074077e3be"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<DevExpress.Blazor.DxLayoutBreakpoint>(0);
            __builder.AddAttribute(1, "MaxWidth", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 4 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\MainLayout.razor"
                              1200

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "IsActive", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\MainLayout.razor"
                                     IsMobileLayout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "IsActiveChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsMobileLayout = __value, IsMobileLayout))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "page");
            __builder.AddAttribute(7, "b-j4h4ierrwr");
            __builder.OpenComponent<DevExpress.Blazor.DxGridLayout>(8);
            __builder.AddAttribute(9, "CssClass", "page-layout");
            __builder.AddAttribute(10, "Rows", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 10 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\MainLayout.razor"
             if(IsMobileLayout) {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<DevExpress.Blazor.DxGridLayoutRow>(11);
                __builder2.AddAttribute(12, "Areas", "header");
                __builder2.AddAttribute(13, "Height", "auto");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenComponent<DevExpress.Blazor.DxGridLayoutRow>(15);
                __builder2.AddAttribute(16, "Areas", "sidebar");
                __builder2.AddAttribute(17, "Height", "auto");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.OpenComponent<DevExpress.Blazor.DxGridLayoutRow>(19);
                __builder2.AddAttribute(20, "Areas", "content");
                __builder2.CloseComponent();
#nullable restore
#line 14 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\MainLayout.razor"
            }
            else {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<DevExpress.Blazor.DxGridLayoutRow>(21);
                __builder2.AddAttribute(22, "Areas", "header header");
                __builder2.AddAttribute(23, "Height", "auto");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.OpenComponent<DevExpress.Blazor.DxGridLayoutRow>(25);
                __builder2.AddAttribute(26, "Areas", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\MainLayout.razor"
                                          IsSidebarExpanded ? "sidebar content" : "content content"

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 18 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\MainLayout.razor"
            }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(27, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 21 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\MainLayout.razor"
             if(!IsMobileLayout) {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<DevExpress.Blazor.DxGridLayoutColumn>(28);
                __builder2.AddAttribute(29, "Width", "auto");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenComponent<DevExpress.Blazor.DxGridLayoutColumn>(31);
                __builder2.CloseComponent();
#nullable restore
#line 24 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\MainLayout.razor"
            }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(32, "Items", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxGridLayoutItem>(33);
                __builder2.AddAttribute(34, "Area", "header");
                __builder2.AddAttribute(35, "Template", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazeMaxControls.Shared.Header>(36);
                    __builder3.AddAttribute(37, "ToggleOn", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\MainLayout.razor"
                                             IsSidebarExpanded

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "ToggleOnChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsSidebarExpanded = __value, IsSidebarExpanded))));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxGridLayoutItem>(40);
                __builder2.AddAttribute(41, "Area", "sidebar");
                __builder2.AddAttribute(42, "Template", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazeMaxControls.Shared.NavMenu>(43);
                    __builder3.AddAttribute(44, "StateCssClass", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\MainLayout.razor"
                                             NavMenuCssClass

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxGridLayoutItem>(46);
                __builder2.AddAttribute(47, "Area", "content");
                __builder2.AddAttribute(48, "CssClass", "content px-4");
                __builder2.AddAttribute(49, "Template", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 39 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\MainLayout.razor"
__builder3.AddContent(50, Body);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Shared\MainLayout.razor"
      
    string NavMenuCssClass { get; set; }

    bool _isMobileLayout;
    bool IsMobileLayout {
        get => _isMobileLayout;
        set {
            _isMobileLayout = value;
            IsSidebarExpanded = !_isMobileLayout;
        }
    }

    bool _isSidebarExpanded = true;
    bool IsSidebarExpanded {
        get => _isSidebarExpanded;
        set {
            if(_isSidebarExpanded != value) {
                NavMenuCssClass = value ? "expand" : "collapse";
                _isSidebarExpanded = value;
            }
        }
    }

    protected override void OnInitialized() {
        NavigationManager.LocationChanged += OnLocationChanged;
    }

    async void OnLocationChanged(object sender, LocationChangedEventArgs args) {
        if(IsMobileLayout) {
            IsSidebarExpanded = false;
            await InvokeAsync(StateHasChanged);
        }
    }

    public void Dispose() {
        NavigationManager.LocationChanged -= OnLocationChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
