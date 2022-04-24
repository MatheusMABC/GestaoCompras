$(document).ready(function () {
    $("#TipoPessoa").val(1);
    $('#TipoPessoa').prop('disabled', true);

    $("#DataUltimaAtualizacao").prop('disabled', true);
    if ($("#Situacao").val() == 1) {
        $('#salvar').prop('disabled', true);

    }
});