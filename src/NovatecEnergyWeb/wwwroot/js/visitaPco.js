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
    getZona();
    getDelegacao();
    getArea();
    getLotes();
    getInteresse();
    getTipoVisita();
    getRejeicaoPco();
    getAgenteComercial();

    exibeVisitas(); // antigo postToController

};

function getFormDataAsJson(){
    return {
        
        ZId: $('#zonas').val(),
        DId: $('#delegacao').val(),
        AId: $('#area').val(),
        IdLote: $('#lotes').val(),
        Interesse: $('#interesse').val(),
        NegativaId: $('#rejeicao').val(),
        AgComercialId: $('#agcomercial').val(),
        Diavisita1: $('#diavisita1').val(),
        Diavisita2: $('#diavisita2').val(),
        Pco: $('#pcoinput').val().toString().trim(),
        AgVisita: $('#agcomercialinput').val().toString().trim(),
        Bairro: $('#bairro').val().toString().trim(),
        Localidade: $('#localidadeinput').val().toString().trim(),
        Logradouro: $('#logradouroinput').val().toString().trim(),

        Numero1: $('#Numero1').val(),
        Numero2: $('#Numero2').val()
    }
}

function getInteresse() {
    var url = $("#urlGetInteresse").val();

    //$.getJSON(url, listaInteresse);
    $.getJSON(url,
        
        function (retorno) {    
            $("#interesse").empty();
          
            $.each(retorno, function () {    
                $("#interesse").append($("<option />").val(this.id).text(this.item));
            });
         
            $("#interesse").prop("selectedIndex", -1);
        }
    );
}

function getTipoVisita() {
    var url  = $("#urlGetTipoVisitaPco").val();

    //$.getJSON( url, listaTvisita);
    $.getJSON( url, 
        
        function(retorno){
            $("#tipoVisita").empty();
            
              $.each(retorno, function () {    
                  $("#tipoVisita").append($("<option />").val(this.id).text(this.item));
              });
           
              $("#tipoVisita").prop("selectedIndex", -1);
        }
    );   
}

function getRejeicaoPco(){
    var url = $("#urlGetRejeicaoPco").val();

    $.getJSON(url,
        
        function(retorno){
            $("#rejeicao").empty();

            $.each(retorno, function () {    
                $("#rejeicao").append($("<option />").val(this.id).text(this.motivo));
            });
         
            $("#rejeicao").prop("selectedIndex", -1);
        }
    );
}

function getAgenteComercial(){
    var url = $("#urlGetAgenteComercial").val();

    $.getJSON(url,

        function(retorno){
            $("#agcomercial").empty();

            $.each(retorno, function () {    
                $("#agcomercial").append($("<option />").val(this.id).text(this.nomeCompleto));
            });

            $("#agcomercial").prop("selectedIndex", -1);
        }

    );
}

function exibeVisitas(){
var url = $("#urlExibeVisitas").val();

    $("#load").fadeIn(); 
    var data = getFormDataAsJson();

    $.post(url, data, 
        
       
        function(retorno){
            montaPaginacao(retorno);
            preencheListagem(retorno);
        }

    );


    $("#load").fadeOut(); 
}     

function montaPaginacao(retorno) {
    //paginação
    $('#page-selection').unbind(); // limpa os eventos adicionados nessa tag

    $('#page-selection').bootpag({
        total: retorno.quantasPaginasExistem,
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
        postPaginacao(num);

    });

}

function postPaginacao(num) {
    var url = $("#urlPostPaginacao").val();

    $("#load").fadeIn(); // chama animacao de carregando

    var data = getFormDataAsJson();
    data.paginaClicada = num;
    $.post(url, data, tabelaLoteAtivos);

    $("#load").fadeOut(); // apaga animacao de carregando
}


function preencheListagem(retorno) {
    $('#corpoTabelaAtivos tr').remove();

    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < retorno.visitasPco.length; i++) {

        r[++j] = "<tr>";
        r[++j] = "<td>";
        r[++j] = retorno.visitasPco[i].z;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.visitasPco[i].d;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.visitasPco[i].ar;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.visitasPco[i].pco;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.visitasPco[i].complemento;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.visitasPco[i].num;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.visitasPco[i].dataHora;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.visitasPco[i].AgVisita;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.visitasPco[i].resultado;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.visitasPco[i].localidade;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.visitasPco[i].bairro;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.visitasPco[i].via;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.visitasPco[i].logradouro;
        r[++j] = "</td>";

        r[++j] = "</tr>";
    }

    $('#corpoTabelaAtivos').html(r.join(''));
}

function limpaFiltro(){
    location.reload();

    $('#zonas').val("");
    $('#delegacao').val("");
    $('#area').val("");
    $('#lotes').val("");
    $('#interesse').val("");
    $('#rejeicao').val("");
    $('#agcomercial').val("");
    $('#diavisita1').val("");
    $('#diavisita2').val("");
    $('#pcoinput').val("");
    $('#agcomercialinput').val("");
    $('#bairro').val("");
    $('#localidadeinput').val("");
    $('#logradouroinput').val("");
    $('#Numero1').val("");
    $('#Numero2').val("");
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

function atualizaDropsZona(retorno) {
    preencheDelegacao(retorno);
    preencheArea(retorno);
    preencheLotes(retorno);
}

function atualizaDropsDelegacao(retorno){
    preencheArea(retorno);
    preencheLotes(retorno);
}

function atualizaDropsArea(retorno){
    preencheLotes(retorno);
}


function preencheDelegacao(retorno){
    $("#delegacao").empty();
    
        $.each(retorno.delegacao, function () {
            $("#delegacao").append($("<option />").val(this.id).text(this.delegacao));
        });
    
    $("#delegacao").prop("selectedIndex", -1);
}

function preencheArea(retorno){
    
        $("#area").empty();

        $.each(retorno.area, function () {
            $("#area").append($("<option />").val(this.id).text(this.area));
        });

        $("#area").prop("selectedIndex", -1);
    
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

