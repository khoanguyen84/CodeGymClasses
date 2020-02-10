var product = product || {}

product.drawTable = function(){
    $.ajax({
        url : 'action.php?page=gets',
        dataType : 'json',
        method: 'GET',
        success : function(data){
            $('#tbProduct tbody').empty();
            let i = 0;
            $.each(data, function(i, v){
                $('#tbProduct tbody').append(
                    "<tr>" +
                        "<td> " + (i = i+ 1) + " </td>" +
                        "<td> " + v.productName + " </td>" +
                        "<td> " + v.price + " </td>" +
                        "<td> " + v.description + " </td>" +
                        "<td> " + v.manufactory + " </td>" +
                        "<td>" +
                            "<a href='javascript:void(0);' title='edit product' onclick='product.getDetail("+ v.id +")'><i class='fa fa-edit'></i></a> " +
                            "<a href='javascript:void(0);' title='remove product' onclick='product.delete("+ v.id +")'><i class='fa fa-trash'></i></a>" +
                        "</td>" +
                    "</tr>"
                );
            });
        }
    });
};

product.resetForm = function(){
    $('#ProductId').val(0);
    $('#ProductName').val('');
    $('#Price').val('');
    $('#Description').val('');
    $('#Manufactory').val('');
    $('#addEditProduct modal-title').find('Add Product');
    var validFormProduct = $( "#formProduct" ).validate();
    validFormProduct.resetForm();
};

product.openModel = function(){
    product.resetForm();
    $('#addEditProduct').modal('show');
};

product.save = function(){
    if($('#formProduct').valid()){
        var productObj = {};
        productObj.productId = $('#ProductId').val();
        productObj.productName = $('#ProductName').val();
        productObj.price = $('#Price').val();
        productObj.description = $('#Description').val();
        productObj.manufactory = $('#Manufactory').val();
        data = JSON.stringify(productObj);
        $.ajax({
            url : 'action.php?page=save&data=' + data,
            dataType : 'json',
            method : 'POST',
            contentType : 'application/json',
            success : function(){
                product.drawTable();
                $('#addEditProduct').modal('hide');
            }
        });
    }
};

product.getDetail = function(id){
    $.ajax({
        url : 'action.php?page=get&id=' + id,
        dataType : 'json',
        method: 'GET',
        success : function(data){
            $('#ProductId').val(data.id);
            $('#ProductName').val(data.productName);
            $('#Price').val(data.price);
            $('#Description').val(data.description);
            $('#Manufactory').val(data.manufactory);

            $('#addEditProduct modal-title').find('Modify Product');

            $('#addEditProduct').modal('show');
        }
    });
};

product.delete = function(id){
    bootbox.confirm({
        title: "Remove Product?",
        message: "Do you want to remove this product.",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> No'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Yes'
            }
        },
        callback: function (result) {
            if(result){
                $.ajax({
                    url : 'action.php?page=delete&id=' + id,
                    method : "DELETE",
                    dataType : "json",
                    contentType : 'application/json',
                    success : function(data){
                        product.drawTable();
                    }
                });
            }
        }
    });
};

product.init = function(){
    product.drawTable();
};

$(document).ready(function(){
    product.init();
}); 