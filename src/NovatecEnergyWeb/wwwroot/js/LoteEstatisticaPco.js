window.onload = function () {
    getZona();
    getDelegacao();
    getArea();
    getBuscaLotes();
    graficos();
};


function preencheTableLotes(lotesTableSelect) {
    $("corpoLotes tr").remove();

    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < lotesTableSelect.length; i++) {
        r[++j] = '<tr id="lote_' + lotesTableSelect[i][0].toString() + '" class="mouse-hand">';
        r[++j] = '<td>';
        r[++j] = lotesTableSelect[i][1];
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = lotesTableSelect[i][2];
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = lotesTableSelect[i][3];
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = lotesTableSelect[i][4];
        r[++j] = '</td>';
        r[++j] = '</tr>';
    }
    $('#corpoLotes').html(r.join(''));

    adicionaEventoClickRow(lotesTableSelect);
}

function adicionaEventoClickRow(lotesTableSelect) {
    var table = document.getElementById("tableLote");
    var rows = table.rows;
    for (var i = 0; i < rows.length; i++) {
        rows[i].onclick = (function () {
            return function () {
                var idLote = this.id.toString().split('_')[1];

                for (var i = 0; i < lotesTableSelect.length; i++) {
                    // encontra o nome do lote 
                    if (lotesTableSelect[i][0] == idLote) {

                        $("#infLote").empty(); //limpa
                        $("#infLote").append(lotesTableSelect[i][1]);
                    }
                }
                getEstatisticaByLote(idLote);
            }
        })(i);
    }
}

function atualizaTabelas(estatistica) {
    preencheTableStatus(estatistica);
    preencheTableEstatistica(estatistica);
    graficos(estatistica);
}

function preencheTableStatus(estatistica) {
    $("corpoStatus tr").remove();

    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < estatistica.length; i++) {

        r[++j] = '<tr>';
        r[++j] = '<td>';
        r[++j] = estatistica[i].umt;
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = estatistica[i].qmt;
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = Math.floor(estatistica[i].mtpot * 100).toString() + '%';
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = Math.ceil(estatistica[i].mtvis * 100).toString() + '%';
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = Math.floor(estatistica[i].mtent * 100).toString() + '%';
        r[++j] = '</td>';
        r[++j] = '</tr>';
    }

    $('#corpoStatus').html(r.join(''));
}

function preencheTableEstatistica(estatistica) {
    console.log(estatistica);
    $("corpoEstatistica tr").remove();
   
    if (estatistica.length > 0) {

        // potencial
        $('#potNum').html(estatistica[0].pot);

        //tratados
        $('#tratNum').html(estatistica[0].trat);
        $('#tratSpot').html(Math.ceil((estatistica[0].trat / estatistica[0].pot) * 100).toString() + '%');

        // endereços não tratados
        $('#naoTratNum').html(estatistica[0].pot - estatistica[0].trat);
        $('#naoTratSpot').html(Math.ceil(((estatistica[0].pot - estatistica[0].trat) / estatistica[0].pot) * 100).toString() + '%');

        $('#c0Num').html(estatistica[0].visitas0);
        var naotratados = (estatistica[0].pot - estatistica[0].trat);
        $('#c0Spot').html((naotratados) ? Math.ceil((estatistica[0].visitas0 / naotratados) * 100).toString() + '%' : "0" + '%');

        $('#c1Num').html(estatistica[0].visitas1);
        $('#c1Spot').html((naotratados) ? Math.ceil((estatistica[0].visitas1 / naotratados) * 100).toString() + '%' : "0" + '%');

        $('#c2Num').html(estatistica[0].visitas2);
        $('#c2Spot').html((naotratados) ? Math.ceil((estatistica[0].visitas2 / naotratados) * 100).toString() + '%' : "0" + '%');

        // visitados
        $('#visNum').html(estatistica[0].vis);
        $('#visSpot').html(Math.ceil((estatistica[0].vis / estatistica[0].pot) * 100).toString() + '%');

        //entrevistados
        $('#entNum').html(estatistica[0].ent);
        $('#entSpot').html(Math.ceil((estatistica[0].ent / estatistica[0].pot) * 100).toString() + '%');
        $('#entVis').html(Math.ceil((estatistica[0].ent / estatistica[0].vis) * 100).toString() + '%');

        //interessados
        $('#interNum').html(estatistica[0].int);
        $('#interPot').html(Math.ceil((estatistica[0].int / estatistica[0].pot) * 100).toString() + '%');
        $('#interVis').html((estatistica[0].vis) ? Math.ceil((estatistica[0].int / estatistica[0].vis) * 100).toString() + '%' : "0" + '%');
        $('#interEnt').html((estatistica[0].ent) ? Math.ceil((estatistica[0].int / estatistica[0].ent) * 100).toString() + '%' : "0" + '%');

        //nao visitados
        $('#naoVisiNum').html(estatistica[0].pot - estatistica[0].vis);
        $('#naoVisiPot').html(Math.ceil(((estatistica[0].pot - estatistica[0].vis) / estatistica[0].pot) * 100).toString() + '%');
        //$('#')

        //nao entrevistado
        $('#naoEntNum').html(estatistica[0].pot - estatistica[0].ent);
        $('#naoEntSpot').html(Math.ceil(((estatistica[0].pot - estatistica[0].ent) / estatistica[0].pot) * 100).toString() + '%');

        //visitados nao entrevistados
        $('#visNaoEntNum').html(estatistica[0].pot - estatistica[0].ent);
        $('#visNaoEntSpot').html(Math.ceil(((estatistica[0].vis - estatistica[0].ent) / estatistica[0].pot) * 100).toString() + '%');
        $('#visNaoEntSvis').html(Math.ceil(((estatistica[0].vis - estatistica[0].ent) / estatistica[0].vis) * 100).toString() + '%');
        
        // nao interessados
        $('#naoContNum').html(estatistica[0].pot - estatistica[0].interesse);
        $('#naoContSpot').html(Math.ceil(((estatistica[0].pot - estatistica[0].int) / estatistica[0].pot) * 100).toString() + '%');

        //visitados nao interessados
        $('#visNaoContNum').html(estatistica[0].vis - estatistica[0].int);
        $('#visNaoContSpot').html(Math.ceil(((estatistica[0].vis - estatistica[0].int) / estatistica[0].pot) * 100).toString() + '%');
        $('#visNaoContSvis').html(Math.ceil(((estatistica[0].vis - estatistica[0].int) / estatistica[0].vis) * 100).toString() + '%');

        //entrevistados nao interessados
        $('#entNaoInterNum').html(estatistica[0].ent - estatistica[0].int);
        $('#entNaoInterSpot').html(Math.ceil(((estatistica[0].ent - estatistica[0].int) / estatistica[0].pot) * 100).toString() + '%');
        $('#entNaoInterSvis').html((estatistica[0].vis) ? Math.ceil(((estatistica[0].ent - estatistica[0].int) / estatistica[0].vis) * 100).toString() + '%' : "0" + '%');
                
        //visitas realizadas
        $('#visRealiNum').html(estatistica[0].visx);

        //entrevistas realizadas
        $('#entRealiNum').html(estatistica[0].entx);
        $('#entRealiSvis').html(Math.ceil((estatistica[0].entx / estatistica[0].visx) * 100).toString() + '%');

        //visitas improdutivas
        $('#visImproNum').html(estatistica[0].visx - estatistica[0].entx);
        $('#visImproSvis').html(Math.ceil(((estatistica[0].visx - estatistica[0].entx) / estatistica[0].visx) * 100).toString() + '%');
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


}

//
//função de onchange do dropdown de zona
//
function postZona() {
    $('#delegacao').empty();
    $('#area').empty();

    var url = $("#urlZonaCascade").val();
    var data = {};
    data.zona = $('#zonas').val();

    $.post(url, data, preencheDelegacaoArea);
}

function postDelegacao() {
    $('#area').empty();
    var url = $("#urlDelegacaoCascade").val();
    var data = {};
    data.delegacao = $('#delegacao').val();

    $.post(url, data, preencheArea);
}

//
// função callback que roda após o onchange do dropdown de zona, preenche os drops de delegacao e area
//
function preencheDelegacaoArea(retorno) {
    $('#delegacao').empty();
    $('#area').empty();

    $.each(retorno.delegacao, function () {
        $("#delegacao").append($("<option />").val(this.id).text(this.delegacao));
    });
    $.each(retorno.area, function () {
        $("#area").append($("<option />").val(this.id).text(this.area));
    });

    $("#area").prop("selectedIndex", -1); // limpa a seleção após carregar
    $("#delegacao").prop("selectedIndex", -1); // limpa a seleção após carregar
}

function preencheArea(retorno) {
    $('#area').empty();

    $.each(retorno.area, function () {
        $("#area").append($("<option />").val(this.id).text(this.area));
    });


    $("#area").prop("selectedIndex", -1); // limpa a seleção após carregar

}

function cleanFiltro() {
    location.reload();
}

