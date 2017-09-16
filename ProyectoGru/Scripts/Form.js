$(document).on('change', '#containerSelect', function () {
    /* Get the selected value of dropdownlist */
    var option = $(this).val();

    /* Request the partial view with .get request. */
    $.get('/Generador/VideoCodecs/' + option, function (data) {
        $('#videoCodecs').html(data);
        $('#videoCodecs').fadeIn('fast');
        console.log("abs");
    });
});

$(document).on('change', '#transcodeSelect', function () {
    /* Get the selected value of dropdownlist */
    var option = $(this).val();

    /* Request the partial view with .get request. */
    $.get('/Generador/Containers/' + option, function (data) {
        $('#containers').html(data);
        $('#containers').fadeIn('fast');
        console.log("buuu");
    });
});