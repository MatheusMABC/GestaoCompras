(document).ready(function () {

    mask();

  
});

function mask() {

    if ($('.decimal')[0]) {

        $.each($('.decimal'), function (i, e) {

            var valor = $(this).val().replace(',', '.').split('.');

            if (valor[1] != undefined) {

                valor = valor[0] + ',' + valor[1].padEnd(2, '0');

                $(this).val(valor);
            }

        });

        $('.decimal').mask("##0,00", { reverse: true });
    }
}
