function ValidateUser() {

    var obj = new OrderForm();
    var JsonObj = JSON.stringify(obj);
    alert(JsonObj);

    var error = "";
    var flag = 0;
    var stripped = $('#mobile').val().replace(/[\(\)\.\-\ ]/g, '');
    var selectdate = $('#inputField').val().toString();
    var d = new Date(selectdate);
    var current = new Date();
    var retryCount = 2;
    var start = 1;
    
   
        //if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test($('#email').val())) {
        //    flag = flag + 1;
        //}
        //else {

        //    alert("You have either entered an invalid email address or its empty!");
        //}


        if (stripped == "") {
            alert("You didn't enter a phone number.");
        } else if (isNaN(parseInt(stripped))) {
            
            alert("The phone number contains illegal characters.");

        } else if (!(stripped.length == 10)) {
            
            alert("The phone number is the wrong length. Make sure your contact has 10 digits excluding 0 \n");
        }
        else
            flag = flag + 1;
        if (d < current)
            alert("Date selected should be after Today");
        else
            flag = flag + 1;
    
    var email = $('#email').val();
    var phone = $('#mobile').val();
    var bfname = $('#bfirst_name').val();
    var blname = $('#blast_name').val();
    var bstr = $('#bstreet').val();
    var bzip = $('#bzip').val();
    var bcity = $('#bcity').val();
    var bstate = $('#bstate').val();
    var bstateid = $('#bstateid').val();
    var bcountry = $('#bcountry').val();
    var bdob = $('#bdob').val();
    var sfname = $('#sfirst_name').val();
    var slname = $('#slast_name').val();
    var sstr = $('#sstreet').val();
    var szip = $('#szip').val();
    var scity = $('#scity').val();
    var sstate = $('#sstate').val();
    var sstateid = $('#sstateid').val();
    var scountry = $('#scountry').val();
    var sdob = $('#sdob').val();
    var date = $('#inputField').val();
    if (flag == 2) {
        $.ajax({
            type: 'POST',
            //url: 'http://192.168.1.19:8080/OrderManagement/rest/om/submitorder',
            
            url: '../SendOrder/Send',
            data: {
                'json': JsonObj
            },
            success: function (data) {
                alert(data);
            },
            //crossDomain: true,
            //contentType: 'json',
            //data: { JsonObj },
            //success: function () {
            //    alert('ok');
            //},
            error:
                function () {
                    alert('order submission error');
                },
        });
        ////validate user
        setTimeout(SubmitOrder, 2000);
        alert("Wait for 5 seconds");
            function SubmitOrder() {
            $.ajax({
                type: 'POST',
                url: '../Portal/Index1',
                data: {
                    'email': email,
                    'mobile': phone,
                    'bfname': bfname,
                    'blname': blname,
                    'bstr': bstr,
                    'bzip': bzip,
                    'bcity': bcity,
                    'bstate': bstate,
                    'bstateid': bstateid,
                    'bcountry': bcountry,
                    'bdob': bdob,
                    'sfname': sfname,
                    'slname': slname,
                    'sstr': sstr,
                    'szip': szip,
                    'scity': scity,
                    'sstate': sstate,
                    'sstateid': sstateid,
                    'scountry': scountry,
                    'sdob': sdob,
                    'duedate': date
                },
                success: function (data) {
                    //alert(data);
                }
            });
     }
       
     }
}

