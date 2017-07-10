
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

    getLotes();
    getZona();
    getDelegacao();
    getArea();
    getVisitado();
    getInteresse();
    getPco();
    getTarifa();
    getTipoVisita();
    getRejeicao();
    getAgComercial();
    getCondominio();

    exibeVisitas(1);

    
};

function listaLote(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i][0] + '">' + retorno[i][1] + "&nbsp" + retorno[i][2] + '</option>';

        $("#lotes").append(cols);

    }

    if (document.getElementById("lotes").length == 1) {
        $("#lotes").prop("selectedIndex", 0);
        $("#lotes").attr('disabled', 'disabled'); // desativa o seletor
    } else {
        $("#lotes").prop("selectedIndex", -1); // limpa a seleção após carregar
    }

}

function listaZona(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].zona + '</option>';

        $("#zonas").append(cols);

    }

    if (document.getElementById("zonas").length == 1) {
        $("#zonas").prop("selectedIndex", 0);
        $("#zonas").attr('disabled', 'disabled'); // desativa o seletor
    } else {
        $("#zonas").prop("selectedIndex", -1); // limpa a seleção após carregar
    }
}
///////////////////////////////////////////////////////////////////////////
function listaDelegacao(retorno) {

   
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].delegacao + '</option>';

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
function listaVisitado(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].item + '</option>';

        $("#visitado").append(cols);

    }

    if (document.getElementById("visitado").length == 1) {
        $("#visitado").prop("selectedIndex", 0);
        $("#visitado").attr('disabled', 'disabled'); // desativa o seletor
    } else {
        $("#visitado").prop("selectedIndex", -1); // limpa a seleção após carregar
    }


}
///////////////////////////////////////////////////////////////////////////
function listaInteresse(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].item + '</option>';

        $("#interesse").append(cols);

    }

    if (document.getElementById("interesse").length == 1) {
        $("#interesse").prop("selectedIndex", 0);
        $("#interesse").attr('disabled', 'disabled'); // desativa o seletor
    } else {
        $("#interesse").prop("selectedIndex", -1); // limpa a seleção após carregar
    }


}

///////////////////////////////////////////////////////////////////////////
function listaPco(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].item + '</option>';

        $("#pco").append(cols);

    }

    if (document.getElementById("pco").length == 1) {
        $("#pco").prop("selectedIndex", 0);
        $("#pco").attr('disabled', 'disabled'); // desativa o seletor
    } else {
        $("#pco").prop("selectedIndex", -1); // limpa a seleção após carregar
    }


}

///////////////////////////////////////////////////////////////////////////
function listaTsocial(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].item + '</option>';

        $("#tSocial").append(cols);

    }

    if (document.getElementById("tSocial").length == 1) {
        $("#tSocial").prop("selectedIndex", 0);
        $("#tSocial").attr('disabled', 'disabled'); // desativa o seletor
    } else {
        $("#tSocial").prop("selectedIndex", -1); // limpa a seleção após carregar
    }


}


///////////////////////////////////////////////////////////////////////////
function listaTvisita(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].item + '</option>';

        $("#tipoVisita").append(cols);

    }

    if (document.getElementById("tipoVisita").length == 1) {
        $("#tipoVisita").prop("selectedIndex", 0);
        $("#tipoVisita").attr('disabled', 'disabled'); // desativa o seletor
    } else {
        $("#tipoVisita").prop("selectedIndex", -1); // limpa a seleção após carregar
    }


}

///////////////////////////////////////////////////////////////////////////
function listaRejeicao(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].motivo + '</option>';

        $("#rejeicao").append(cols);

    }

    if (document.getElementById("rejeicao").length == 1) {
        $("#rejeicao").prop("selectedIndex", 0);
        $("#rejeicao").attr('disabled', 'disabled'); // desativa o seletor
    } else {
        $("#rejeicao").prop("selectedIndex", -1); // limpa a seleção após carregar
    }


}


///////////////////////////////////////////////////////////////////////////
function listaAgComercial(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].nomeCompleto + '</option>';

        $("#agcomercial").append(cols);

    }

    if (document.getElementById("agcomercial").length == 1) {
        $("#agcomercial").prop("selectedIndex", 0);
        $("#agcomercial").attr('disabled', 'disabled'); // desativa o seletor
    } else {
        $("#agcomercial").prop("selectedIndex", -1); // limpa a seleção após carregar
    }


}


///////////////////////////////////////////////////////////////////////////
function listaCondominio(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].nome + '</option>';

        $("#condominio").append(cols);

    }

    if (document.getElementById("condominio").length == 1) {
        $("#condominio").prop("selectedIndex", 0);
        $("#condominio").attr('disabled', 'disabled'); // desativa o seletor
    } else {
        $("#condominio").prop("selectedIndex", -1); // limpa a seleção após carregar
    }


}

///////////////////////////////////////////////////////////////////////////
function listaArea(retorno) {
    var area = retorno.area;

    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].area + '</option>';

        $("#area").append(cols);

    }

    if (document.getElementById("area").length == 1) {
        $("#area").prop("selectedIndex", 0);
        $("#area").attr('disabled', 'disabled'); // desativa o seletor
    } else {
        $("#area").prop("selectedIndex", -1); // limpa a seleção após carregar
    }

   // exibeVisitas(1);
}

function visitasPreenche(visitas) {

    montaPaginacao(visitas);
    $('#contagemVisitas').html(visitas.contagem);
  
    // preenche a tabela
    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < visitas.vis.length; i++) {



        r[++j] = '<tr>';


    

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].z;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].d;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].ar;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].condominio;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].complemento;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].num;
        r[++j] = '</td>';


        //formatando data
        r[++j] = "<td>";

        var data = visitas.vis[i].dataHora; // data sem formatação: yyyy-MM-dd HH  "2017-06-05T17:35:59.177
        var formatada = '';
        if (data != '' && data != null) {
            formatada = data.split('-')[2].split('T')[0] + '/' +
                data.split('-')[1] + '/' + data.split('-')[0] + ' '
                + data.split('-')[2].split('T')[1];
        }

        r[++j] = formatada; // data tratada
        r[++j] = "</td>";

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].agComercial;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].negativa;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].pt;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].statusCond;
        r[++j] = '</td>';


        r[++j] = '<td>';
        r[++j] = visitas.vis[i].tipoCond;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].localidade;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].bairro;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].via;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].logradouro;
        r[++j] = '</td>';

        r[++j] = '</tr>';

    }

    $('#corpoTabelaAtivos').html(r.join(''));



}

function visitasPreenche2(visitas) {

    $('#contagemVisitas').html(visitas.contagem);


    // preenche a tabela
    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < visitas.vis.length; i++) {



        r[++j] = '<tr>';




        r[++j] = '<td>';
        r[++j] = visitas.vis[i].z;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].d;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].ar;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].condominio;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].complemento;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].num;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].dataHora;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].agComercial;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].negativa;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].pt;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].statusCond;
        r[++j] = '</td>';


        r[++j] = '<td>';
        r[++j] = visitas.vis[i].tipoCond;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].localidade;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].bairro;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].via;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].logradouro;
        r[++j] = '</td>';

        r[++j] = '</tr>';

    }

    $('#corpoTabelaAtivos').html(r.join(''));



}

function montaPaginacao(retorno) {
    
    //paginação
    $('#page-selection').unbind(); // limpa os eventos adicionados nessa tag

    $('#page-selection').bootpag({


  
        //total: retorno.QuantasPaginasExistem,
        total: retorno.totalPag,
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

        exibeVisitas2(num);

    });

}

function limpaFiltro() {

    $('#condominioinput').val("");
    $('#agcomercialinput').val("");
    $('#localidadeinput').val("");
    $('#bairro').val("");
    $('#logradouroinput').val("");

    $('#Numero1').val("");
    $('#Numero2').val("");

    location.reload();
}


// funções de onchange
function postZona() {

    var url = $("#urlPostZona").val();

    var p = {};
    p.zona = $("#zonas").val();

    $.post(url, p, atualizaDropsZona);
}

function postDelegacao() {
    var url = $("#urlPostDelegacao").val();
        var p = {};
        p.delegacao = $("#delegacao").val();
        $.post(url, p, atualizaDropsDelegacao);
}

function postArea() {
    var url = $("#urlPostArea").val();
    var p = {};
    p.area = $('#area').val();
    $.post(url, p, atualizaDropArea);
}
// FIM funções de onchange

function atualizaDropsZona(retorno) {
    preencheDelegacao(retorno);
    preencheArea(retorno);
    preencheLotes(retorno);
}
function atualizaDropsDelegacao(retorno) {
    preencheArea(retorno);
    preencheLotes(retorno);
}
function atualizaDropArea(retorno) {
    preencheLotes(retorno);
}


function preencheDelegacao(retorno) {
    $("#delegacao").empty();

    $.each(retorno.delegacao, function () {
        $("#delegacao").append($("<option />").val(this.id).text(this.delegacao));
    });

    $("#delegacao").prop("selectedIndex", -1);
}

function preencheArea(retorno) {
    if (retorno.area.length > 0) {
        $("#area").empty();

        $.each(retorno.area, function () {
            $("#area").append($("<option />").val(this.id).text(this.area));
        });

        $("#area").prop("selectedIndex", -1);
    }
}

function preencheLotes(retorno) {
    $("#lotes").empty();

    $.each(retorno.lotes, function () {
        
        var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');

        $("#lotes").append($("<option />").val(this[0]).text(this[1] + p.text()
            + this[2] + p.text()
            + this[3] + p.text()
            + this[4]));
    });

    $("#lotes").prop("selectedIndex", -1);
}