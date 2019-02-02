function init() {


    // Дождёмся загрузки API и готовности DOM.
    ymaps.ready(initInner);

    function initInner() {

        // Создание экземпляра карты и его привязка к контейнеру с
        // заданным id ("map").
        var myMap = new ymaps.Map('map', {
            // При инициализации карты обязательно нужно указать
            // её центр и коэффициент масштабирования.
            center: [55.76, 37.64], // Москва
            zoom: 10
        }, {
                searchControlProvider: 'yandex#search'
            });


    }
}