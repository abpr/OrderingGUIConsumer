$(document).on('click', ".btn", (function () {
    //   alert("Test");
    //var date1 = document.getElementById("<%= btnmonth.ClientID %>").value;
    //var date2 = document.getElementById("<%= btnDay.ClientID %>").value;
    //var date3 = document.getElementById("<%= btnyear.ClientID %>").value;
    //dates = [date1 + '/' + date2 + '/' + date3];
    //alert(dates);
    //var dates4 = [$('#id4').text()];
    //tips are optional but good to have
    var tips = ['some description', 'some other description'];
    $("#inputField").datepicker("refresh");
    $("#inputField").datepicker({

        //gotoCurrent: true,
        //defaultDate: new Date(2015, 07, 23, 00, 00, 00, 00),
        //maxDate: new Date(2015, 08, 22, 00, 00, 00, 00),
        //minDate: new Date(2015, 07, 21, 00, 00, 00, 00),
        minDate: 'today',
        //maxDate: '+1M',
        beforeShowDay: function (date) {
            loadDates();
            if (new Date(dates).toString() == date.toString()) {
                //alert(dates);
                return [true, 'event', tips[0]];

            }
            return [true, ''];
        },
        onSelect: function (dateText) {
            sel = dateText;
            //alert(sel);
            //var one = sel.substring(3, 5);
            //var two = sel.substring(0, 2);
            //var three = sel.substring(6, 10);
            //alert(one);
            //alert(two);
            //alert(three);
        }

    });
}))
