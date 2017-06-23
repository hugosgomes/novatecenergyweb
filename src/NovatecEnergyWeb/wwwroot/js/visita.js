<<<<<<< HEAD
﻿
$('#diavisita1').datepicker({
    format: "dd/mm/yyyy",
    todayBtn: "linked",
    language: "pt-BR",
    orientation: "bottom left"
});

$('#diavisita2').datepicker({
    format: "dd/mm/yyyy",
    todayBtn: "linked",
    language: "pt-BR",
    orientation: "bottom left"
});

window.onload = function () {

    getReload();
};



function visitasPreenche(visitas){

/*
    alert("visitas l");
    alert(visitas.length);
    alert(visitas[0].condominio);
    alert(visitas[0].apt);

   */




    // preenche a tabela
    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < visitas.length; i++) {

        

        r[++j] = '<tr>';


        r[++j] = '<td>';
        r[++j] = visitas[i].z;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].d;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].ar;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].condominio;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].complemento;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].num;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].bloco;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].apt;
        r[++j] = '</td>';

       
        //formatando data
        r[++j] = "<td>";

        var data = visitas[i].dataHora; // data sem formatação: yyyy-MM-dd HH  "2017-06-05T17:35:59.177
        var formatada = '';
        if (data != '' && data != null) {
            formatada = data.split('-')[2].split('T')[0] + '/' +
                data.split('-')[1] + '/' + data.split('-')[0] + ' '
                + data.split('-')[2].split('T')[1];
        }

        r[++j] = formatada; // data tratada
        r[++j] = "</td>";




        r[++j] = '<td>';
        r[++j] = visitas[i].venda;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].dx;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].tipoVisita;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].agVisita;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].statusCond;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].negativa;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].pt;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].localidade;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].bairro;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].via;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas[i].logradouro;
        r[++j] = '</td>';

 

        r[++j] = '</tr>';

    }

    $('#corpoTabelaAtivos').html(r.join(''));



}
function limpaFiltro() {

    location.reload();

   $('#condominioinput').val("");
   $('#agcomercialinput').val("");
   $('#localidadeinput').val("");
   $('#bairro').val("");
   $('#logradouroinput').val("");
   $('#diavisita1').val("");
   $('#diavisita2').val("");
   $('#Numero1').val("");
   $('#Numero2').val("");

}

function montaPaginacao(retorno) {
  
    //paginação
   $('#page-selection').unbind(); // limpa os eventos adicionados nessa tag

    $('#page-selection').bootpag({
       
        //total: retorno.QuantasPaginasExistem,
        total: 200,
        page: 1,
        maxVisible: 5,
        firstLastUse: true,
        first: '←',
        last: '→',
        nextClass: 'next',
        prevClass: 'prev',
        lastClass: 'last',
        firstClass: 'first'

    }).on("page", function (event, num) {
        // some ajax content loading...
        
        exibeVisitas(num);

    });

}


function getReload() {

    getD();
    getVenda();
    getRejeicao();
    getTipovisita();
    getStatus();
    getCondominio();
    getAgente();
    getLote();
    getArea();
    getDelegacao();
    getZona();
    montaPaginacao(1);
    exibeVisitas(1);

}

/////////////////////////////////////////////////////////////////
function listaZona(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length - 1; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].zona + '</option>';

        $("#zonas").append(cols);

    }

    $("#zonas").prop("selectedIndex", -1);
}

///////////////////////////////////////////////////////////////////////////
function listaDelegacao(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length ; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].delegacao + '</option>';

        $("#delegacao").append(cols);

    }

    $("#delegacao").prop("selectedIndex", -1);
}

///////////////////////////////////////////////////////////////////////////
function listaArea(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].area + '</option>';

        $("#area").append(cols);

    }

    $("#area").prop("selectedIndex", -1);
}


///////////////////////////////////////////////////////////////////////////
function listaLote(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].loteNum +"&nbsp"+ retorno[i].ge + '</option>';

        $("#lotes").append(cols);

    }

    $("#lotes").prop("selectedIndex", -1);
}

///////////////////////////////////////////////////////////////////////////
function listaD(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].item + '</option>';

        $("#d1d2").append(cols);

    }

    $("#d1d2").prop("selectedIndex", -1);
}

///////////////////////////////////////////////////////////////////////////
function listaVenda(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].item + '</option>';

        $("#venda").append(cols);

    }

    $("#venda").prop("selectedIndex", -1);
}


///////////////////////////////////////////////////////////////////////////
function listaTipoVisita(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].item + '</option>';

        $("#area").append(cols);

    }

    $("#area").prop("selectedIndex", -1);
}

///////////////////////////////////////////////////////////////////////////
function listaRejeicao(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].motivo + '</option>';

        $("#rejeicao").append(cols);

    }

    $("#rejeicao").prop("selectedIndex", -1);
}

function listaAgComercial(retorno) {


    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length - 1; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].nomeCompleto + '</option>';

        $("#agcomercial").append(cols);

    }

    $("#agcomercial").prop("selectedIndex", -1);


}

function listaCondominio(retorno) {


    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length - 1; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].nome + '</option>';

        $("#condominio").append(cols);

    }

    $("#condominio").prop("selectedIndex", -1);


}

function listaStatus(retorno) {


    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length - 1; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].item + '</option>';

        $("#statuscond").append(cols);

    }

    $("#statuscond").prop("selectedIndex", -1);


}


function listaTipoVisita(retorno) {


    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length - 1; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].item + '</option>';

        $("#tipovisita").append(cols);

    }

    $("#tipovisita").prop("selectedIndex", -1);


}



function atualizaDropsZona(retorno) {
    preencheDelegacao(retorno);
    preencheArea(retorno);
    preencheLotes(retorno);
    preencheCondominio(retorno);

   // postToController();
}

function atualizaDropsDelegacao(retorno) {
    preencheArea(retorno);
    preencheLotes(retorno);
    preencheCondominio(retorno);

    //postToController();
}

function atualizaDropsArea(retorno) {

    preencheLotes(retorno);
    preencheCondominio(retorno);

}

function atualizaDropsLote(retorno) {
    preencheCondominio(retorno);
}





function preencheDelegacao(retorno) {
    $("#delegacao").empty();

    $.each(retorno.Delegacao, function () {
        $("#delegacao").append($("<option />").val(this.id).text(this.delegacao));
    });

    $("#delegacao").prop("selectedIndex", -1);
}


function preencheArea(retorno) {
    if (retorno.Area.length > 0) {
        $("#area").empty();

        $.each(retorno.Area, function () {
            $("#area").append($("<option />").val(this.id).text(this.area));
        });

        $("#area").prop("selectedIndex", -1);
    }
}


function preencheLotes(retorno) {
    $("#lotes").empty();

    $.each(retorno.Lotes, function () {

        var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');

        $("#lotes").append($("<option />").val(this[0]).text(this[1] + p.text()
            + this[2] + p.text()
            + this[3] + p.text()
            + this[4]));
    });

    $("#lotes").prop("selectedIndex", -1);
}


function preencheCondominio(retorno) {
    $("#condominio").empty();

    $.each(retorno.Condominio, function () {
        var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');
        $("#condominio").append($("<option />").val(this.id)
            .text(this.nome + p.text() + this.num + p.text() + this.complemento + p.text() +
            this.item + p.text() + this.z + p.text() + this.d));
    });

    $("#condominio").prop("selectedIndex", -1);
}


=======
﻿window.onload = function () {
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
>>>>>>> 2782718f14901241613ca6c735fb6744a3c2d611
