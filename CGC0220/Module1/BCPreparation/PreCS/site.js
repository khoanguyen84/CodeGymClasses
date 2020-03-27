var product = product || {};

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

$(document).ready(function(){

});