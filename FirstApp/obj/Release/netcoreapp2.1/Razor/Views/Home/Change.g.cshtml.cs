#pragma checksum "C:\Users\Администратор.000\source\repos\FirstApp\FirstApp\Views\Home\Change.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b77b6bf703e46c475531b9e802e8048d5a3cd3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Change), @"mvc.1.0.view", @"/Views/Home/Change.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Change.cshtml", typeof(AspNetCore.Views_Home_Change))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Администратор.000\source\repos\FirstApp\FirstApp\Views\_ViewImports.cshtml"
using FirstApp;

#line default
#line hidden
#line 2 "C:\Users\Администратор.000\source\repos\FirstApp\FirstApp\Views\_ViewImports.cshtml"
using FirstApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b77b6bf703e46c475531b9e802e8048d5a3cd3c", @"/Views/Home/Change.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b951a5d3431184d260cd5fa679540aa680aa4c0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Change : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Администратор.000\source\repos\FirstApp\FirstApp\Views\Home\Change.cshtml"
  
    ViewData["Title"] = "Изменение данных";

#line default
#line hidden
            BeginContext(52, 41, true);
            WriteLiteral("\r\n\r\n\r\n<h2>Внесите изменения:</h2>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(93, 1800, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a91d97d2cf74f5780ca70118be5ce6f", async() => {
                BeginContext(149, 26, true);
                WriteLiteral("\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 175, "\"", 201, 1);
#line 12 "C:\Users\Администратор.000\source\repos\FirstApp\FirstApp\Views\Home\Change.cshtml"
WriteAttributeValue("", 183, ViewBag.PersonaID, 183, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(202, 1684, true);
                WriteLiteral(@" name=""PersonaID"" />

    <div class=""form-group"">
        <label for=""FirstName"" class=""col-md-2 control-label"">Имя:</label>
        <div class=""col-md-4"">
            <input type=""text"" name=""FirstName"" class=""form-control"" />
        </div>
    </div>
    <div class=""form-group"">
        <label for=""LastName"" class=""col-md-2 control-label"">Фамилия:</label>
        <div class=""col-md-4"">
            <input type=""text"" name=""LastName"" class=""form-control"" />
        </div>
    </div>
    <div class=""form-group"">
        <label for=""FatherName"" class=""col-md-2 control-label"">Отчество:</label>
        <div class=""col-md-4"">
            <input type=""text"" name=""FatherName"" class=""form-control"" />
        </div>
    </div>
    <div class=""form-group"">
        <label for=""Phone"" class=""col-md-2 control-label"">Телефон:</label>
        <div class=""col-md-4"">
            <input type=""number"" name=""Phone"" class=""form-control"" />
        </div>
    </div>
    <div class=""form-group"">
       ");
                WriteLiteral(@" <label for=""Sex"" class=""col-md-2 control-label"">Пол:</label>
        <div class=""col-md-4"">
            <input type=""text"" name=""Sex"" class=""form-control"" />
        </div>
    </div>
    <div class=""form-group"">
        <label for=""Country"" class=""col-md-2 control-label"">Адрес:</label>
        <div class=""col-md-4"">
            <input type=""text"" name=""Country"" class=""form-control"" id=""addCountry"" value=""""/>
            
        </div>

    </div>
    <div class=""form-group"">
        <div class=""col-md-offset-2 col-md-10"">
            <input type=""submit"" class=""btn btn-default"" value=""Внести изменения"" />
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1893, 4044, true);
            WriteLiteral(@"
<script src=""https://api-maps.yandex.ru/2.1/?lang=ru_RU&amp;apikey=<afaba825-23a8-4fd8-b63a-c1ad9e840bf8>"" type=""text/javascript""></script>
<div class=""form-group"">
    <button onclick=""init()"">Указать на карте</button>
    <div id=""map"" style=""width: 600px; height: 400px""></div>
    <script type=""text/javascript"">
        function init() {
           
                ymaps.ready(innerInit);

                function innerInit() {
                    input = document.getElementById('addCountry'); // позволяет вывести данные в поле input с id = addCountry

                    var myPlacemark,

                        myMap = new ymaps.Map('map', {
                            center: [55.753994, 37.622093],
                            zoom: 9
                        }, {
                                searchControlProvider: 'yandex#search'
                            });

                    // Слушаем клик на карте.
                    myMap.events.add('click', function (e) {
        ");
            WriteLiteral(@"                var coords = e.get('coords');

                        // Если метка уже создана – просто передвигаем ее.
                        if (myPlacemark) {
                            myPlacemark.geometry.setCoordinates(coords);
                        }
                        // Если нет – создаем.
                        else {
                            myPlacemark = createPlacemark(coords);
                            myMap.geoObjects.add(myPlacemark);
                            // Слушаем событие окончания перетаскивания на метке.
                            myPlacemark.events.add('dragend', function () {
                                getAddress(myPlacemark.geometry.getCoordinates());
                            });
                        }
                        getAddress(coords);

                    });
                    // Создание метки.
                    function createPlacemark(coords) {
                        return new ymaps.Placemark(coords, {
        ");
            WriteLiteral(@"                    iconCaption: 'поиск...'
                        }, {
                                preset: 'islands#violetDotIconWithCaption',
                                draggable: true
                            });
                    }
                    // Определяем адрес по координатам (обратное геокодирование).
                    function getAddress(coords) {

                        myPlacemark.properties.set('iconCaption', 'поиск...');
                        // вывод адресса в input
                        ymaps.geocode(coords).then(function (res) {
                            var firstGeoObject = res.geoObjects.get(0);

                            myPlacemark.properties
                                .set({
                                    // Формируем строку с данными об объекте.
                                    iconCaption: [
                                        // Название населенного пункта или вышестоящее административно-территориальное образование.
 ");
            WriteLiteral(@"                                       firstGeoObject.getLocalities().length ? firstGeoObject.getLocalities() : firstGeoObject.getAdministrativeAreas(),
                                        // Получаем путь до топонима, если метод вернул null, запрашиваем наименование здания.
                                        firstGeoObject.getThoroughfare() || firstGeoObject.getPremise()
                                    ].filter(Boolean).join(', '),
                                    // В качестве контента балуна задаем строку с адресом объекта.
                                    balloonContent: firstGeoObject.getAddressLine()
                                });
                            //добавляем данные об месте на карте в наш input
                            addCountry.value = firstGeoObject.getAddressLine();
                        });


                    }

                }
            
        }
        
    </script>
</div>

");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
