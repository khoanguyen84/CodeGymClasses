var user = user || {};

user.drawTable = function(){
    $.ajax({
        url:'https://randomuser.me/api',
        method : 'GET',
        dataType : 'json',
        success : function(data){
            var response = data.results;
            $.each(response, function(index, value){
                var name = value.name;
                $('#tbUser').append(
                    "<tr>"+
                        "<td>"+ name.title + ". " + name.first + " " + name.last + "</td>" +
                        "<td>" + value.dob.date + "</td>" +
                        "<td>" +  value.phone + "</td>" +
                        "<td>" +  value.phone + "</td>" +
                        "<td>" +  value.phone + "</td>" +
                        "<td>" +  value.phone + "</td>" +
                        "<td>" +  value.phone + "</td>" +
                        "<td>" + 
                            "<a href='javascript:;'><i class='fa fa-user-edit'></i></a> " +
                            "<a href='javascript:;'><i class='fa fa-check-square fa-lg'></i></a> " +
                            //"<a class='btn btn-primary' href='javascript:;'><i class='fa fa-plus'></i> Create New Event</a>" +
                        "</td>" +
                    "</tr>");
            });
        }
    });
};

user.openAddEditUser = function(){
    $('#addEditUser').modal('show');
};

user.save = function(){
    if($('#frmAddEditUser').valid()){
        
    }
}

user.init = function() {
    user.drawTable();
};


$(document).ready(function(){
    user.init();
});