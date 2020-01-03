var user = user || {};

user.drawTable = function(){
    $.ajax({
        url:'https://randomuser.me/api',
        method : 'GET',
        dataType : 'json',
        success : function(data){
            var response = data.results;
            $.each(response, function(index, value){
                $('#tbUser').append(
                    "<tr>"+
                        "<td>"+ value.userName + "</td>" +
                        "<td>" + value.dob + "</td>" +
                        "<td>" +  value.userMobile + "</td>" +
                        "<td>" + 
                            "<a href='javascript:;'><i class='fa fa-user-edit'></i></a> " +
                            "<a href='javascript:;'><i class='fa fa-check-square fa-lg'></i></a> " +
                            "<a class='btn btn-primary' href='javascript:;'><i class='fa fa-plus'></i> Create New Event</a>" +
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