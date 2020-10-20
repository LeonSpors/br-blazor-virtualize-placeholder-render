#pragma checksum "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ff82f7533750aadfa1fa128ddf7e6d3de72c9e8"
// <auto-generated/>
#pragma warning disable 1591
namespace VirtualizePlaceholderTest.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\_Imports.razor"
using VirtualizePlaceholderTest.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\_Imports.razor"
using VirtualizePlaceholderTest.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.VirtualizePlaceholderTest.Client.Pages.Index.TypeInference.CreateVirtualize_0(__builder, 0, 1, 
#nullable restore
#line 3 "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\Pages\Index.razor"
                            LoadEmployees

#line default
#line hidden
#nullable disable
            , 2, (context) => (__builder2) => {
                __builder2.OpenElement(3, "p");
                __builder2.AddContent(4, 
#nullable restore
#line 6 "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\Pages\Index.razor"
             context

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            , 5, (context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "<p>\r\n            Loading&hellip;\r\n        </p>");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\leon.spors\source\repos\VirtualizePlaceholderTest\Client\Pages\Index.razor"
       
    private List<string> _employees;

    protected override void OnInitialized()
    {
        _employees = new();

        for (int i = 0; i < 500; i++)
        {
            string id = Guid.NewGuid().ToString();
            _employees.Add(id);
        }
    }

    private async ValueTask<ItemsProviderResult<string>> LoadEmployees(ItemsProviderRequest request)
    {
        List<string> employeeGroup = new();

        for(int i = request.StartIndex; i <= request.Count; i++)
        {
            string id = _employees.ElementAt(i);
            employeeGroup.Add(id);
            await Task.Delay(500);
        }

        return new ItemsProviderResult<string>(employeeGroup, _employees.Count);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.VirtualizePlaceholderTest.Client.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateVirtualize_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<TItem>>(seq);
        __builder.AddAttribute(__seq0, "ItemsProvider", __arg0);
        __builder.AddAttribute(__seq1, "ItemContent", __arg1);
        __builder.AddAttribute(__seq2, "Placeholder", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
