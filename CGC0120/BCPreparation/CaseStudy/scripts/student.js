var student = {} || student;

student.drawTable = function(){
    $.ajax({
        url: "http://localhost:3000/students",
        method: "GET",
        dataType : "JSON",
        success : function(data){
            $.each(data, function(i, v){
                $('#tbStudents tbody').append(
                    "<tr>"+
                        "<td>"+ v.id +"</td>" +
                        "<td>" + v.fullName +"</td>" +
                        "<td>"+ v.gender +"</td>" +
                        "<td>"+ v.dob +"</td>" +
                        "<td>"+
                            // "<a href='javascript:void(0);' class='btn btn-warning'>Edit</a> " +
                            // "<a href='javascript:void(0);' class='btn btn-danger'>Remove</a> " +
                            "<a href='javascript:void(0);' title='edit student'><i class='fa fa-edit'></i></a> " +
                            "<a href='javascript:void(0);' title='remove student'><i class='fa fa-trash'></i></a> " +
                            "<a href='javascript:void(0);' title='send email notify'><i class='fa fa-envelope'></i></a> " +
                            "<a href='javascript:void(0);' title='block student'><i class='fa fa-ban'></i></a> " +
                        "</td>" +
                    "</tr>"
                );
            });
        }
    });
}

student.openModal = function(){
    $('#addEditStudent').modal('show');
}

student.init = function(){
    student.drawTable();
}

$(document).ready(function(){
    student.init();
});