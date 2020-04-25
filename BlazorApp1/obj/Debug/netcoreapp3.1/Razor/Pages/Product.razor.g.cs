#pragma checksum "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\Pages\Product.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e68732bb049e7addb1780d32c23c686a663c7507"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\Pages\Product.razor"
using BlazorEntity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\Pages\Product.razor"
using BlazorDataAccess;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product")]
    public partial class Product : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Product</h3>\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h2>Products</h2>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\Pages\Product.razor"
 if (products != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\Pages\Product.razor"
     foreach (BlazorEntity.Product product in products)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.OpenElement(3, "label");
            __builder.AddContent(4, 
#nullable restore
#line 18 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\Pages\Product.razor"
                product.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n        <br>\r\n        ");
            __builder.OpenElement(6, "label");
            __builder.AddContent(7, 
#nullable restore
#line 20 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\Pages\Product.razor"
                product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        <br>\r\n        ");
            __builder.OpenElement(9, "label");
            __builder.AddContent(10, 
#nullable restore
#line 22 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\Pages\Product.razor"
                product.ProductDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        <br>\r\n        ");
            __builder.OpenElement(12, "label");
            __builder.AddContent(13, 
#nullable restore
#line 24 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\Pages\Product.razor"
                product.ProductImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        <br>\r\n");
#nullable restore
#line 26 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\Pages\Product.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\Pages\Product.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\enderuser\Source\repos\BlazorApp1\BlazorApp1\Pages\Product.razor"
       

    private List<BlazorEntity.Product> products;

    protected override async Task OnInitializedAsync()
    {
        products = await _productManager.GetProducts();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductManager _productManager { get; set; }
    }
}
#pragma warning restore 1591