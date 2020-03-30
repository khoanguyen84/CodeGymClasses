var product = product || {};

product.drawTable = function(){
    $.ajax({
        url: "http://localhost:3000/products",
        method: "GET",
        dataType : "json",
        success : function(data){
            $.each(data, function(i, v){
                $('#tbProducts tbody').append(
                    "<tr>"+
                        "<td>" + v.id +"</td>"+ //data[i].id
                        "<td>"+ v.productName +"</td>"+
                        "<td><img src='"+ v.productImage +"' width='120px' height='150px'></td>"+
                        "<td>" + v.price +"</td>"+
                        "<td>" + v.manufactory + "</td>"+
                        "<td>" + v.description + "</td>"+
                        "<td>"+
                            "<a href='javascript:;' onclick='product.remove();'><i class='fa fa-edit'></i></a> "+
                            "<a href='javascript:;' onclick='product.remove();'><i class='fa fa-trash'></i></a>"+
                        "</td>"+
                    "</tr>"
                );
            })
        }
    });
}

product.showProduct = function(){
    $.ajax({
        url: "http://localhost:3000/products",
        method: "GET",
        dataType : "json",
        success : function(data){
            $.each(data, function(i, v){
                $('#showProducts').append(
                    "<div class='col-lg-3 col-md-6 mb-4'>"+
                    "<div class='card h-100'>"+
                      "<img class='card-img-top' src='" + v.productImage +"' alt=''>"+
                      "<div class='card-body'>"+
                        "<h4 class='card-title'>" + v.productName + "</h4>"+
                        "<p class='card-text'> Manufactory: "+ v.manufactory +" Description: " + v.description +"</p>"+
                      "</div>"+
                      "<div class='card-footer'>"+
                        "<a href='#' class='btn btn-primary'> " + v.price +" vnđ </a>"+
                      "</div>"+
                    "</div>"+
                  "</div>"
                );
            })
        }
    });
}

product.openModal = function(){
    $('#addEditModal').modal('show');
}

product.remove = function(){
    bootbox.confirm({
        title: "Remove Product?",
        message: "Do you want to remove this product?",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> No'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Yes'
            }
        },
        callback: function (result) {
            console.log('This was logged in the callback: ' + result);
        }
    });
}

product.init = function(){
    product.drawTable();
    product.showProduct();
}

$(document).ready(function(){
    product.init();
});