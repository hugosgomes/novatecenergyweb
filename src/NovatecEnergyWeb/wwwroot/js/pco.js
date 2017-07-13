window.onload = function () {

    getZona();
    getDelegacao();
    getStatus();
    getPco(1);
};





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

//////////////////////////////////
/////////////////////////////////
function listaPco(retorno) {


        montaPaginacao(retorno);

  
        // preenche a tabela
        var tr;
        var r = new Array();
        var j = -1;

        for (var i = 0; i < retorno.length; i++) {



            r[++j] = '<tr>';


            r[++j] = '<td>';
            r[++j] = retorno[i].id;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].num;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].complemento;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].nome;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].status;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].distrede;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].instInternas;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].energiaAtual;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].contato;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].telefone;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].celular;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].email;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].localidade;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].bairro;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].logradouro;
            r[++j] = '</td>';

            r[++j] = '<td>';
            r[++j] = retorno[i].via;
            r[++j] = '</td>';


            r[++j] = '</tr>';

        }

        $('#corpoTabelaAtivos').html(r.join(''));


}


//////////////////////////////////
/////////////////////////////////
function listaPco2(retorno) {



   
    // preenche a tabela
    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < retorno.length; i++) {



        r[++j] = '<tr>';


        r[++j] = '<td>';
        r[++j] = retorno[i].id;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].num;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].complemento;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].nome;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].status;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].distrede;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].instInternas;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].energiaAtual;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].contato;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].telefone;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].celular;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].email;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].localidade;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].bairro;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].logradouro;
        r[++j] = '</td>';

        r[++j] = '<td>';
        r[++j] = retorno[i].via;
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

        listaPco2(num);

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


/////////////////////////////////////////////////
//   filtros em cascata
////////////////////////////////////////////////

function atualizaDropsZona(retorno) {

    preencheDelegacao(retorno);
   
}



function preencheDelegacao(retorno) {
    $("#delegacao").empty();

    $.each(retorno.Delegacao, function () {
        $("#delegacao").append($("<option />").val(this.id).text(this.delegacao));
    });

    $("#delegacao").prop("selectedIndex", -1);
}


///////////////////////////////////////////////////////////////////////////
function listaStatus(retorno) {

    // listando todos os objetos produto que contem no array
    for (i = 0; i < retorno.length; i++) {

        var cols = "";

        cols += '<option value="' + retorno[i].id + '">' + retorno[i].item + '</option>';

        $("#status").append(cols);

    }

    if (document.getElementById("status").length == 1) {
        $("#status").prop("selectedIndex", 0);
        $("#status").attr('disabled', 'disabled'); // desativa o seletor
    } else {
        $("#status").prop("selectedIndex", -1); // limpa a seleção após carregar
    }

  
}

