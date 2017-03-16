// Write your Javascript code.
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

function postToController() {
    var data = getFormDataAsJson();
    //, 'application/json; charset=utf-8'
    $.post('/Adesao/GetListLoteAtivoView', data, atualizaView);
}

function tabelaLoteAtivos(retorno) {
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
        tr.append("<td>" + retorno.EV[i].ultMotivo + "</td>");
        tr.append("<td>" + retorno.EV[i].agult + "</td>");
        tr.append("<td>" + retorno.EV[i].dtult + "</td>");
        tr.append("<td>" + retorno.EV[i].statusCl + "</td>");
        tr.append("<td>" + retorno.EV[i].dtStatusCl + "</td>");
        tr.append("<td>" + retorno.EV[i].casaStatus + "</td>");
        tr.append("<td>" + retorno.EV[i].visitado + "</td>");
        tr.append("<td>" + retorno.EV[i].visitas + "</td>");
        tr.append("<td>" + retorno.EV[i].ausentes + "</td>");
        tr.append("<td>" + retorno.EV[i].vendaApp + "</td>");
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

function tabelaEstatisticas(retorno) {
    for (var i = 0; i < retorno.Numeracoes.length; i++) {
        $('#e' + i).html(retorno.Numeracoes[i]);
    }

    for (var i = 0; i < retorno.Porcentagens.length; i++) {
        $('#ep' + i).html(retorno.Porcentagens[i] + '%');
    }

}

function atualizaView(retorno) {
    tabelaEstatisticas(retorno)
    tabelaLoteAtivos(retorno);
};

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

    $.post('/Adesao/LimpaFiltros', null, atualizaView);
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
    }

    return id;
}

function clickLote() {
    postToController();
}