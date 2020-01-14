let str="";
for(let i =0 ; i<5 ;i++){
    str = str + "<tr>"+
        "<td>"+ (i+1) +"</td>" +
        "<td>Nguyễn"+ (i+1) +"</td>" +
        "<td>Khoa"+ (i+1) +"</td>" +
        "<td>01/01/2000</td>" +
        "<td>TT Huế</td>" +
    "</tr>";
}
document.getElementById("tbStudent").innerHTML = str;