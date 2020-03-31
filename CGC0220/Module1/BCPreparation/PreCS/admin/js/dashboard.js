var dashboard = dashboard || { }

dashboard.drawTable = function(){
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
                        "<td><img src='../"+ v.productImage +"' width='120px' height='150px'></td>"+
                        "<td>" + v.price +"</td>"+
                        "<td>" + v.manufactory + "</td>"+
                        "<td>" + v.description + "</td>"+
                        "<td>"+
                            "<a href='javascript:;' onclick='dashboard.remove();'><i class='fa fa-edit'></i></a> "+
                            "<a href='javascript:;' onclick='dashboard.remove();'><i class='fa fa-trash'></i></a>"+
                        "</td>"+
                    "</tr>"
                );
            })
        }
    });
}

dashboard.openModal = function(){
    $('#addEditModal').modal('show');
}

dashboard.remove = function(){
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

dashboard.init = function(){
    dashboard.drawTable();
}

$(document).ready(function(){
    dashboard.init();
});