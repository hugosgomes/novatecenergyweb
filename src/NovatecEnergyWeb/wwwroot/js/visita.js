
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



function visitasPreenche(retorno) {
    var visitas = retorno.visitas;
    //preenche contagem
    $('#contagemVisitas').html(retorno.contagem);

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
function listaZona(zonas) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < zonas.length ; i++) {

        var cols = "";
        
        cols += '<option value="' + zonas[i].id + '">' + zonas[i].zona + '</option>';

        $("#zonas").append(cols);

    }

    if (document.getElementById("zonas").length == 1) {
        $("#zonas").prop("selectedIndex", 0);
        $("#zonas").attr('disabled', 'disabled');
    } else {
        $("#zonas").prop("selectedIndex", -1); // limpa a seleção após carregar
    }
}

///////////////////////////////////////////////////////////////////////////
function listaDelegacao(delegacao) {

    // listando todos os objetos produto que contem no array
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

///////////////////////////////////////////////////////////////////////////
function listaArea(area) {

    // listando todos os objetos produto que contem no array
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
}


///////////////////////////////////////////////////////////////////////////
function listaLote(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].loteNum + "&nbsp" + retorno[i].ge + '</option>';

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



