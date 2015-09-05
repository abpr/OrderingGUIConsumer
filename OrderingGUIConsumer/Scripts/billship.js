$(document).ready(function () {
    $('input:checkbox[id*=chkbox]').change(function () {
        if ($(this).is(':checked')) {
            $('input:text[id*=sfirst_name]').val($('input:text[id*=bfirst_name]').val());
            $('input:text[id*=slast_name]').val($('input:text[id*=blast_name]').val());
            $('input:text[id*=sstreet]').val($('input:text[id*=bstreet]').val());
            $('input:text[id*=szip]').val($('input:text[id*=bzip]').val());
            $('input:text[id*=scity]').val($('input:text[id*=bcity]').val());
            $('input:text[id*=sstate]').val($('input:text[id*=bstate]').val());
            $('input:text[id*=sstateid]').val($('input:text[id*=bstateid]').val());
            $('input:text[id*=scountry]').val($('input:text[id*=bcountry]').val());
            $('input:text[id*=sdob]').val($('input:text[id*=bdob]').val());
            
        }
        else {
            $('input:text[id*=sfirst_name]').val('');
            $('input:text[id*=slast_name]').val('');
            $('input:text[id*=sstreet]').val('');
            $('input:text[id*=szip]').val('');
            $('input:text[id*=scity]').val('');
            $('input:text[id*=sstate]').val('');
            $('input:text[id*=sstateid]').val('');
            $('input:text[id*=scountry]').val('');
            $('input:text[id*=sdob]').val('');
        }
    });
});
