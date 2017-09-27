window.onload = function () {
    getLotes();
    getZona();
    getDelegacao();
    getArea();

    exibeVisitas();
};

function getFormDataAsJson(){
    return{
        ZId: $('#zonas').val(),
        DId: $('#delegacao').val(),
        AId: $('#area').val(),
        IdLote: $('#lotes').val()
    }
}

function exibeVisitas(){
    var url = $("#urlExibeVisitas").val();
    
        $("#load").fadeIn(); 
        var data = getFormDataAsJson();
    
        $.post(url, data, 
            
           
            function (retorno) {
                montaPaginacao(retorno);
                preencheListagem(retorno);
            }
    
        );
    
    
        $("#load").fadeOut(); 
    }   

function preencheListagem(visitas) {

//    montaPaginacao(visitas);
    estatistica(visitas);

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


function estatistica(retorno) {
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
        postPaginacao(num);

    });

}

function postPaginacao(num){
    var url = $("#urlPostPaginacao").val();
    
    $("#load").fadeIn(); // chama animacao de carregando
    
    var data = getFormDataAsJson();
    data.paginaClicada = num;
        //$.post(url, data, tabelaLoteAtivos);
    $.post(url, data, preencheListagem);
    
    $("#load").fadeOut(); // apaga animacao de carregando
}

function limpaFiltro() {

    location.reload();


    $('#lotes').val("");
    $('#zonas').val("");
    $('#delegacao').val("");
    $('#area').val("");

    $('#endereco').val("");

}

function postZona(){
    var p = {};
    p.zona = $("#zonas").val();

    var url = $("#urlZonaCascade").val();

    $.post(url, p,atualizaDropsZona);
}

function postDelegacao(){
    var p = {};
    p.delegacao = $("#delegacao").val();

    var url =  $("#urlDelegacaoCascade").val();

    $.post(url, p,atualizaDropsDelegacao);

}

function postArea(){
    var p = {};
    p.area = $("#area").val();

    var url = $("#urlAreaCascade").val();

    $.post(url, p,atualizaDropsArea );

}




/////////////////////////////////////////////////
//   filtros em cascata
////////////////////////////////////////////////

function atualizaDropsZona(retorno) {
    preencheDelegacao(retorno);
    preencheArea(retorno);
    preencheLotes(retorno);
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
}

function atualizaDropsArea(retorno) {
    preencheLotes(retorno);
}

function atualizaDropsDelegacao(retorno) {
    preencheArea(retorno);
    preencheLotes(retorno);

}

//usado na combo de lote para acrescentar o atributo data-toggle pra abrir a telinha de exportação
function atribuiDataToggle() {
    var vatt = $('#botaoExporta').attr('data-toggle');
    if (vatt == null) {
        $('#botaoExporta').attr('data-toggle', 'modal');
    }
}

function entrarNaTelaExportacao() {


    $("#mes").val($("#urlMes").val());
    $("#anos").val($("#urlAno").val());


    if ($("#lotes").val() != null) {
        var lt = $("#lotes :selected").text().toString();
        var ltf = lt.split(" ").join("").substr(0, 5).toString();
        document.getElementById("loteExibicao").innerHTML = 'Lote ' + ltf;
    } else {
        alert('Selecione um lote');
    }
    //postFilters();
}

function ExportaAgenda() {
    $("#load").fadeIn(); // chama animacao de carregando

    var url = $("#urlExcelExport").val();
    
    var p = {};

    p.lotes = $('#lotes').val();
    p.zonas = $('#zonas').val();
    p.delegacao = $('#delegacao').val();
    p.area = $('#area').val();
    p.bairro = $('#endereco').val().toString().toUpperCase().trim();
    p.mes = $("#anos").val();
    p.ano = $("#mes").val();

    window.location.href = '' + url + '/PcoEndereco/ExportaAgendaAdesao?zona=' + p.zonas + '&delegacao=' +
        p.delegacao + '&area=' + p.area + '&=' + p.lotes + '&bairro=' + p.endereco + '&ano='+ p.ano +'&mes=' +p.mes;

   $("#load").fadeOut(); // apaga animacao carregando
}    


