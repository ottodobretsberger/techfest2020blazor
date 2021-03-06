#pragma checksum "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\Pages\SuperHero.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04a4da157730a238b6ab2665e5ccbd02e3356b97"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTechfestServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\_Imports.razor"
using BlazorTechfestServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\_Imports.razor"
using BlazorTechfestServer.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/superhero")]
    public partial class SuperHero : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>SuperHero</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\Pages\SuperHero.razor"
                  LoadHeroes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Load Heroes");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "select");
            __builder.AddAttribute(6, "class", "form-control d-flex");
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\Pages\SuperHero.razor"
                                              HeroSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 6 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\Pages\SuperHero.razor"
     foreach (var hero in _heroes)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 8 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\Pages\SuperHero.razor"
                   hero.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, 
#nullable restore
#line 8 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\Pages\SuperHero.razor"
                            hero.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 9 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\Pages\SuperHero.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "\r\n    Selected super hero is: ");
            __builder.AddContent(17, 
#nullable restore
#line 12 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\Pages\SuperHero.razor"
                             _selectedHero?.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\ottod\Source\Repos\BlazorTechfestServer\BlazorTechfestServer\Pages\SuperHero.razor"
       
    private List<BlazorTechfestServer.Data.SuperHero> _heroes = new List<BlazorTechfestServer.Data.SuperHero>();
    private BlazorTechfestServer.Data.SuperHero _selectedHero;

    private void LoadHeroes(MouseEventArgs e)
    {
        _heroes.Clear();

        var batman = new BlazorTechfestServer.Data.SuperHero() { Name = "Batman", Id = 1 };
        var superman = new BlazorTechfestServer.Data.SuperHero() { Name = "Superman", Id = 2 };
        var spiderman = new BlazorTechfestServer.Data.SuperHero() { Name = "Spiderman", Id = 3 };
        var hulk = new BlazorTechfestServer.Data.SuperHero() { Name = "Hulk", Id = 4 };
        var wonderwoman = new BlazorTechfestServer.Data.SuperHero() { Name = "Wonder Woman", Id = 5 };
        var aquaman = new BlazorTechfestServer.Data.SuperHero() { Name = "Aquaman", Id = 6 };
        var wolverine = new BlazorTechfestServer.Data.SuperHero() { Name = "Wolverine", Id = 7 };

        _heroes.Add(batman);
        _heroes.Add(superman);
        _heroes.Add(spiderman);
        _heroes.Add(hulk);
        _heroes.Add(wonderwoman);
        _heroes.Add(aquaman);
        _heroes.Add(wolverine);
    }

    void HeroSelected(ChangeEventArgs e)
    {
        _selectedHero = _heroes.FirstOrDefault(h => h.Id == Convert.ToInt32(e.Value));
        _selectedHero.Name += PrimeNumber(50000);

    }

    public long PrimeNumber(int n)
    {
        int count = 0;
        long a = 2;
        while (count < n)
        {
            long b = 2;
            int prime = 1;
            while (b * b <= a)
            {
                if (a % b == 0)
                {
                    prime = 0; break;
                }
                b++;
            }
            if (prime > 0)
            {
                count++;
            }
            a++;
        }
        return (--a);

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
