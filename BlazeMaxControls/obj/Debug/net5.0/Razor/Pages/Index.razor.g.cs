#pragma checksum "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc258cc64f65dfa8ab2411f99f0943632bada67"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\Index.razor"
 foreach(var VXGroup in typeof(ERCAJ_BANCO).GetCustomAttributes(true).Where(attr => attr.GetType() == typeof(VXLayOutGroupAttribute)).OrderBy(gr => gr.GetType().GetProperty("ParentGroup").GetValue(gr)))
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<DevExpress.Blazor.DxFormLayoutGroup>(0);
            __builder.AddAttribute(1, "BeginRow", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\Index.razor"
                   Convert.ToBoolean(VXGroup.GetType().GetProperty("BeginRow").GetValue(VXGroup))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Caption", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\Index.razor"
                  VXGroup.GetType().GetProperty("Description").GetValue(VXGroup).ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 9 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\Index.razor"
         foreach (var VXField in typeof(ERCAJ_BANCO).GetCustomAttributes(true).Where(attr => attr.GetType() == typeof(VXLayOutFieldAttribute)))
		{
			
		}

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 14 "C:\Users\Frog\source\repos\BlazeMaxControls\BlazeMaxControls\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
