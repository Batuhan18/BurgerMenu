$(document).ready(function () {
    $('#card-number').on('input', function () {
        let cardNumber = $(this).val();
        $('.card-number').text(cardNumber || '#### #### #### ####');
    });

    $('#card-holder').on('input', function () {
        let cardHolder = $(this).val();
        $('.card-holder').text(cardHolder || 'AD SOYAD');
    });

    $('#exp-month, #exp-year').on('input', function () {
        let month = $('#exp-month').val();
        let year = $('#exp-year').val();
        $('.card-expiration').text((month && year) ? month + ' / ' + year : 'MM / YY');
    });

    $('#cvc').on('input', function () {
        let cvc = $(this).val();
        $('.card-cvc').text(cvc || '###');
    });
});
