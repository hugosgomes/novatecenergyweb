window.onload = function () {
    exibeLotes();
};

function preencheTableLotes(lotesTableSelect) {
    $("corpoLotes tr").remove();

    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < lotesTableSelect.length; i++) {

        r[++j] = '<tr class="mouse-hand">';
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
    
}