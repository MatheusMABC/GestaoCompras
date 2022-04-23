$(document).ready(function () {
    $("#TipoPessoaFisica").val(1);
    $('#TipoPessoaFisica').prop('disabled', true);
    $("#DataUltimaAtualizacao").prop('disabled', true);
    $("#Cpf").mask('000.000.000-00');


    if ($("#Situacao").val() == 1) {
        $('#salvar').prop('disabled', true);

    }
});