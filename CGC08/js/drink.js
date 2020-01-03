var drink = drink || {};


drink.changeDrink = function(el){
    var element = $('#drink').find(':selected');
    $('#price').val(element.data('price') + " " + element.data('currency'));
}

drink.init = function() {
};


$(document).ready(function(){
    drink.init();
    drink.changeDrink();
});