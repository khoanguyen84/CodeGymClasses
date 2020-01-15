var student = {} || student;

student.drawTable = function(){
    $.ajax({
        url : "http://localhost:3000/Students",
        method : "GET",
        dataType : "json",
        success : function(data){
            $('#tbStudent').empty();
            $.each(data, function(i, v){
                $('#tbStudent').append(
                    "<tr>"+
                        "<td>"+ v.id +"</td>"+
                        "<td>" + v.FullName + "</td>"+
                        "<td><img src='"+ v.Avatar +"' width='50px' height='60px' /></td>"+
                        "<td>"+ v.DOB +"</td>"+
                        "<td></td>"+
                    "</tr>"
                );
            });
        }
    });
};

student.openModal = function(){
    $('#addEditStudent').modal('show');
};

student.save = function(){
    if($('#formAddEditStudent').valid()){
        var studentObj = {};
        studentObj.FullName = $('#FullName').val();
        studentObj.Avatar = $('#Avatar').val();
        studentObj.DOB = $('#DOB').val();

        $.ajax({
            url : "http://localhost:3000/Students",
            method : "POST",
            dataType : "json",
            contentType : "application/json",
            data : JSON.stringify(studentObj),
            success : function(data){
                $('#addEditStudent').modal('hide');
                student.drawTable();
            }
        });
    }
};

student.init = function(){
    student.drawTable();
};

$(document).ready(function(){
    student.init();
});