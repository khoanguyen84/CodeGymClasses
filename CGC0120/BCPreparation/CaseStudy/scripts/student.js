var student = {} || student;

student.drawTable = function(){
    $.ajax({
        url: "http://localhost:3000/students",
        method: "GET",
        dataType : "JSON",
        success : function(data){
            $('#tbStudents tbody').empty();
            $.each(data, function(i, v){
                $('#tbStudents tbody').append(
                    "<tr>"+
                        "<td>"+ v.id +"</td>" +
                        "<td>" + v.fullName +"</td>" +
                        "<td>"+ v.gender +"</td>" +
                        "<td>"+ v.dob +"</td>" +
                        "<td>"+
                            "<a href='javascript:void(0);' title='edit student' onclick='student.get("+ v.id +")'><i class='fa fa-edit'></i></a> " +
                            "<a href='javascript:void(0);' title='remove student' onclick='student.delete("+ v.id +")'><i class='fa fa-trash'></i></a> " +
                            // "<a href='javascript:void(0);' title='send email notify'><i class='fa fa-envelope'></i></a> " +
                            // "<a href='javascript:void(0);' title='block student'><i class='fa fa-ban'></i></a> " +
                        "</td>" +
                    "</tr>"
                );
            });
        }
    });
}

student.openModal = function(){
    student.reset();
    $('#addEditStudent').modal('show');
}

//add/update student
student.save = function(){
    if($('#formAddEditStudent').valid()){
        var addObj = {};
        addObj.fullName = $('#FullName').val();
        addObj.gender = $("#Gender option:selected" ).text();;
        addObj.dob = $('#DOB').val();

        $.ajax({
            url: "http://localhost:3000/students",
            method : "POST",
            data : JSON.stringify(addObj),
            dataType: "JSON",
            contentType: "application/json",
            success : function(data){
                $('#addEditStudent').modal('hide');
                bootbox.alert("Student has been added successfully!");
                student.drawTable();
            }
        });
    }
}

student.reset = function(){
    $('#FullName').val('');
    $("#Gender").val(1);
    $('#DOB').val('');
}

student.get = function(id){
    $.ajax({
        url : "http://localhost:3000/students/" + id,
        method : "GET",
        contentType : "JSON",
        success : function(data){
            $("#FullName").val(data.fullName);
            $("#Gender").text(data.gender);
            $("#DOB").val(data.dob);

            $('#addEditStudent').modal('show');
        }
    });
}
student.delete = function(id){
    bootbox.confirm({
        title: "Remove student?",
        message: "Do you want to remove the student now?",
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
                    url: "http://localhost:3000/students/" + id,
                    method : "DELETE",
                    contentType : "JSON",
                    success : function(data){
                        bootbox.alert("Student has been removed successfully!");
                        student.drawTable();
                    }
                });
            }
        }
    });
}

student.init = function(){
    student.drawTable();
}

$(document).ready(function(){
    student.init();
});