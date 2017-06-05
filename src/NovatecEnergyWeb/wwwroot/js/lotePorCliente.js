$("#lotes").prop("selectedIndex", -1);
$("#CasaStatus").prop("selectedIndex", -1);
$("#motivosRejeicao").prop("selectedIndex", -1);
$("#clientesCeg").prop("selectedIndex", -1);
$("#zonas").prop("selectedIndex", -1);
$("#delegacoes").prop("selectedIndex", -1);
$("#areas").prop("selectedIndex", -1);
$("#statusCond").prop("selectedIndex", -1);
$("#condominiosId").prop("selectedIndex", -1);

$('#dtult').datepicker({
    format: "dd/mm/yyyy",
    todayBtn: "linked",
    language: "pt-BR",
    orientation: "bottom left"
});


window.onload = function () {
    postToController();
    selecionaInfoCliente();
};


function getFormDataAsJson() {
    var botaoClicado = clicado();

    return {
        IdLote: $('#lotes').val(),
        CasaStatus: $('#CasaStatus').val(),
        IdultMotivo: $('#motivosRejeicao').val(),
        Dtult: $('#dtult').val(),
        ClId: $('#clientesCeg').val(),
        ZId: $('#zonas').val(),
        DId: $('#delegacoes').val(),
        AId: $('#areas').val(),
        StatusId: $('#statusCond').val(),
        CondId: $('#condominiosId').val(),
        CondNome: $('#CondNome').val().toString().trim(),
        Localidade: $('#Localidade').val().toString().trim(),
        Bairro: $('#Bairro').val().toString().trim(),
        Logradouro: $('#Logradouro').val().toString().trim(),
        Numero1: $('#Numero1').val(),
        Numero2: $('#Numero2').val(),
        Botao: botaoClicado
    }
}

function clicado() {
    var id = '';
    if ($('#todos').data('clicked')) {
        $('#todos').data('clicked', false);
        id = 'todos';
        $('#todosli').addClass('disabled');

        $('#ativosli').removeClass('disabled');
        $('#semLoteTodosli').removeClass('disabled');
        $('#semLoteNaoli').removeClass('disabled');

    } else if ($('#ativos').data('clicked')) {
        $('#ativos').data('clicked', false);
        id = 'ativos';
        $('#todosli').removeClass('disabled')
        $('#ativosli').addClass('disabled');

        $('#semLoteTodosli').removeClass('disabled');
        $('#semLoteNaoli').removeClass('disabled');


    } else if ($('#semLoteTodos').data('clicked')) {
        $('#semLoteTodos').data('clicked', false)
        id = 'semLoteTodos';
        $('#todosli').removeClass('disabled')
        $('#ativosli').removeClass('disabled');

        $('#semLoteTodosli').addClass('disabled');
        $('#semLoteNaoli').removeClass('disabled');

    } else if ($('#semLoteNao').data('clicked')) {
        $('#semLoteNao').data('clicked', false)
        id = 'semLoteNao';
        $('#todosli').removeClass('disabled')
        $('#ativosli').removeClass('disabled');
        $('#semLoteTodosli').removeClass('disabled');

        $('#semLoteNaoli').addClass('disabled');
    } else if (id == '') {
        if ($("#todosli").hasClass('disabled')) {
            id = 'todos';
        } else if ($("#ativosli").hasClass('disabled')) {
            id = 'ativos';
        } else if ($("#semLoteTodosli").hasClass('disabled')) {
            id = 'semLoteTodos';
        } else if ($("#semLoteNaoli").hasClass('disabled')) {
            id = 'semLoteNao';
        }
    }

    return id;
}

function atualizaView(retorno) {
    tabelaEstatisticas(retorno)
    montaPaginacao(retorno);
    tabelaLoteAtivos(retorno);
};

function montaPaginacao(retorno) {
    //paginação
    $('#page-selection').unbind(); // limpa os eventos adicionados nessa tag

    $('#page-selection').bootpag({
        total: retorno.QuantasPaginasExistem,
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

function montaHeadLocal() {
    $('#headTabelaLote tr').remove();

    var tr = $('<tr/>');

    // tr.append('<th class="text-center">Casa</th>');
    // tr.append('<th class="text-center">Lote</th>'); 
    tr.append('<th class="text-center">Z</th>');
    tr.append('<th class="text-center">D</th>');
    tr.append('<th class="text-center">AR</th>');
    tr.append('<th class="text-center">PT</th>');
    tr.append('<th class="text-center">Condomínio</th>');

    tr.append('<th class="text-center">Localidade</th>');
    tr.append('<th class="text-center">Bairro</th>');
    tr.append('<th class="text-center">Via</th>');
    tr.append('<th class="text-center">Logradouro</th>');
    tr.append('<th class="text-center">Num</th>');
    tr.append('<th class="text-center">Comp</th>');
    tr.append('<th class="text-center">Bloco</th>');
    tr.append('<th class="text-center">Apt</th>');
    tr.append('<th class="text-center">ULTMOTIVO</th>');
    tr.append('<th class="text-center">AGULT</th>');
    tr.append('<th class="text-center">DTULT</th>');

    $('#headTabelaLote').append(tr);
};

function tabelaLoteAtivos(retorno) {

    montaHeadLocal();

    $('#corpoTabelaAtivos tr').remove();

    var tr;
    var r = new Array();
    var j = -1;

    //tr = $('<tr/>');

    for (var i = 0; i < retorno.EV.length; i++) {

        r[++j] = "<tr>";
        /* r[++j] = "<td>" ;
         r[++j] = retorno.EV[i].casa;
         r[++j] =  "</td>"; Retirados 11/05/2017 à pedido do Javier
         r[++j] = "<td>";
         r[++j] = retorno.EV[i].lote;
         r[++j] = "</td>";*/
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].z;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].d;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].ar;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].pt;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].condominio;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].localidade;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].bairro;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].via;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].logradouro;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].num;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].complemento;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].bloco;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].apt;
        r[++j] = "</td>";

        if (retorno.EV[i].ultMotivo == null) {
            r[++j] = "<td>";
            r[++j] = "</td>";
        } else {
            r[++j] = "<td>";
            r[++j] = retorno.EV[i].ultMotivo;
            r[++j] = "</td>";
        }

        if (retorno.EV[i].agult == null) {
            r[++j] = "<td>";
            r[++j] = "</td>";
        } else {
            r[++j] = "<td>";
            r[++j] = retorno.EV[i].agult;
            r[++j] = "</td>";
        }

        r[++j] = "<td>";
        var data = retorno.EV[i].dtult; // data sem formatação: yyyy-MM-dd HH  "2017-06-05T17:35:59.177
        var formatada = '';
        if (data != '' && data != null) {
            formatada = data.split('-')[2].split('T')[0] + '/' +
                data.split('-')[1] + '/' + data.split('-')[0] + ' '
                + data.split('-')[2].split('T')[1];
        }

        r[++j] = formatada;
        r[++j] = "</td>";
        r[++j] = "</tr>";
    }
    $('#corpoTabelaAtivos').html(r.join(''));

};

function tabelaEstatisticas(retorno) {
    for (var i = 0; i < retorno.Numeracoes.length; i++) {
        $('#e' + i).html(retorno.Numeracoes[i]);
    }

    for (var j = 0; j < retorno.Porcentagens.length; j++) {
        $('#ep' + j).html(retorno.Porcentagens[j] + '%');
    }

}

function atualizaSelects(retorno) {
   
    preencheLotes(retorno);
    $('#motivosRejeicao').empty();
    $('#zonas').empty();
    preencheDelegacao(retorno);
    preencheArea(retorno);
    $('#statusCond').empty();
    preencheCondominio(retorno);

    for (var i = 0; i < retorno.MotivosRejeicao.length; i++) {
        $('#motivosRejeicao').append($("<option />").val(retorno.MotivosRejeicao[i].id).text(retorno.MotivosRejeicao[i].motivo));
    }

    for (var i = 0; i < retorno.Zonas.length; i++) {
        $('#zonas').append($("<option />").val(retorno.Zonas[i].id).text(retorno.Zonas[i].zona));
    }

    for (var i = 0; i < retorno.StatusCondominios.length; i++) {
        $('#statusCond').append($("<option />").val(retorno.StatusCondominios[i].id).text(retorno.StatusCondominios[i].item));
    }

    $('#CasaStatus').prop("selectedIndex", -1);
    $('#motivosRejeicao').prop("selectedIndex", -1);
    $('#zonas').prop("selectedIndex", -1);
    $('#statusCond').prop("selectedIndex", -1);

    selecionaInfoCliente();
}

function postCascadeCliente() {
    var p = {};
    p.cliente = $('#clientesCeg').val();
    $.post('/Adesao/ClienteCascade', p, atualizaDropsCliente);

}

function atualizaDropsCliente(retorno) {
    $("#zonas").empty();
    $("#delegacoes").empty();
    $("#areas").empty();
    $("#lotes").empty();

    $.each(retorno.Zonas, function () {
        $("#zonas").append($("<option />").val(this.id).text(this.zona));
    });

    $.each(retorno.Delegacao, function () {
        $("#delegacoes").append($("<option />").val(this.id).text(this.delegacao));
    });

    $.each(retorno.Area, function () {
        $("#areas").append($("<option />").val(this.id).text(this.area));
    });

    $.each(retorno.Lote, function () {
        var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');

        $("#lotes").append($("<option />").val(this.id).text(this.loteNum + p.text()
              + this.ge + p.text()
              + this.dataLote + p.text()
              + this.item));
    });

    $("#zonas").prop("selectedIndex", -1);
    $("#delegacoes").prop("selectedIndex", -1);
    $("#areas").prop("selectedIndex", -1);
    $("#lotes").prop("selectedIndex", -1);
}

function atualizaDropsZona(retorno) {
    preencheDelegacao(retorno);
    preencheArea(retorno);
    preencheLotes(retorno);
    preencheCondominio(retorno);

    postToController();
}

function preencheDelegacao(retorno) {
    $("#delegacoes").empty();

    $.each(retorno.Delegacao, function () {
        $("#delegacoes").append($("<option />").val(this.id).text(this.delegacao));
    });

    $("#delegacoes").prop("selectedIndex", -1);
}

function preencheArea(retorno) {
    if (retorno.Area.length > 0) {
        $("#areas").empty();

        $.each(retorno.Area, function () {
            $("#areas").append($("<option />").val(this.id).text(this.area));
        });

        $("#areas").prop("selectedIndex", -1);
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
    $("#condominiosId").empty();

    $.each(retorno.Condominio, function () {
        var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');
        $("#condominiosId").append($("<option />").val(this.id)
        .text(this.nome + p.text() + this.num + p.text() + this.complemento + p.text() +
        this.item + p.text() + this.z + p.text() + this.d));
    });

    $("#condominiosId").prop("selectedIndex", -1);
}

function atualizaDropsDelegacao(retorno) {
    preencheArea(retorno);
    preencheLotes(retorno);
    preencheCondominio(retorno);

    postToController();
}

function atualizaDropsArea(retorno) {
    preencheLotes(retorno);
    preencheCondominio(retorno);
}

function atualizaDropsStatus(retorno) {
    preencheCondominio(retorno);
    postToController();
}