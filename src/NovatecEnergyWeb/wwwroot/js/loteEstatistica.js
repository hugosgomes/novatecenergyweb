window.onload = function () {
    exibeLotesCliente();
};

function preencheTableLotes(lotesTableSelect) {
    $("corpoLotes tr").remove();

    var tr;
    var r = new Array();
    var j = -1;

    for (var i = 0; i < lotesTableSelect.length; i++) {

        r[++j] = "<tr>";
        r[++j] = "<td>";
       // r[++j] = lotesTableSelect[i]dtult;
        r[++j] = "</td>";
        r[++j] = "</tr>";
    }
    $('#corpoLotes').html(r.join(''));
}