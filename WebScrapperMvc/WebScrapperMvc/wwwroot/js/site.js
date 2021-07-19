// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $("#containerImagens").hide();
    $("#tabelaPalavras").hide();

    $("#txtBusca").keypress(function (e) {
        if (e.which == 13) {
            enviarUrl();
        }
    });

    $(".botao").click(function () {
        enviarUrl();

    });

    function enviarUrl() {
        var validate = Validate();
        if (validate.length == 0) {
            $.blockUI({ message: $('.loader') });
            $.ajax({
                type: "POST",
                url: "/Home/Index",
                dataType: 'json',
                data: {
                    teste: $("#txtBusca").val()
                },
                success: function (response) {
                    $.unblockUI();
                    if (response) { 
                        var rowImagens = "";
                        var rowPalavras = "<tr><th>10 palavras mais usadas</th></tr>";
                        var n = 0;
                        var count = response.imagens.length;
                        var columns = Math.sqrt(count);
                        columns = parseInt(columns);
                        $("#containerImagens img").css('width', $("#container").width() / columns);
                        $.each(response.imagens, function (index, item) {

                            rowImagens += "<img width='30%' src=data:image/jpeg;base64," + item.imagem + " />";

                        });
                        $.each(response.topPalavras, function (index, item) {
                            rowPalavras += "<tr><td>" + (index += 1) + '.' + item + "</td></tr>";
                        });
                        $("#containerImagens").html(rowImagens);
                        $("#tabelaPalavras").html(rowPalavras);
                        $("#containerImagens").show();
                        $("#tabelaPalavras").show();
                    }
                },
                error: function () {
                    $.unblockUI();
                }
            });
        }
        else {
            alert(validate);

        }
    }

    function Validate() {
        var errorMessage = "";
        if ($("#txtBusca").val() == "") {
            errorMessage += "► Digite URL";
        }
        else if (!(isUrlValid($("#txtBusca").val()))) {
            errorMessage += "► URL inválida";
        }

        return errorMessage;
    }

    function isUrlValid(url) {
        var urlregex = new RegExp(
            "^(http[s]?:\\/\\/(www\\.)?|ftp:\\/\\/(www\\.)?|www\\.){1}([0-9A-Za-z-\\.@@:%_\+~#=]+)+((\\.[a-zA-Z]{2,3})+)(/(.)*)?(\\?(.)*)?");
        return urlregex.test(url);
    }
});
