$("#lotes").prop("selectedIndex", -1);
$("#zonas").prop("selectedIndex", -1);
$("#delegacoes").prop("selectedIndex", -1);
$("#areas").prop("selectedIndex", -1);

window.onload = function () {
    postToController();
    selecionaInfoCliente();
};

function getFormDataAsJson() {
    var botaoClicado = clicado();

    return {
        IdLote: $('#lotes').val(),
        ZId: $('#zonas').val(),
        DId: $('#delegacoes').val(),
        AId: $('#areas').val(),
        Endereco: $('#Endereco').val().toString().trim(),

        Botao: botaoClicado
    }
}

//não usada mais
function clicado() {
    var id = '';
    if ($('#todos').data('clicked')) {
        $('#todos').data('clicked', false);
        id = 'todos';
        $('#todosli').addClass('disabled');
        $('#ativosli').removeClass('disabled');

    } else if ($('#ativos').data('clicked')) {
        $('#ativos').data('clicked', false);
        id = 'ativos';
        $('#todosli').removeClass('disabled')
        $('#ativosli').addClass('disabled');
    } else if (id == '') {
        if ($("#todosli").hasClass('disabled')) {
            id = 'todos';
        } else if ($("#ativosli").hasClass('disabled')) {
            id = 'ativos';
        }
    }

    return id;
}

function atualizaView(retorno) {
    tabelaEstatisticas(retorno);
    montaPaginacao(retorno);
    tabelaLoteAtivos(retorno);
};

function tabelaEstatisticas(retorno) {
    for (var i = 0; i < retorno.Numeracoes.length; i++) {
        $('#e' + i).html(retorno.Numeracoes[i]);
    }

    for (var j = 0; j < retorno.Porcentagens.length; j++) {
        $('#ep' + j).html(retorno.Porcentagens[j] + '%');
    }
};

function tabelaLoteAtivos(retorno) {
    $('#corpoTabelaAtivos tr').remove();

    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < retorno.EV.length; i++) {

        r[++j] = "<tr>";
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
        r[++j] = retorno.EV[i].endereco;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].potencial;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].visitados;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].contratados;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].d2;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].svg;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].sve;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].visitas;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].entrevistas;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].visitasImpr;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].visitasAgendadas;
        r[++j] = "</td>";
        r[++j] = "<td>";
        r[++j] = retorno.EV[i].ausencias;
        r[++j] = "</td>";


        r[++j] = "</tr>";
    }

    $('#corpoTabelaAtivos').html(r.join(''));
}

function atualizaDropZona(retorno) {
    preencheDelegacao(retorno);
    preencheArea(retorno);
    preencheLotes(retorno);
    postToController();
}

function preencheZona(retorno) {
    $('#zonas').empty();

    $.each(retorno.Zonas, function () {
        $("#zonas").append($("<option />").val(this.id).text(this.zona));
    });

    $("#zonas").prop("selectedIndex", -1);
}

function preencheDelegacao(retorno) {
    $("#delegacoes").empty();

    $.each(retorno.Delegacao, function () {
        $("#delegacoes").append($("<option />").val(this.id).text(this.delegacao));
    });

    $("#delegacoes").prop("selectedIndex", -1);
}


function preencheArea(retorno) {
    if (retorno.Areas.length > 0) {
        $("#areas").empty();

        $.each(retorno.Areas, function () {
            $("#areas").append($("<option />").val(this.id).text(this.area));
        });

        $("#areas").prop("selectedIndex", -1);
    }
}

function preencheLotes(retorno) {
    //  if (retorno.Lotes.length > 0) {
    $("#lotes").empty();

    $.each(retorno.Lotes, function () {
        var p = $('<p>').html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;');

        $("#lotes").append($("<option />").val(this[0]).text(this[1] + p.text()
            + this[2] + p.text()
            + this[3] + p.text()
            + this[4] + p.text()));
    });

    $("#lotes").prop("selectedIndex", -1);
    //   }
}


function atualizaDropsDelegacao(retorno) {
    preencheArea(retorno);
    preencheLotes(retorno);
    postToController();
}

function atualizaDropArea(retorno) {
    preencheLotes(retorno);
    postToController();
}

function atualizaSelects(retorno) {
    preencheZona(retorno);
    preencheDelegacao(retorno);
    preencheArea(retorno);
    preencheLotes(retorno);
    selecionaInfoCliente();
}

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

//usado na combo de lote para acrescentar o atributo data-toggle pra abrir a telinha de exportação
function atribuiDataToggle() {
    var vatt = $('#botaoExporta').attr('data-toggle');
    if (vatt == null) {
        $('#botaoExporta').attr('data-toggle', 'modal');
    }
}