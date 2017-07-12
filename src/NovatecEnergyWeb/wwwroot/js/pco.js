window.onload = function () {

    getZona();
    getDelegacao();
    getPco();
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

///////////////////////////////////////////////////////////////////////////
function listaPco(retorno) {

    alert("ok");
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




