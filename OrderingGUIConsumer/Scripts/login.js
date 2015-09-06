function ValidateUser() {
    var userid = $('#txtUserID').val();
    var userpwd = $('#txtPwd').val();
    if (userid == "") {
        alert("Enter User ID");
        return false;
    }
    else if (userpwd == "") {
        alert("Enter Password");
        return false;
    }

    //validate user
    $.ajax({
        type: 'Post',
        url: 'Login/ValidateCredentials',
        data: {

            'strUserID': userid,
            'strPwd': userpwd
        },
        success: function (data) {
            if (data == "Invalid Username or Password")
                alert(data);
            else {
                localStorage.setItem("userid", userid);
                //$(function () {
                //    $.post('/SetSession/SetVariable',
                //           { key: "agentName", value: userid }, function (data) {
                //               alert("Success " + data.success);
                //           });
                //});
            }
            window.location.href = data;
            //$.ajax({
            //    type: 'Post',
            //    url: 'Home/Index',
            //});
        }        
    }); 
}