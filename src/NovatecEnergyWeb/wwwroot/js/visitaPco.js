window.onload = function () {
    getZona();
    getDelegacao();
    getArea();
    getLotes();
    getInteresse();
    getTipoVisita();
    getRejeicaoPco();
};

function getFormDataAsJson(){
    return {
        
        CasaStatus: $('#CasaStatus').val(),
        IdultMotivo: $('#motivosRejeicao').val(),
        Dtult: $('#dtult').val(),
        ClId: $('#clientesCeg').val(),
       
        ZId: $('#zonas').val(),
        DId: $('#delegacoes').val(),
        AId: $('#areas').val(),
        IdLote: $('#lotes').val(),

        StatusId: $('#statusCond').val(),
        CondId: $('#condominiosId').val(),
        CondNome: $('#CondNome').val().toString().trim(),
        Localidade: $('#Localidade').val().toString().trim(),
        Bairro: $('#Bairro').val().toString().trim(),
        Logradouro: $('#Logradouro').val().toString().trim(),
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

