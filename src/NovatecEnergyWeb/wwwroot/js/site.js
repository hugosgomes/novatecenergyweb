﻿// Write your Javascript code.


$('#dtult').datepicker({
    format: "dd/mm/yyyy",
    todayBtn: "linked",
    language: "pt-BR",
    orientation: "bottom left"
});

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
    tabelaLoteAtivos(retorno);
};

function atualizaViewNao(retorno) {
    tabelaEstatisticas(retorno)
    tabelaLoteNao(retorno)
}

function montaHeadTabelaNao() {

    $('#headTabelaLote tr').remove();

    var tr = $('<tr/>');

    tr.append('<th class="text-center">Casa</th>');
    tr.append('<th class="text-center">Lote</th>');
    tr.append('<th class="text-center">AR</th>');
    tr.append('<th class="text-center">Localidade</th>');
    tr.append('<th class="text-center">Bairro</th>');
    tr.append('<th class="text-center">Endereço</th>');
    tr.append('<th class="text-center">PT</th>');
    tr.append('<th class="text-center">ULTMOTIVO</th>');
    tr.append('<th class="text-center">AGULT</th>');
    tr.append('<th class="text-center">DTULT</th>');
    tr.append('<th class="text-center">HRULT</th>');
    tr.append('<th class="text-center">CASASTATUS</th>');
    tr.append('<th class="text-center">Zid</th>');
    tr.append('<th class="text-center">Did</th>');
    tr.append('<th class="text-center">Aid</th>');
    tr.append('<th class="text-center">CondId</th>');
    tr.append('<th class="text-center">PtId</th>');
    tr.append('<th class="text-center">IdLote</th>');
    tr.append('<th class="text-center">STATUSCLID</th>');
    tr.append('<th class="text-center">CLID</th>');

    $('#headTabelaLote').append(tr);
};

function montaHeadLocal() {
    $('#headTabelaLote tr').remove();

    var tr = $('<tr/>');

    tr.append('<th class="text-center">Casa</th>');
    tr.append('<th class="text-center">Lote</th>');
    tr.append('<th class="text-center">Z</th>');
    tr.append('<th class="text-center">D</th>');
    tr.append('<th class="text-center">AR</th>');
    tr.append('<th class="text-center">PT</th>');
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
    tr.append('<th class="text-center">STATUSCL</th>');
    tr.append('<th class="text-center">DTSTATUSCL</th>');
    tr.append('<th class="text-center">CASASTATUS</th>');
    tr.append('<th class="text-center">Visitado</th>');
    tr.append('<th class="text-center">Contratado</th>');
    tr.append('<th class="text-center">VendaApp</th>');
    tr.append('<th class="text-center">Visitas</th>');
    tr.append('<th class="text-center">Entrevistas</th>');
    tr.append('<th class="text-center">Ausentes</th>');
    tr.append('<th class="text-center">Endinex</th>');
    tr.append('<th class="text-center">D2</th>');
    tr.append('<th class="text-center">SVG</th>');
    tr.append('<th class="text-center">SVE</th>');
    tr.append('<th class="text-center">Condomínio</th>');
    tr.append('<th class="text-center">CASOA</th>');
    tr.append('<th class="text-center">CASOB</th>');
    tr.append('<th class="text-center">CASOC</th>');
    tr.append('<th class="text-center">CASOD</th>');
    tr.append('<th class="text-center">DTULT2</th>');
    tr.append('<th class="text-center">HRULT</th>');

    $('#headTabelaLote').append(tr);
};

function postToController() {
    var data = getFormDataAsJson();
    //, 'application/json; charset=utf-8'
    $.post('/Adesao/GetListLoteAtivoView', data, atualizaView);
}

function postToControllerSemLote() {
    var data = getFormDataAsJson();
    $.post('/Adesao/GetListLoteNaoView', data, atualizaViewNao);
}

function tabelaLoteAtivos(retorno) {
    montaHeadLocal();

    $('#corpoTabelaAtivos tr').remove();

    var tr;

    for (var i = 0; i < retorno.EV.length; i++) {
        tr = $('<tr/>');

        tr.append("<td>" + retorno.EV[i].casa + "</td>");
        tr.append("<td>" + retorno.EV[i].lote + "</td>");
        tr.append("<td>" + retorno.EV[i].z + "</td>");
        tr.append("<td>" + retorno.EV[i].d + "</td>");
        tr.append("<td>" + retorno.EV[i].ar + "</td>");
        tr.append("<td>" + retorno.EV[i].pt + "</td>");
        tr.append("<td>" + retorno.EV[i].localidade + "</td>");
        tr.append("<td>" + retorno.EV[i].bairro + "</td>");
        tr.append("<td>" + retorno.EV[i].via + "</td>");
        tr.append("<td>" + retorno.EV[i].logradouro + "</td>");
        tr.append("<td>" + retorno.EV[i].num + "</td>");
        tr.append("<td>" + retorno.EV[i].complemento + "</td>");
        tr.append("<td>" + retorno.EV[i].bloco + "</td>");
        tr.append("<td>" + retorno.EV[i].apt + "</td>");
        
        if (retorno.EV[i].ultMotivo == null) {
            tr.append("<td></td>");
        } else {
            tr.append("<td>" + retorno.EV[i].ultMotivo + "</td>");
        }
        
        if (retorno.EV[i].agult == null) {
            tr.append("<td></td>");
        } else {
            tr.append("<td>" + retorno.EV[i].agult + "</td>");
        }
        
        tr.append("<td>" + retorno.EV[i].dtult + "</td>");
        tr.append("<td>" + retorno.EV[i].statusCl + "</td>");
        tr.append("<td>" + retorno.EV[i].dtStatusCl + "</td>");      
        tr.append("<td>" + retorno.EV[i].casaStatus + "</td>");
        tr.append("<td>" + retorno.EV[i].visitado + "</td>");
        tr.append("<td>" + retorno.EV[i].contratado + "</td>");
        tr.append("<td>" + retorno.EV[i].vendaApp + "</td>");
        tr.append("<td>" + retorno.EV[i].visitas + "</td>");
        tr.append("<td>" + retorno.EV[i].entrevistas + "</td>");
        tr.append("<td>" + retorno.EV[i].ausencias + "</td>");
        tr.append("<td>" + retorno.EV[i].endinex + "</td>");
        tr.append("<td>" + retorno.EV[i].d2 + "</td>");
        tr.append("<td>" + retorno.EV[i].svg + "</td>");
        tr.append("<td>" + retorno.EV[i].sve + "</td>");
        tr.append("<td>" + retorno.EV[i].condominio + "</td>");
        tr.append("<td>" + retorno.EV[i].casoA + "</td>");
        tr.append("<td>" + retorno.EV[i].casoB + "</td>");
        tr.append("<td>" + retorno.EV[i].casoC + "</td>");
        tr.append("<td>" + retorno.EV[i].casoD + "</td>");
        tr.append("<td>" + retorno.EV[i].dtult2 + "</td>");
        tr.append("<td>" + retorno.EV[i].hrult + "</td>");
        $('#corpoTabelaAtivos').append(tr);
    }

};

function tabelaLoteNao(retorno) {
    // montaHeadTabelaNao();
    montaHeadTabelaNao();

    $('#corpoTabelaAtivos tr').remove();
    
    var tr;

    for (var i = 0; i < retorno.EV.length; i++) {
        tr = $('<tr/>');

        tr.append("<td>" + retorno.EV[i].casa + "</td>");
        tr.append("<td>" + retorno.EV[i].lote + "</td>");
        tr.append("<td>" + retorno.EV[i].ar + "</td>");
        tr.append("<td>" + retorno.EV[i].localidade + "</td>");
        tr.append("<td>" + retorno.EV[i].bairro + "</td>");
        tr.append("<td>" + retorno.EV[i].endereco + "</td>");
        tr.append("<td>" + retorno.EV[i].pt + "</td>");
        tr.append("<td>" + retorno.EV[i].ultMotivo + "</td>");
        tr.append("<td>" + retorno.EV[i].agult + "</td>");
        tr.append("<td>" + retorno.EV[i].dtult + "</td>");
        tr.append("<td>" + retorno.EV[i].hrult + "</td>");
        tr.append("<td>" + retorno.EV[i].casaStatus + "</td>");
        tr.append("<td>" + retorno.EV[i].zid + "</td>");
        tr.append("<td>" + retorno.EV[i].aid + "</td>");
        tr.append("<td>" + retorno.EV[i].condid + "</td>");
        tr.append("<td>" + retorno.EV[i].ptId + "</td>");
        tr.append("<td>" + retorno.EV[i].idLote + "</td>");
        tr.append("<td>" + retorno.EV[i].statusClid + "</td>");
        tr.append("<td>" + retorno.EV[i].clid + "</td>");


        $('#corpoTabelaAtivos').append(tr);
    }

};

function tabelaEstatisticas(retorno) {
    for (var i = 0; i < retorno.Numeracoes.length; i++) {
        $('#e' + i).html(retorno.Numeracoes[i]);
    }

    for (var j = 0; j < retorno.Porcentagens.length; j++) {
        $('#ep' + j).html(retorno.Porcentagens[j] + '%');
    }

}

function limpaFiltro() {
    $('#lotes').val("");
    $('#CasaStatus').val("");
    $('#motivosRejeicao').val("");
    $('#dtult').val("");
    $('#clientesCeg').val("");
    $('#zonas').val("");
    $('#delegacoes').val("");
    $('#areas').val("");
    $('#statusCond').val("");
    $('#condominiosId').val("");
    $('#CondNome').val("");
    $('#Localidade').val("");
    $('#Bairro').val("");
    $('#Logradouro').val("");
    $('#Numero1').val("");
    $('#Numero2').val("");

    var parametro = {};
    parametro.Botao = clicado();
    parametro.LimpaFiltro = true;


    if ($("#todosli").hasClass('disabled')) {
        id = 'todos';
    } else if ($("#ativosli").hasClass('disabled')) {
        id = 'ativos';
    } else if ($("#semLoteTodosli").hasClass('disabled')) {
        id = 'semLoteTodos';
    } else if ($("#semLoteNaoli").hasClass('disabled')) {
        id = 'semLoteNao';
    }

    if ((parametro.Botao == 'todos') || (parametro.Botao == 'ativos')) {
        $.post('/Adesao/LimpaFiltros', parametro, bindSelects);

    }
    else {
        $.post('/Adesao/LimpaFiltrosNao', parametro, atualizaViewNao);
    }
}

function bindSelects(retorno) {
    atualizaView(retorno);
    var parametro = {};
    
    parametro.LimpaFiltro = true;
    $.post('/Adesao/LimpaSelects', parametro, atualizaSelects);
}

function atualizaSelects(retorno) {

    $('#lotes').empty();
    $('#motivosRejeicao').empty();
    $('#zonas').empty();
    $('#delegacoes').empty();
    $('#areas').empty();
    $('#statusCond').empty();
    $('#condominiosId').empty();

    var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');

    for (var i = 0; i < retorno.Lotes.length; i++) {
        $("#lotes").append($("<option />").val(retorno.Lotes[i][0]).text(retorno.Lotes[i][1] + p.text()
              + retorno.Lotes[i][2] + p.text()
              + retorno.Lotes[i][3] + p.text()
              + retorno.Lotes[i][4]));
    }

    for (var i = 0; i <  retorno.MotivosRejeicao.length; i++) {
        $('#motivosRejeicao').append($("<option />").val(retorno.MotivosRejeicao[i].id).text(retorno.MotivosRejeicao[i].motivo));
    }

    for (var i = 0; i < retorno.Zonas.length; i++) {
        $('#zonas').append($("<option />").val(retorno.Zonas[i].id).text(retorno.Zonas[i].zona));
    }

    for (var i = 0; i < retorno.Delegacao.length; i++) {
        $('#delegacoes').append($("<option />").val(retorno.Delegacao[i].id).text(retorno.Delegacao[i].delegacao));
    }

    for (var i = 0; i < retorno.Areas.length; i++) {
        $('#areas').append($("<option />").val(retorno.Areas[i].id).text(retorno.Areas[i].area));
    }

    for (var i = 0; i < retorno.StatusCondominios.length; i++) {
        $('#statusCond').append($("<option />").val(retorno.StatusCondominios[i].id).text(retorno.StatusCondominios[i].item));
    }

    for (var i = 0; i < retorno.ListaCondominios.length; i++) {
        var b = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');
        $('#condominiosId').append($("<option />").val(retorno.ListaCondominios[i].id).text(retorno.ListaCondominios[i].nome +
            b.text() +
            retorno.ListaCondominios[i].num + b.text() + retorno.ListaCondominios[i].complemento + b.text() +
            retorno.ListaCondominios[i].item + b.text() + retorno.ListaCondominios[i].z + b.text()
            + retorno.ListaCondominios[i].d))
    }

    $("#lotes").prop("selectedIndex", -1);
    $('#CasaStatus').prop("selectedIndex", -1);
    $('#motivosRejeicao').prop("selectedIndex", -1);
    $('#zonas').prop("selectedIndex", -1);
    $('#delegacoes').prop("selectedIndex", -1);
    $('#areas').prop("selectedIndex", -1);
    $('#statusCond').prop("selectedIndex", -1);
    $('#condominiosId').prop("selectedIndex", -1);

}

function ExportaPadraoNovatec() {
    var data = getFormDataAsJson();
    //   $.get('/Adesao/ExportaExcel', data, DownloadExcel); //loteAtivo=' + JSON.stringify(data)
    //  window.location = '/Adesao/ExportaExcel?loteAtivo=' + JSON.stringify(data);
    window.location.href = '/Adesao/ExportaExcel?loteAtivo=' + JSON.stringify(data);
}

function ExportaPadraoGas() {
    var data = getFormDataAsJson();
    //   $.get('/Adesao/ExportaExcel', data, DownloadExcel); //loteAtivo=' + JSON.stringify(data)
    //  window.location = '/Adesao/ExportaExcel?loteAtivo=' + JSON.stringify(data);
    var lc = $('#lotes').val();

    if (lc != null) {
        window.location.href = '/Adesao/ExportaPadraoGasNatural?loteAtivo=' + JSON.stringify(data);
    } else {
        alert('Selecione um lote');
    }
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

function postZona() {
    var p = {};
    p.zona = $("#zonas").val();
    $.post('/Adesao/ZonaCascade', p, atualizaDropsZona);

}

function atualizaDropsZona(retorno) {
    $("#delegacoes").empty();
    $("#areas").empty();
    $("#lotes").empty();
    $("#condominiosId").empty();


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

    $.each(retorno.Condominio, function () {
        var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');
        $("#condominiosId").append($("<option />").val(this.id)
        .text(this.nome + p.text() + this.num + p.text() + this.complemento + p.text()+
        this.item + p.text() + this.z + p.text()+this.d));
    });

    $("#lotes").prop("selectedIndex", -1);
    $("#delegacoes").prop("selectedIndex", -1);
    $("#areas").prop("selectedIndex", -1);
    $("#condominiosId").prop("selectedIndex", -1);
}

function postDelegacao() {
    var p = {};
    p.delegacao = $("#delegacoes").val();
    $.post('/Adesao/DelegacaoCascade', p, atualizaDropsDelegacao);
}

function atualizaDropsDelegacao(retorno) {
    $("#areas").empty();
    $("#lotes").empty();
    $("#condominiosId").empty();

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

    $.each(retorno.Condominio, function () {
        var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');
        $("#condominiosId").append($("<option />").val(this.id)
        .text(this.nome + p.text() + this.num + p.text() + this.complemento + p.text() +
        this.item + p.text() + this.z + p.text() + this.d));
    });
    
    $("#lotes").prop("selectedIndex", -1);
    $("#areas").prop("selectedIndex", -1);
    $("#condominiosId").prop("selectedIndex", -1);
}

function postArea() {
    var p = {};

    p.area = $("#areas").val();
    $.post('/Adesao/AreaCascade', p, atualizaDropsArea);
}

function atualizaDropsArea(retorno) {
    $("#lotes").empty();
    $("#condominiosId").empty();

    $.each(retorno.Lote, function () {
        var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');

        $("#lotes").append($("<option />").val(this.id).text(this.loteNum + p.text()
              + this.ge + p.text()
              + this.dataLote + p.text()
              + this.item));
    });

    $.each(retorno.Condominio, function () {
        var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');
        $("#condominiosId").append($("<option />").val(this.id)
        .text(this.nome + p.text() + this.num + p.text() + this.complemento + p.text() +
        this.item + p.text() + this.z + p.text() + this.d));
    });

    $("#lotes").prop("selectedIndex", -1);
    $("#condominiosId").prop("selectedIndex", -1);
}

function postLote() {
    var p = {};

    p.lote = $("#lotes").val();
    $.post('/Adesao/LoteCascade', p, atualizaDropsLote);
}

function atualizaDropsLote(retorno) {
    $("#condominiosId").empty();

    $.each(retorno.Condominio, function () {
        var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');
        $("#condominiosId").append($("<option />").val(this.id)
        .text(this.nome + p.text() + this.num + p.text() + this.complemento + p.text() +
        this.item + p.text() + this.z + p.text() + this.d));
    });

    $("#condominiosId").prop("selectedIndex", -1);
}

function postStatusCond() {
    var p = {};

    p.status = $("#statusCond").val();
    p.area = $("#areas").val();
    $.post('/Adesao/StatusCliCascade', p, atualizaDropsStatus);
}

function atualizaDropsStatus(retorno) {
    $("#condominiosId").empty();
    
    $.each(retorno.Condominio, function () {
        var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');
        $("#condominiosId").append($("<option />").val(this.id)
        .text(this.nome + p.text() + this.num + p.text() + this.complemento + p.text() +
        this.item + p.text() + this.z + p.text() + this.d));
    });

    $("#condominiosId").prop("selectedIndex", -1);
}


