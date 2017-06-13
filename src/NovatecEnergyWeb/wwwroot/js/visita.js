window.onload = function () {
    preencheSelects();
};

//alguns métodos estão no site.js
function preencheSelects() {
    $('#load').fadeIn();
    getZona();
    getDelegacao();
    getArea();
    getLotes();
    getVenda();
    getD1d2();
    getTipoVisita();
    getRejeicao();
    getAgComercial();
    getStatusCond();
    getCondominio();
    $('#load').fadeOut();
}

function getVenda() {
    var url = $("#urlCampoVenda").val();

    $.getJSON(url,

        function (venda) {
            $("#venda").empty();

            for (var i = 0; i < venda.length; i++) {
                $("#venda").append($("<option />").val(venda[i].id).text(venda[i].item));
            }

            $("#venda").prop("selectedIndex", -1);
        });
}

function getD1d2() {
    var url = $("#urlD1d2").val();

    $.getJSON(url,

        function (d1d2) {
            $("#d1d2").empty();

            for (var i = 0; i < d1d2.length; i++) {
                $("#d1d2").append($("<option />").val(d1d2[i].id).text(d1d2[i].item));
            }

            $("#d1d2").prop("selectedIndex", -1);
        });
}

function getTipoVisita() {
    var url = $("#urlTipoVisita").val();

    $.getJSON(url,

        function (tipovisita) {
            $("#tipovisita").empty();

            for (var i = 0; i < tipovisita.length; i++) {
                $("#tipovisita").append($("<option />").val(tipovisita[i].id).text(tipovisita[i].item));
            }
            
            $("#tipovisita").prop("selectedIndex", -1);
        });
}

function getRejeicao() {
    var url = $("#urlRejeicao").val();

    $.getJSON(url,

        function (rejeicao) {
            $("#rejeicao").empty();

            for (var i = 0; i < rejeicao.length; i++) {
                $("#rejeicao").append($("<option />").val(rejeicao[i].id).text(rejeicao[i].motivo));
            }

            $("#rejeicao").prop("selectedIndex", -1);
        });
}

function getAgComercial() {
    var url = $("#urlAgComercial").val();

    $.getJSON(url,

        function (agcomercial) {
            $("#agcomercial").empty();

            for (var i = 0; i < agcomercial.length; i++) {
                $("#agcomercial").append($("<option />").val(agcomercial[i].id).text(agcomercial[i].nomeCompleto));
            }

            $("#agcomercial").prop("selectedIndex", -1);
        });
}

function getStatusCond() {
    var url = $("#urlStatusCond").val();

    $.getJSON(url,

        function (statuscond) {
            $("#statuscond").empty();

            for (var i = 0; i < statuscond.length; i++) {
                $("#statuscond").append($("<option />").val(statuscond[i].id).text(statuscond[i].item));
            }

            $("#statuscond").prop("selectedIndex", -1);
        });
}

function getCondominio() {
    var url = $("#urlCondominio").val();

    $.getJSON(url,

        function (condominio) {
            $("#condominio").empty();
            var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');
            for (var i = 0; i < condominio.length; i++) {
                $("#condominio").append($("<option />").val(condominio[i].id)
                    .text(condominio[i].nome + p.text() + condominio[i].num + p.text() + condominio[i].complemento + p.text() +
                    condominio[i].item + p.text() + condominio[i].z + p.text() + condominio[i].d));
            }

            $("#condominio").prop("selectedIndex", -1);        
                
            });
    
}
