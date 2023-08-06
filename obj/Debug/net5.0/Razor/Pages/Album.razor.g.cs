#pragma checksum "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1c301eb1713f430603f8cc9d94f2bca8bf2875"
// <auto-generated/>
#pragma warning disable 1591
namespace SpotifyHelper.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\_Imports.razor"
using SpotifyHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\_Imports.razor"
using SpotifyHelper.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
using SpotifyAPI.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/album")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/album/{AlbumId}")]
    public partial class Album : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .albumCover {\r\n        position: absolute;\r\n        right: 10px;\r\n        top: 10px;\r\n        border-radius: 8px;\r\n        box-shadow: 2px 2px 10px rgba(0, 0, 0, 0.5);\r\n    }\r\n    </style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Album</h3>");
#nullable restore
#line 18 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
 if (FullAlbum?.Images.FirstOrDefault()?.Url != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "img");
            __builder.AddAttribute(3, "class", "albumCover");
            __builder.AddAttribute(4, "height", "250");
            __builder.AddAttribute(5, "width", "250");
            __builder.AddAttribute(6, "src", 
#nullable restore
#line 20 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
                                                           FullAlbum.Images.FirstOrDefault()?.Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "alt", "Logo");
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-10");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-group");
            __builder.AddMarkupContent(14, "<label for=\"albumId\">Album ID:</label>\r\n            ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "id", "albumId");
            __builder.AddAttribute(19, "aria-describedby", "albumId");
            __builder.AddAttribute(20, "placeholder", "Gib eine Album ID ein...");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
                                                                                                                                                AlbumId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AlbumId = __value, AlbumId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-10");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.AddMarkupContent(30, "<label for=\"nameTxt\">Name:</label>\r\n            ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "value", 
#nullable restore
#line 34 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
                           FullAlbum?.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "readonly", "readonly");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.AddAttribute(36, "id", "nameTxt");
            __builder.AddAttribute(37, "placeholder", "Albumname");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
 if (FullAlbum?.Tracks.Items != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "<h2 style=\"margin-top: 15px;\">Tracks</h2>\r\n    ");
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table table-hover table-dark");
            __builder.AddMarkupContent(41, "<thead><tr><th scope=\"col\">Name</th>\r\n                <th scope=\"col\">Explicit</th>\r\n                <th scope=\"col\">Dauer</th></tr></thead>\r\n        ");
            __builder.OpenElement(42, "tbody");
#nullable restore
#line 51 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
             foreach (var track in FullAlbum.Tracks.Items)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "tr");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
                              () => ShowTrack(track)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(45, "td");
#nullable restore
#line 54 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
__builder.AddContent(46, track.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "td");
#nullable restore
#line 55 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
__builder.AddContent(49, track.Explicit ? "Explicit" : "");

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "td");
#nullable restore
#line 56 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
__builder.AddContent(52, track.DurationMs);

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, " ms");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Album.razor"
       

    [ParameterAttribute]
    public string AlbumId { get; set; }
    public FullAlbum FullAlbum { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (!string.IsNullOrEmpty(AlbumId))
        {
            FullAlbum = await Spotify.Albums.Get(AlbumId);
        }
        StateHasChanged();
    }

    private void ShowTrack(SimpleTrack track)
    {
        NavManager.NavigateTo($"songs/{track.Id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SpotifyClient Spotify { get; set; }
    }
}
#pragma warning restore 1591
