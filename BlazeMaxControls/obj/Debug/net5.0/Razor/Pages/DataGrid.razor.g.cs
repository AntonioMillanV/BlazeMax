#pragma checksum "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\DataGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "819b244fdb76cc33acfa90b0bdca551a191b9556"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazeMaxControls.Pages
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
#nullable restore
#line 3 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\DataGrid.razor"
using BlazeMaxControls.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid")]
    public partial class DataGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>DevExpress Data Grid</h2>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p class=\"pb-2 pt-2 mw-1100\">The DevExpress Data Grid for Blazor allows you to display and manage data via a tabular (rows/columns) UI metaphor. \r\nThis page uses our Blazor Data Grid component to display weather forecast values.</p>");
#nullable restore
#line 12 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\DataGrid.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\DataGrid.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.BlazeMaxControls.Pages.DataGrid.TypeInference.CreateDxDataGrid_0(__builder, 3, 4, 
#nullable restore
#line 18 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\DataGrid.razor"
                       forecasts

#line default
#line hidden
#nullable disable
            , 5, "mw-1100", 6, (__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridDateEditColumn>(7);
                __builder2.AddAttribute(8, "Field", "Date");
                __builder2.AddAttribute(9, "Caption", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\DataGrid.razor"
                                                            L["Date"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "DisplayFormat", "D");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(12);
                __builder2.AddAttribute(13, "Field", "TemperatureC");
                __builder2.AddAttribute(14, "Caption", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\DataGrid.razor"
                                                            L["Temperature"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 25 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\DataGrid.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\DataGrid.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<DataGrid> L { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
namespace __Blazor.BlazeMaxControls.Pages.DataGrid
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDxDataGrid_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGrid<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CssClass", __arg1);
        __builder.AddAttribute(__seq2, "Columns", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
