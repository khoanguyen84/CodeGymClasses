var user = user || {};

user.drawTable = function(){
    $.ajax({
        url:'http://localhost:3000/users',
        method : 'GET',
        dataType : 'json',
        success : function(data){
            $('#tbUser tbody').empty();
            $.each(data, function(index, value){
                $('#tbUser tbody').append(
                    "<tr>"+
                        "<td>"+ value.UserName + "</td>" +
                        "<td>" + value.DOB + "</td>" +
                        "<td>" +  value.UserMobile + "</td>" +
                        "<td>" +  value.UserEmail + "</td>" +
                        "<td>" +  value.FaceBookUrl + "</td>" +
                        "<td>" + 
                            "<a href='javascript:;' onclick=user.getDetail(" + value.id + ")><i class='fa fa-edit'></i></a> " +
                            "<a href='javascript:;' onclick=user.delete(" + value.id + ")><i class='fa fa-trash'></i></a>" +
                        "</td>" +
                    "</tr>");
            });
            $('#tbUser').DataTable();
        }
    });
};

user.openAddEditUser = function(){
    user.resetForm();
    $('#addEditUser').modal('show');
};

user.save = function(){
    if($('#frmAddEditUser').valid()){
        var userObj = {};
        if($('#Id').val() == 0){
            userObj.UserName = $('#UserName').val();
            userObj.UserMobile = $('#UserMobile').val();
            userObj.DOB = $('#DOB').val();
            userObj.UserEmail = $('#UserEmail').val();
            userObj.FaceBookUrl = $('#FaceBookUrl').val();
            $.ajax({
                url: 'http://localhost:3000/users',
                method: 'POST',
                data: JSON.stringify(userObj),
                dataType: 'json',
                contentType: 'application/json',
                success: function (data) {
                    $('#addEditModel').modal('hide');
                    user.drawTable();
                }
            });
        }else{
            userObj.UserName = $('#UserName').val();
            userObj.UserMobile = $('#UserMobile').val();
            userObj.DOB = $('#DOB').val();
            userObj.UserEmail = $('#UserEmail').val();
            userObj.FaceBookUrl = $('#FaceBookUrl').val();
            userObj.id = $('#Id').val();
            $.ajax({
                url: 'http://localhost:3000/users/' + userObj.id,
                method: 'PUT',
                data: JSON.stringify(userObj),
                dataType: 'json',
                contentType: 'application/json',
                success: function (data) {
                    $('#addEditModel').modal('hide');
                    user.drawTable();
                }
            });
        }
    }
}

user.delete = function (id) {
    bootbox.confirm({
        message: "Are you sure to delete this user?",
        buttons: {
            confirm: {
                label: 'Yes',
                className: 'btn-success'
            },
            cancel: {
                label: 'No',
                className: 'btn-danger'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: 'http://localhost:3000/users/' + id,
                    method: 'DELETE',
                    dataType: 'json',
                    contentType: 'application/json',
                    success: function (data) {
                        user.drawTable();
                    }
                });
            }
        }
    });
};

user.getDetail = function (id) {
    user.resetForm();
    $.ajax({
        url: 'http://localhost:3000/users/' + id,
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            $('#UserName').val(data.UserName);
            $('#DOB').val(data.DOB);
            $('#UserMobile').val(data.UserMobile);
            $('#UserEmail').val(data.UserEmail);
            $('#FaceBookUrl').val(data.FaceBookUrl);
            $('#Id').val(data.id);
            $('#addEditUser').find('.modal-title').text('Update User');
            $('#addEditUser').modal('show');
        }
    });
};

user.resetForm = function () {
    $('#UserName').val('');
    $('#DOB').val('');
    $('#UserMobile').val('');
    $('#UserEmail').val('');
    $('#FaceBookUrl').val('');
    $('#Id').val(0);
    $('#addEditModel').find('.modal-title').text('Create New User');
    $("#frmAddEditUser").validate().resetForm();
};

user.init = function() {
    user.drawTable();
};

$(document).ready(function(){
    user.init();
});
