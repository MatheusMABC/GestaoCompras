$(document).ready(function () {
    $("#TipoPessoa").val(1);
    $('#TipoPessoa').prop('disabled', true);

    $("#Cnpj").mask("99.999.999/9999-99");
    $("#CapitalSocial").mask("####0,00");
    $("#ValorCota").mask("####0,00");
    $("#QuantidadeQuota").mask("####0,00");
    $("#CaracterizacaoCapital").mask("####0,00");


    $("#DataUltimaAtualizacao").prop('disabled', true);
    if ($("#Situacao").val() == 1 ) {
        $('#salvar').prop('disabled', true);

    }
});