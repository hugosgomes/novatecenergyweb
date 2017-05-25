window.onload = function () {
    exibeLotes();
};


function preencheTableLotes(lotesTableSelect) {
    $("corpoLotes tr").remove();

    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < lotesTableSelect.length; i++) {

        r[++j] = '<tr id="lote_'+ lotesTableSelect[i][0].toString()+ '" class="mouse-hand">';
        r[++j] = '<td>';
        r[++j] = lotesTableSelect[i][1];
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = lotesTableSelect[i][2];
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = lotesTableSelect[i][3];
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = lotesTableSelect[i][4];
        r[++j] = '</td>';
        r[++j] = '</tr>';
    }
    $('#corpoLotes').html(r.join(''));

    adicionaEventoClickRow();
    
}

function adicionaEventoClickRow() {
    var table = document.getElementById("tableLote");
    var rows = table.rows; 
    for (var i = 0; i < rows.length; i++) {
        rows[i].onclick = (function () {
            return function () {
                var idLote = this.id.toString().split('_')[1];
                getEstatisticaByLote(idLote);
            }
        })(i);
    }
}

function atualizaTabelas(estatistica) {
    preencheTableStatus(estatistica);
    preencheTableEstatistica(estatistica)
}

function preencheTableStatus(estatistica) {
    $("corpoStatus tr").remove();

    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < estatistica.length; i++) {
        r[++j] = '<tr>';
        r[++j] = '<td>';
        r[++j] = estatistica[i].umt;
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = estatistica[i].qmt;
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = Math.floor(estatistica[i].mtpot * 100).toString()+'%';
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = Math.ceil(estatistica[i].mtvis * 100).toString() + '%';
        r[++j] = '</td>';
        r[++j] = '<td>';
        r[++j] = Math.floor(estatistica[i].mtent * 100).toString() + '%';
        r[++j] = '</td>';
        r[++j] = '</tr>';
    }
    $('#corpoStatus').html(r.join(''));
}

function preencheTableEstatistica(estatistica) {
    $("corpoEstatistica tr").remove();

    if (estatistica.length > 0) {

        // potencial
        $('#potNum').html(estatistica[0].pot);

        // visitados
        $('#visNum').html(estatistica[0].vis);
        $('#visSpot').html(Math.ceil((estatistica[0].vis / estatistica[0].pot) * 100).toString() + '%');

        //entrevistados
        $('#entNum').html(estatistica[0].ent);
        $('#entSpot').html(Math.ceil((estatistica[0].ent / estatistica[0].pot) * 100).toString() + '%');
        $('#entVis').html(Math.ceil((estatistica[0].ent / estatistica[0].vis) * 100).toString() + '%');

        //contratados
        $('#conNum').html(estatistica[0].con);
        $('#conPot').html(Math.ceil((estatistica[0].con / estatistica[0].pot) * 100).toString() + '%');
        $('#conVis').html(Math.ceil((estatistica[0].con / estatistica[0].vis) * 100).toString() + '%');
        $('#conEnt').html(Math.ceil((estatistica[0].con / estatistica[0].ent) * 100).toString() + '%');

        //nao visitados
        $('#naoVisiNum').html(estatistica[0].pot - estatistica[0].vis);
        $('#naoVisiPot').html(Math.ceil(((estatistica[0].pot - estatistica[0].vis) / estatistica[0].pot) * 100).toString() + '%');
        $('#')

        //nao entrevistado
        $('#naoEntNum').html(estatistica[0].pot - estatistica[0].ent);
        $('#naoEntSpot').html(Math.ceil(((estatistica[0].pot - estatistica[0].ent) / estatistica[0].pot) * 100).toString() + '%');

        //visitados nao entrevistados
        $('#visNaoEntNum').html(estatistica[0].pot - estatistica[0].ent); 
        $('#visNaoEntSpot').html(Math.ceil(((estatistica[0].vis - estatistica[0].ent) / estatistica[0].pot) * 100).toString() + '%');
        $('#visNaoEntSvis').html(Math.ceil(((estatistica[0].vis - estatistica[0].ent) / estatistica[0].vis) * 100).toString() + '%');

        // nao contratados
        $('#naoContNum').html(estatistica[0].pot - estatistica[0].con); 
        $('#naoContSpot').html(Math.ceil(((estatistica[0].pot - estatistica[0].con) / estatistica[0].pot) * 100).toString() + '%');

        //visitados nao contratados
        $('#visNaoContNum').html(estatistica[0].vis - estatistica[0].con);
        $('#visNaoContSpot').html(Math.ceil(((estatistica[0].vis - estatistica[0].con) / estatistica[0].pot) * 100).toString() + '%');
        $('#visNaoContSvis').html(Math.ceil(((estatistica[0].vis - estatistica[0].con) / estatistica[0].vis) * 100).toString() + '%');

        //entrevistados nao contratados
        $('#entNaoContNum').html(estatistica[0].ent - estatistica[0].con);
        $('#entNaoContSpot').html(Math.ceil(((estatistica[0].ent - estatistica[0].con) / estatistica[0].pot) * 100).toString() + '%');
        $('#entNaoContSvis').html(Math.ceil(((estatistica[0].ent - estatistica[0].con) / estatistica[0].vis) * 100).toString() + '%');
        
        //d2  contratados
        $('#dContNum').html(estatistica[0].d2);
        $('#dContSpot').html(Math.ceil((estatistica[0].d2 / estatistica[0].pot)  * 100).toString() + '%');
        $('#dContSvis').html(Math.ceil((estatistica[0].d2 / estatistica[0].vis) * 100).toString() + '%');
        $('#dContSent').html(Math.ceil((estatistica[0].d2 / estatistica[0].ent) * 100).toString() + '%');

        //svg  contratados
        $('#svgContNum').html(estatistica[0].svg);
        $('#svgContSpot').html(Math.ceil((estatistica[0].svg / estatistica[0].pot) * 100).toString() + '%');
        $('#svgContSvis').html(Math.ceil((estatistica[0].svg / estatistica[0].vis) * 100).toString() + '%');
        $('#svgContSent').html(Math.ceil((estatistica[0].svg / estatistica[0].ent) * 100).toString() + '%');

        //sve  contratados
        $('#sveContNum').html(estatistica[0].sve);
        $('#sveContSpot').html(Math.ceil((estatistica[0].sve / estatistica[0].pot) * 100).toString() + '%');
        $('#sveContSvis').html(Math.ceil((estatistica[0].sve / estatistica[0].vis) * 100).toString() + '%');
        $('#sveContSent').html(Math.ceil((estatistica[0].sve / estatistica[0].ent) * 100).toString() + '%');

        //visitas realizadas
        $('#visRealiNum').html(estatistica[0].visx);

        //entrevistas realizadas
        $('#entRealiNum').html(estatistica[0].entx);
        $('#entRealiSvis').html(Math.ceil((estatistica[0].entx / estatistica[0].visx) * 100).toString() + '%');

        //visitas improdutivas
        $('#visImproNum').html(estatistica[0].visx - estatistica[0].entx );
        $('#visImproSvis').html(Math.ceil(((estatistica[0].visx - estatistica[0].entx) / estatistica[0].visx) * 100).toString() + '%');
    } 

    
}

