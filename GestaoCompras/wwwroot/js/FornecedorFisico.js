$(document).ready(function () {
    $("#TipoPessoaFisica").val(1);

    $('#TipoPessoaFisica').prop('disabled', true);
    $("#DataUltimaAtualizacao").prop('disabled', true);

    if ($("#Id").val() != undefined) {
        if ($("#SituacaoFisico").val() == 1 || $("#SituacaoFisico").val() == 0) {
            $('#salvar').prop('disabled', true);

        }
    }

});