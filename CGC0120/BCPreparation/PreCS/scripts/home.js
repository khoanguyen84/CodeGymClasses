var home = {} || home;
var slideIndex = 0;

home.load = function(){
    $.ajax({
        url:'https://precs0102db.herokuapp.com/films',
        method : 'GET',
        dataType : 'json',
        success : function(data){
            $('#main').empty();
            $.each(data, function(index, value){
                $('#main').append(
                    '<div class="col-lg-3 col-md-6 mb-4">' +
                        '<div class="card h-100">'+
                            '<img class="card-img-top" src="'+ value.poster +'" alt="'+ value.title +'">'+
                            '<div class="card-body">'+
                                '<h4 class="card-title">'+ value.title +'</h4>'+
                                '<p class="card-text">'+ value.shortDesc +'</p>'+
                            '</div>' +
                            '<div class="card-footer">'+
                                '<a href="#" class="btn btn-primary">Detail</a>'+
                            '</div>'+
                        '</div>'+
                    '</div>');
            });
        }
    });
}

home.init = function(){
    home.load();
}

$(document).ready(function(){
    home.init();
});