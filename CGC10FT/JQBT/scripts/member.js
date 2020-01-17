var member = {} || member;

member.drawTable = function(){
    $.ajax({
        url : "http://localhost:3000/members",
        method : "GET",
        dataType : "json",
        success : function(data){
            $('#tbMembers tbody').empty();
            $.each(data, function(i, v){
                $('#tbMembers tbody').append(
                    "<tr>"+
                        "<td>"+ v.id +"</td>" +
                        "<td>"+ v.FullName +"</td>" +
                        "<td><img src='"+ v.Avatar +"' width='50px' height='60px'></td>" +
                        "<td>"+ v.DOB +"</td>" +
                        "<td>"+ v.Address +"</td>" +
                        "<td>" +
                            "<a href='javascript:;' title='edit member' onclick='member.getDetail("+ v.id +")'><i class='fa fa-edit'></i></a> " +
                            "<a href='javascript:;' title='remove member' onclick='member.delete("+ v.id +")' ><i class='fa fa-trash'></i></a>" +
                        "</td>" +
                    "</tr>"
                );
            });
            $('#tbMembers').DataTable();
        }
    });
};

member.openModal = function(){
    member.reset();
    $('#addEditMember').modal('show');
};

member.save = function(){
    if($('#formAddEditMember').valid()){
        if($('#id').val() == 0){
            var memberObj = {};
            memberObj.FullName = $('#FullName').val();
            memberObj.Avatar = $('#Avatar').attr('src');
            memberObj.DOB = $('#DOB').val();
            memberObj.Address = $('#Address').val();
            memberObj.CountryId = $('#Country').val();
    
            $.ajax({
                url : "http://localhost:3000/members",
                method : "POST",
                dataType : "json",
                contentType : 'application/json',
                data : JSON.stringify(memberObj),
                success : function(data){
                    $('#addEditMember').modal('hide');
                    member.drawTable();
                }
            });
        }
        else{
            var memberObj = {};
            memberObj.FullName = $('#FullName').val();
            memberObj.Avatar = $('#Avatar').attr('src');
            memberObj.DOB = $('#DOB').val();
            memberObj.Address = $('#Address').val();
            memberObj.id = $('#id').val();
            memberObj.CountryId = $('#Country').val();
    
            $.ajax({
                url : "http://localhost:3000/members/" + memberObj.id,
                method : "PUT",
                dataType : "json",
                contentType : 'application/json',
                data : JSON.stringify(memberObj),
                success : function(data){
                    $('#addEditMember').modal('hide');
                    member.drawTable();
                }
            });
        }
        

    }
};

member.delete = function(id){
    bootbox.confirm({
        title: "Remove member?",
        message: "Do you want to remove this member.",
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
                    url : "http://localhost:3000/members/" + id,
                    method : "DELETE",
                    dataType : "json",
                    contentType : 'application/json',
                    success : function(data){
                        member.drawTable();
                    }
                });
            }
        }
    });
};

member.getDetail = function(id){
    $.ajax({
        url : "http://localhost:3000/members/" + id,
        method : "GET",
        dataType : "json",
        success : function(data){
            $('#FullName').val(data.FullName);
            $('#Avatar').attr('src',data.Avatar);
            $('#DOB').val(data.DOB);
            $('#Address').val(data.Address);
            $('#id').val(data.id);

            $('#addEditMember').modal('show');
        }
    });
};

member.reset = function(){
    $('#FullName').val('');
    $('#Avatar').val('');
    $('#DOB').val('');
    $('#Address').val('');
    $('#id').val(0);
};

member.uploadAvatar = function(input){
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#Avatar').attr('src', e.target.result);
            console.log(e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
}

member.init = function(){
    member.drawTable();
};

$(document).ready(function(){
    member.init();
});