#pragma checksum "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6979c1009897136754cf78c3264d6d714b5797af"
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
#line 3 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
using SpotifyAPI.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
using Swan;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/songs")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/songs/{SongId}")]
    public partial class Songs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group");
            __builder.AddMarkupContent(6, "<label for=\"songId\">Song ID:</label>\r\n            ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "id", "songId");
            __builder.AddAttribute(11, "aria-describedby", "songId");
            __builder.AddAttribute(12, "placeholder", "Gib eine Song ID ein...");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                                                                                                                                             SongId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SongId = __value, SongId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "row");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-1");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                                        RufeInformationenFürSongAb

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddContent(24, "Abrufen");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
     if (FullTrack != null && FullTrack.ExternalUrls.FirstOrDefault().Value != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-1");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "href", 
#nullable restore
#line 23 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                                    FullTrack.ExternalUrls.FirstOrDefault().Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddContent(31, "Abspielen");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group");
            __builder.AddMarkupContent(39, "<label for=\"nameTxt\">Name:</label>\r\n            ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "value", 
#nullable restore
#line 31 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                           FullTrack?.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "type", "text");
            __builder.AddAttribute(43, "readonly", "readonly");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "id", "nameTxt");
            __builder.AddAttribute(46, "placeholder", "Songname");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group");
            __builder.AddMarkupContent(52, "<label for=\"genresTxt\">Genres:</label>\r\n            ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "value", 
#nullable restore
#line 37 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                           Genres

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(55, "type", "text");
            __builder.AddAttribute(56, "readonly", "readonly");
            __builder.AddAttribute(57, "class", "form-control");
            __builder.AddAttribute(58, "id", "genresTxt");
            __builder.AddAttribute(59, "placeholder", "Genres");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group");
            __builder.AddMarkupContent(65, "<label for=\"popularityTxt\">Popularität:</label>\r\n            ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "value", 
#nullable restore
#line 43 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                           FullTrack?.Popularity

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(68, "type", "text");
            __builder.AddAttribute(69, "readonly", "readonly");
            __builder.AddAttribute(70, "class", "form-control");
            __builder.AddAttribute(71, "id", "popularityTxt");
            __builder.AddAttribute(72, "placeholder", "Popularität des Songs");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "row");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "form-group");
            __builder.AddMarkupContent(80, "<label for=\"akustikTxt\">Akustik:</label>\r\n            ");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "value", 
#nullable restore
#line 51 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                           SongFeatures?.Acousticness

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(83, "type", "text");
            __builder.AddAttribute(84, "readonly", "readonly");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "id", "akustikTxt");
            __builder.AddAttribute(87, "placeholder", "Akustik");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "col");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "form-group");
            __builder.AddMarkupContent(93, "<label for=\"tanzbarkeitTxt\">Tanzbarkeit:</label>\r\n            ");
            __builder.OpenElement(94, "input");
            __builder.AddAttribute(95, "value", 
#nullable restore
#line 57 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                           SongFeatures?.Danceability

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(96, "type", "text");
            __builder.AddAttribute(97, "readonly", "readonly");
            __builder.AddAttribute(98, "class", "form-control");
            __builder.AddAttribute(99, "id", "tanzbarkeitTxt");
            __builder.AddAttribute(100, "placeholder", "Tanzbarkeit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n    ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "col");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "form-group");
            __builder.AddMarkupContent(106, "<label for=\"energieTxt\">Energie:</label>\r\n            ");
            __builder.OpenElement(107, "input");
            __builder.AddAttribute(108, "value", 
#nullable restore
#line 63 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                           SongFeatures?.Energy

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(109, "type", "text");
            __builder.AddAttribute(110, "readonly", "readonly");
            __builder.AddAttribute(111, "class", "form-control");
            __builder.AddAttribute(112, "id", "energieTxt");
            __builder.AddAttribute(113, "placeholder", "Energie");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "row");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "col");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "form-group");
            __builder.AddMarkupContent(121, "<label for=\"instrumentalitätTxt\">Instrumentalität:</label>\r\n            ");
            __builder.OpenElement(122, "input");
            __builder.AddAttribute(123, "value", 
#nullable restore
#line 71 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                           SongFeatures?.Instrumentalness

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(124, "type", "text");
            __builder.AddAttribute(125, "readonly", "readonly");
            __builder.AddAttribute(126, "class", "form-control");
            __builder.AddAttribute(127, "id", "instrumentalitätTxt");
            __builder.AddAttribute(128, "placeholder", "Instrumentalität");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n    ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "col");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "form-group");
            __builder.AddMarkupContent(134, "<label for=\"lebendigkeitTxt\">Lebendigkeit:</label>\r\n            ");
            __builder.OpenElement(135, "input");
            __builder.AddAttribute(136, "value", 
#nullable restore
#line 77 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                           SongFeatures?.Liveness

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(137, "type", "text");
            __builder.AddAttribute(138, "readonly", "readonly");
            __builder.AddAttribute(139, "class", "form-control");
            __builder.AddAttribute(140, "id", "lebendigkeitTxt");
            __builder.AddAttribute(141, "placeholder", "Lebendigkeit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n    ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "col");
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "class", "form-group");
            __builder.AddMarkupContent(147, "<label for=\"lautstärkeTxt\">Lautstärke:</label>\r\n            ");
            __builder.OpenElement(148, "input");
            __builder.AddAttribute(149, "value", 
#nullable restore
#line 83 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                           SongFeatures?.Loudness

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(150, "type", "text");
            __builder.AddAttribute(151, "readonly", "readonly");
            __builder.AddAttribute(152, "class", "form-control");
            __builder.AddAttribute(153, "id", "lautstärkeTxt");
            __builder.AddAttribute(154, "placeholder", "Lautstärke");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n");
            __builder.OpenElement(156, "div");
            __builder.AddAttribute(157, "class", "row");
            __builder.OpenElement(158, "div");
            __builder.AddAttribute(159, "class", "col");
            __builder.OpenElement(160, "div");
            __builder.AddAttribute(161, "class", "form-group");
            __builder.AddMarkupContent(162, "<label for=\"sprachlichkeitTxt\">Sprachlichkeit:</label>\r\n            ");
            __builder.OpenElement(163, "input");
            __builder.AddAttribute(164, "value", 
#nullable restore
#line 91 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                           SongFeatures?.Speechiness

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(165, "type", "text");
            __builder.AddAttribute(166, "readonly", "readonly");
            __builder.AddAttribute(167, "class", "form-control");
            __builder.AddAttribute(168, "id", "sprachlichkeitTxt");
            __builder.AddAttribute(169, "placeholder", "Sprachlichkeit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n    ");
            __builder.OpenElement(171, "div");
            __builder.AddAttribute(172, "class", "col");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "form-group");
            __builder.AddMarkupContent(175, "<label for=\"tempoTxt\">Tempo:</label>\r\n            ");
            __builder.OpenElement(176, "input");
            __builder.AddAttribute(177, "value", 
#nullable restore
#line 97 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                           SongFeatures?.Tempo

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(178, "type", "text");
            __builder.AddAttribute(179, "readonly", "readonly");
            __builder.AddAttribute(180, "class", "form-control");
            __builder.AddAttribute(181, "id", "tempoTxt");
            __builder.AddAttribute(182, "placeholder", "Tempo");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n    ");
            __builder.OpenElement(184, "div");
            __builder.AddAttribute(185, "class", "col");
            __builder.OpenElement(186, "div");
            __builder.AddAttribute(187, "class", "form-group");
            __builder.AddMarkupContent(188, "<label for=\"wertigkeitTxt\">Wertigkeit:</label>\r\n            ");
            __builder.OpenElement(189, "input");
            __builder.AddAttribute(190, "value", 
#nullable restore
#line 103 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                           SongFeatures?.Valence

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(191, "type", "text");
            __builder.AddAttribute(192, "readonly", "readonly");
            __builder.AddAttribute(193, "class", "form-control");
            __builder.AddAttribute(194, "id", "wertigkeitTxt");
            __builder.AddAttribute(195, "placeholder", "Wertigkeit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 107 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
 if (FullTrack != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(196, "div");
            __builder.AddAttribute(197, "class", "row");
#nullable restore
#line 110 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
         foreach (var img in Bilder.Where(img => img != null))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(198, "div");
            __builder.AddAttribute(199, "class", "col justify-content-center");
            __builder.AddAttribute(200, "style", "display: flex;");
            __builder.OpenElement(201, "img");
            __builder.AddAttribute(202, "src", 
#nullable restore
#line 113 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                           img.Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(203, "style", "max-height: 200px;");
            __builder.AddAttribute(204, "alt", "Bild");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 115 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 117 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
 if (Artists.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(205, "<h2 style=\"margin-top: 15px;\">Künstler</h2>\r\n    ");
            __builder.OpenElement(206, "table");
            __builder.AddAttribute(207, "class", "table table-hover table-dark");
            __builder.AddMarkupContent(208, @"<thead><tr><th scope=""col""></th>
                <th scope=""col"">Id</th>
                <th scope=""col"">Links</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Popularität</th>
                <th scope=""col"">Follower</th></tr></thead>
        ");
            __builder.OpenElement(209, "tbody");
#nullable restore
#line 133 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
             foreach (var artist in Artists)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(210, "tr");
            __builder.OpenElement(211, "td");
            __builder.OpenElement(212, "img");
            __builder.AddAttribute(213, "src", 
#nullable restore
#line 136 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                                   artist.Images.FirstOrDefault()?.Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(214, "alt", "Avatar");
            __builder.AddAttribute(215, "height", "35");
            __builder.AddAttribute(216, "width", "35");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(217, "\r\n                    ");
            __builder.OpenElement(218, "td");
            __builder.AddContent(219, 
#nullable restore
#line 137 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                         artist.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\r\n                    ");
            __builder.OpenElement(221, "td");
#nullable restore
#line 139 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                         foreach (var link in artist.ExternalUrls)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(222, "a");
            __builder.AddAttribute(223, "href", 
#nullable restore
#line 140 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                                   link.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(224, 
#nullable restore
#line 140 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                                                link.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 140 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                                                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(225, "\r\n                ");
            __builder.OpenElement(226, "td");
            __builder.AddContent(227, 
#nullable restore
#line 142 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                     artist.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(228, "\r\n                ");
            __builder.OpenElement(229, "td");
            __builder.AddContent(230, 
#nullable restore
#line 143 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                     artist.Popularity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(231, " von 100");
            __builder.CloseElement();
            __builder.AddMarkupContent(232, "\r\n                ");
            __builder.OpenElement(233, "td");
            __builder.AddContent(234, 
#nullable restore
#line 144 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
                     artist.Followers.Total.ToString("N0")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 146 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 149 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 153 "C:\Users\janzi\source\repos\SpotifyHelper\SpotifyHelper\Pages\Songs.razor"
       

    [ParameterAttribute]
    public string SongId { get; set; }

    public string ErgebnisJson { get; set; }
    public string Genres { get; set; }
    public FullTrack FullTrack { get; set; }
    public List<Image> Bilder { get; set; } = new();
    public List<FullArtist> Artists { get; set; } = new();
    public TrackAudioFeatures SongFeatures { get; set; }


    protected override void OnParametersSet()
    {
        if (string.IsNullOrEmpty(SongId)) return;
        if (SongId.Length > 22)
        {
            SongId = SongId.Replace("https://open.spotify.com/track/", "").Substring(0, 22);
        }
        RufeInformationenFürSongAb();
    }

    private async void RufeInformationenFürSongAb()
    {
        try
        {
            if (SongId?.Length > 22)
            {
                SongId = SongId.Replace("https://open.spotify.com/track/", "").Substring(0, 22);
            }

            FullTrack = await Spotify.Tracks.Get(SongId);
            SongFeatures = await Spotify.Tracks.GetAudioFeatures(SongId);

            Bilder.Clear();

            Bilder.Add(FullTrack.Album.Images.FirstOrDefault());
            ErgebnisJson = FullTrack.Stringify();
            var artistsIds = FullTrack.Artists.Select(a => a.Id);
            Artists = Spotify.Artists.GetSeveral(new ArtistsRequest(artistsIds.ToList())).Result.Artists;
            Bilder.AddRange(Artists.Select(a => a.Images.FirstOrDefault()));
            var genres = Artists.SelectMany(a => a.Genres);
            Genres = string.Join(",", genres.Distinct());
        }
        catch (Exception e)
        {
            ErgebnisJson = e.Message;
        }
        StateHasChanged();
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SpotifyClient Spotify { get; set; }
    }
}
#pragma warning restore 1591
