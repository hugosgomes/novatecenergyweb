﻿window.onload = function () {
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

