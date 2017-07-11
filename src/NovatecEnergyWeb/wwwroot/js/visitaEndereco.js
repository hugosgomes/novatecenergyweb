window.onload = function () {
    getLote();
    getZona();
    getDelegacao();
    getArea();
};


///////////////////////////////////////////////////////////////////////////
function listaLote(retorno) {
    var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');
    $("#lotes").empty();

    // listando todos os objetos produto que contem no array
 /*   for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i][0] + '">' + retorno[i][1] + "&nbsp" + retorno[i][2] + '</option>';

        $("#lotes").append(cols);

    } */

    $.each(retorno, function () {

        $("#lotes").append($("<option />").val(this[0]).text(this[1] + p.text()
            + this[2] + p.text()
            + this[3] + p.text()
            + this[4]));
    });

    if (document.getElementById("lotes").length == 1) {
        $("#lotes").prop("selectedIndex", 0);
        $("#lotes").attr('disabled', 'disabled'); // desativa o seletor
    } else {
        $("#lotes").prop("selectedIndex", -1); // limpa a seleção após carregar
    }

}


/////////////////////////////////////////////////////////////////
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

    // listando todos os objetos produto que contem no array
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
function listaArea(retorno) {

    // listando todos os objetos produto que contem no array
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

    exibeVisitasEndereco(1);
}


function visitasPreenche(visitas) {

    montaPaginacao(visitas);
    estatisticaPreenche(visitas);

    // preenche a tabela
    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < visitas.vis.length; i++) {



        r[++j] = '<tr>';


        r[++j] = '<td>';
        r[++j] = visitas.vis[i].lote;
        r[++j] = '</td>';

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
        r[++j] = visitas.vis[i].endereco;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].potencial;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].visitados;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].visitas;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].entrevistas;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].visitasImpr;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].visitasAgendadas;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].ausencias;
        r[++j] = '</td>';

      
        r[++j] = '</tr>';

    }

    $('#corpoTabelaAtivos').html(r.join(''));



}

function visitasPreenche2(visitas) {

   
    estatisticaPreenche(visitas);

    // preenche a tabela
    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < visitas.vis.length; i++) {



        r[++j] = '<tr>';


        r[++j] = '<td>';
        r[++j] = visitas.vis[i].lote;
        r[++j] = '</td>';

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
        r[++j] = visitas.vis[i].endereco;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].potencial;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].visitados;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].visitas;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].entrevistas;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].visitasImpr;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].visitasAgendadas;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = visitas.vis[i].ausencias;
        r[++j] = '</td>';


        r[++j] = '</tr>';

    }

    $('#corpoTabelaAtivos').html(r.join(''));



}

function estatisticaPreenche(retorno) {

   

    $('#pot').html(retorno.Numeracoes[0]);

    $('#trat').html(retorno.Numeracoes[1]); 
    $('#tratPerc').html(retorno.Porcentagens[0] + '%');

    $('#naoTrat').html(retorno.Numeracoes[2]);
    $('#naoTratPerc').html(retorno.Porcentagens[1] + '%');

    $('#vis0').html(retorno.Numeracoes[3]);
    $('#vis0Perc').html(retorno.Porcentagens[2] + '%');

    $('#vis1').html(retorno.Numeracoes[4]);
    $('#vis1Perc').html(retorno.Porcentagens[3] + '%');

    $('#vis2').html(retorno.Numeracoes[5]);
    $('#vis2Perc').html(retorno.Porcentagens[4] + '%');

    $('#visitados').html(retorno.Numeracoes[6]);
    $('#visitadosPerc').html(retorno.Porcentagens[5] + '%');

    $('#naoVisitados').html(retorno.Numeracoes[7]);
    $('#naoVisitadosPerc').html(retorno.Porcentagens[6] + '%');

    $('#tEnderecos').html(retorno.Numeracoes[8]);

    $('#visitas').html(retorno.Numeracoes[9]);

    $('#entrevistas').html(retorno.Numeracoes[10]);
    $('#entrevistasPerc').html(retorno.Porcentagens[7] + '%');

    $('#visitasImpr').html(retorno.Numeracoes[11]);
    $('#visitasImprPerc').html(retorno.Porcentagens[8] + '%');

    $('#visitasAus').html(retorno.Numeracoes[12]);
    $('#visitasAusPerc').html(retorno.Porcentagens[9] + '%');

    $('#visitasAg').html(retorno.Numeracoes[13]);

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

        exibeVisitasEndereco2(num);

    });

}






function limpaFiltro() {

    location.reload();


   $('#lotes').val("");
   $('#zonas').val("");
   $('#delegacao').val("");
   $('#area').val("");

   $('#endereco').val("");

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

function atualizaDropsZona(retorno) {
    preencheDelegacao(retorno);
    preencheArea(retorno);
    preencheLotes(retorno);

    // postToController();
}

function atualizaDropsArea(retorno) {
    preencheLotes(retorno);
}

function atualizaDropsDelegacao(retorno) {
    preencheArea(retorno);
    preencheLotes(retorno);
 
}