(function ($) {

    getZona = function () {

        // url está em /LoteEstatistica/Index.cshtml
        var url = $("#urlGetZona").val();

        // Ajax 

        $.get(url,

            function (zonas) {
                // listando todos os objetos no select zona
                for (i = 0; i < zonas.length; i++) {
                    var cols = "";
                    cols = '<option value="' + zonas[i].id + '">' + zonas[i].zona + '</option>';
                    $("#zonas").append(cols);
                }


                if (document.getElementById("zonas").length == 1) {
                    $("#zonas").prop("selectedIndex", 0);
                    $("#zonas").attr('disabled', 'disabled');
                } else {
                    $("#zonas").prop("selectedIndex", -1); // limpa a seleção após carregar
                }

            }

        ); 'json' // fim do metodo ajax post


    }

})(jQuery);


(function ($) {



    getDelegacao = function () {

        var url = $("#urlGetDelegacao").val(); // urlGetDelegacao está em /LoteEstatistica/Index.cshtml

        
        
        $.get(url,

            function (delegacao) {

                // listando todos os objetos no select zona
                for (i = 0; i < delegacao.length; i++) {

                    var cols = "";

                    cols += '<option value="' + delegacao[i].id + '">' + delegacao[i].delegacao + '</option>';

                    $("#delegacao").append(cols);

                }
                if (document.getElementById("delegacao").length == 1) {
                    $("#delegacao").prop("selectedIndex", 0);
                    $("#delegacao").attr('disabled', 'disabled'); // desativa o seletor
                } else {
                    $("#delegacao").prop("selectedIndex", -1); // limpa a seleção após carregar
                }

            }

        ); 'json' // fim do metodo ajax post


    }

})(jQuery);

function getArea() {
    var url = $("#urlGetArea").val(); // urlGetArea está em /LoteEstatistica/Index.cshtml
    //"/LoteEstatistica/getArea/"

    $.getJSON(url,

        function (area) {
            for (i = 0; i < area.length; i++) {
                var cols = "";

                cols += '<option value="' + area[i].id + '">' + area[i].area + '</option>';
                $("#area").append(cols);
            }

            if (document.getElementById("area").length == 1) {
                $("#area").prop("selectedIndex", 0);
                $("#area").attr('disabled', 'disabled'); // desativa o seletor
            } else {
                $("#area").prop("selectedIndex", -1); // limpa a seleção após carregar
            }


        });

}

function getLotes() {
    var url = $("#urlGetLotes").val();

    $.getJSON(url,

        function (lotes) {
            $("#lotes").empty();

            $.each(lotes, function () {
                var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');

                $("#lotes").append($("<option />").val(this[0]).text(this[1] + p.text()
                    + this[2] + p.text()
                    + this[3] + p.text()
                    + this[4] + p.text()));
            });

            $("#lotes").prop("selectedIndex", -1);

        });
}

function postZona() {
    var p = {};
    p.zona = $("#zonas").val();

    var url = $("#urlZonaCascade").val();

    $.post(url, p, atualizaDropsZona);
}

function preencheDelegacao(retorno) {
    $("#delegacao").empty();

    $.each(retorno.delegacao, function () {
        $("#delegacao").append($("<option />").val(this.id).text(this.delegacao));
    });

    $("#delegacao").prop("selectedIndex", -1);
}