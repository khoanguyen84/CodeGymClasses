var employee = {} || employee;

employee.showData = function () {
    $.ajax({
        url: "http://localhost:3000/users",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#tbUser tbody').empty();
            $.each(data, function (i, v) {
                $('#tbUser tbody').append(
                    `
                    <tr>
                        <td>${v.UserName}</td>
                        <td>${v.DOB}</td>
                        <td>${v.UserMobile}</td>
                        <td>${v.UserEmail}</td>
                        <td>${v.FaceBookUrl}</td>
                        <td>
                            <a href="javascript:;" onclick="employee.getDetail(${v.id})"><i class="fa fa-edit"></i></a>
                            <a href="javascript:;" onclick="employee.remove(${v.id})"><i class="fa fa-trash"></i></a>
                        </td>
                    </tr>
                    `
                );
            });
            $('#tbUser').DataTable();
        }
    });
}

employee.showModal = function () {
    employee.resetForm();
    $('#addEditUser').modal('show');
};

employee.initCountry = function () {
    $.ajax({
        url: "http://localhost:3000/country",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $.each(data, function (i, v) {
                $('#Country').append(
                    `
                    <option value="${v.Name}">${v.Name}</option>
                    `
                );
            });
        }
    });
}

employee.remove = function (id) {
    bootbox.confirm({
        title: "Remove employee?",
        message: "Do you want to remove the employee now",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> No'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Yes'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: "http://localhost:3000/users/" + id,
                    method: "DELETE",
                    dataType: "json",
                    contentType: 'application/json',
                    success: function (data) {
                        employee.showData();
                        bootbox.alert("Remove successfully");
                    }
                });
            }
        }
    });
}

employee.getDetail = function (id) {
    $.ajax({
        url: "http://localhost:3000/users/" + id,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#UserName').val(data.UserName);
            $('#DOB').val(data.DOB);
            $('#UserMobile').val(data.UserMobile);
            $('#UserEmail').val(data.UserEmail);
            $('#FaceBookUrl').val(data.FaceBookUrl);
            $('#EmployeeId').val(data.id);
            $('#Country').val(data.Country);
            $('#addEditUser').find('.modal-title').text("Update User");
            $('.modal-footer').find('a').text('Update');

            $('#addEditUser').modal('show');
        }
    });
}

employee.save = function () {
    if ($('#frmAddEditUser').valid()) {
        //create
        if ($('#EmployeeId').val() == 0) {
            var objAdd = {};
            objAdd.UserName = $('#UserName').val();
            objAdd.DOB = $('#DOB').val();
            objAdd.UserMobile = $('#UserMobile').val();
            objAdd.UserEmail = $('#UserEmail').val();
            objAdd.FaceBookUrl = $('#FaceBookUrl').val();
            objAdd.Country = $('#Country').val();

            $.ajax({
                url: "http://localhost:3000/users/",
                method: "POST",
                dataType: "json",
                contentType: 'application/json',
                data: JSON.stringify(objAdd),
                success: function (data) {
                    bootbox.alert("User has been created successfully");
                    $('#addEditUser').modal('hide');
                    employee.showData();
                }
            });
        }
        //update
        else {
            var objEdit = {};
            objEdit.UserName = $('#UserName').val();
            objEdit.DOB = $('#DOB').val();
            objEdit.UserMobile = $('#UserMobile').val();
            objEdit.UserEmail = $('#UserEmail').val();
            objEdit.FaceBookUrl = $('#FaceBookUrl').val();
            objEdit.id = $('#EmployeeId').val();
            objEdit.Country = $('#Country').val();

            $.ajax({
                url: "http://localhost:3000/users/" + objEdit.id,
                method: "PUT",
                dataType: "json",
                contentType: 'application/json',
                data: JSON.stringify(objEdit),
                success: function (data) {
                    bootbox.alert("User has been updated successfully");
                    $('#addEditUser').modal('hide');
                    employee.showData();
                }
            });
        }
        
    }
}

employee.resetForm = function () {
    $('#UserName').val("");
    $('#DOB').val("");
    $('#UserMobile').val("");
    $('#UserEmail').val("");
    $('#FaceBookUrl').val("");
    $('#EmployeeId').val("0");
    $('#addEditUser').find('.modal-title').text("Create New User");
    $('.modal-footer').find('a').text('Create');

    var form = $('#frmAddEditUser').validate();
    form.resetForm();
}

employee.init = function () {
    employee.showData();
    employee.initCountry();
}

$(document).ready(function () {
    employee.init();
});