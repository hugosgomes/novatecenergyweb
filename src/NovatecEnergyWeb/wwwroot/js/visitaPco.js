window.onload = function () {
    getZona();
    getDelegacao();
    getArea();
    getLotes();
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
        Numero2: $('#Numero2').val(),
        Botao: botaoClicado
    }
}