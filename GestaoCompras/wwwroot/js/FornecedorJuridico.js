$(document).ready(function () {
    $("#TipoPessoa").val(1);
    $('#TipoPessoa').prop('disabled', true);
    $("#DataUltimaAtualizacao").prop('disabled', true);

    if ($("#Id").val() != undefined) {
        if ($("#Situacao").val() == 1 || $("#Situacao").val() == 0) {
            $('#salvar').prop('disabled', true);

        }
    }
    if ($("#Id").val() == undefined) {
        $("#Situacao").val(2);

    }
    $("#CapitalSocial").val() == '' ? $("#CapitalSocial").val(0.00) : $("#CapitalSocial").val();
});