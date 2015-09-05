function InsertDetails() {
    var emailId = $('#email').val();
    var firstName = $('#txtFirstName').val();
    var lastName = $('#txtLastName').val();
    var streetName = $('#txtStreetName').val();
    var zipcode = $('#txtZipcode').val();
    var city = $('#txtCity').val();
    var state = $('#ddlState option:selected').text();
    var stateId = $('#ddlState option:selected').val();
    var dob = $('#dateDob').val();  
    

    if (!(/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test($('#email').val()))) {
        alert("You have either entered an invalid email address or its empty!");
        return false;
    }  

    else if (firstName == "") {
        alert("Enter firstName");
        return false;
    }
    else if (streetName == "") {
        alert("Enter StreetName");
        return false;
    }
    else if ((zipcode < 100000) || (zipcode > 999999)) {
        alert("Enter a valid Zipcode");
        return false;
    }
    else if (city == "") {
        alert("Enter city");
        return false;
    }
    else if ((state == "select")) {
        alert("Select location");
        return false;
    }
    else if (dob == "") {
        alert("Enter Date of Birth");
        return false;
    }
    

    //Insert Details
    $.ajax({
        type: 'Post',
        url: '../CustomerDetails/ToState',
        data: {
            "email": emailId,
            'strFirstName': firstName,
            'strLastName': lastName,
            'streetName': streetName,
            'numZipcode': zipcode,
            'strCity': city,
            'strState': state,
            'numStateId': stateId,
            'dobirth': dob           
            
        },
        success: function (data) {
            alert(data);
            ShowNextScreen();
        }
    });
}

function ShowNextScreen() {
    //alert("Next Screen here");
    //document.getElementById("service").style.display = 'block';
}