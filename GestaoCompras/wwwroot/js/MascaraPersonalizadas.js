$(document).ready(function () {

    if ($("#Telefone1").length == 11) {
        $("#Telefone1").mask("(00) 00000-0000");
    }
    else {
        $("#Telefone1").mask("(00) 0000-00009");
    }

    if ($("#Telefone2").length == 11) {
        $("#Telefone2").mask("(00) 00000-0000");
    }
    else {
        $("#Telefone2").mask("(00) 0000-00009");
    }


    if ($("#Telefone3").length == 11) {
        $("#Telefone3").mask("(00) 00000-0000");
    }
    else {
        $("#Telefone3").mask("(00) 0000-00009");
    }

    $("#Telefone1").blur(function () {
        var telefone = $("#Telefone1").val().replace(/\D/g, '');
        if (telefone.length == 11) {
            $("#Telefone1").mask("(00) 00000-0000");
        }
        else {
            $("#Telefone1").mask("(00) 0000-00009");
        }
    });
    $("#Telefone2").blur(function () {
        var telefone = $("#Telefone1").val().replace(/\D/g, '');
        if (telefone.length == 11) {
            $("#Telefone2").mask("(00) 00000-0000");

        }
        else {
            $("#Telefone2").mask("(00) 0000-00009");

        }
    }); $("#Telefone3").blur(function () {
        var telefone = $("#Telefone1").val().replace(/\D/g, '');
        if (telefone.length == 11) {
            $("#Telefone3").mask("(00) 00000-0000");
        }
        else {
            $("#Telefone3").mask("(00) 0000-00009");
        }
    });




    $("#Cnpj").mask("99.999.999/9999-99");
    $("#CapitalSocial").mask("####0,00");
    $("#ValorCota").mask("####0,00");
    $("#QuantidadeQuota").mask("####0,00");
    $("#CaracterizacaoCapital").mask("####0,00");
});