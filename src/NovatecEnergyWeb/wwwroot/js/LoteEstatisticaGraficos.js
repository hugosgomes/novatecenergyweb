

  /*------------------chamando as funcoes no onLoad loteEstatistica.js---------------------*/


    //carregando modulo visualization
    google.load("visualization", "1", { packages: ["corechart"] });

   
function graficos(estatistica) {

    /*---------grafico colunas--------------*/
    //montando o array com os dados

    var dados = new Array(

        ["Status", "Potenciais"]
       

    );

    for (var i = 0; i < estatistica.length; i++) {

        var v1 = estatistica[i].umt;
      //var v2 = Math.floor(estatistica[i].mtpot * 100);
        var v2 = estatistica[i].mtpot;

        dados.push([v1,v2]);
      
        
    }

   /* for (var i = 0; i < dados.length; i++) {

        alert(dados[i]);
    }*/


        var data = google.visualization.arrayToDataTable(dados);
    
        //opções para o gráfico colunas
        var options1 = {
            title: 'Resultados sobre as unidades potenciais', 'height': 315,          
            hAxis: { textStyle: { fontSize: 10 },  },        
            vAxis: {format: 'percent'  }//legenda na vertical
        
            
        };

        //instanciando e desenhando o gráfico
        var coluna = new google.visualization.ColumnChart(document.getElementById('colunas'));
        var formatter = new google.visualization.NumberFormat({ pattern: '#%' });
        formatter.format(data, 1);

        coluna.draw(data, options1);

        
        /*---------grafico pizza visitadas--------------*/

        //montando o array com os dados
        var dados2 = new Array(

            ["Status", "Potenciais"]


        );

        for (var i = 0; i < estatistica.length; i++) {

            var v1 = estatistica[i].umt;
            var v2 = Math.floor(estatistica[i].mtvis * 100);

            dados2.push([v1, v2]);


        }

        var data2 = google.visualization.arrayToDataTable(dados2);

        //opções para exibição do gráfico
        var options = {
            title: 'Resultados sobre as unidades visitadas', 'height': 260,//titulo do gráfico
            is3D: false, // false para 2d e true para 3d o padrão é false
            fontSize: 10,
            titleTextStyle: {fontSize:13}

        };


        //instanciando e desenhando o gráfico
        var chart = new google.visualization.PieChart(document.getElementById('visitadas'));
        chart.draw(data2, options);




        /*---------grafico pizza entrevistados--------------*/

        //montando o array com os dados
        var dados3 = new Array(

            ["Status", "Potenciais"]


        );

        for (var i = 0; i < estatistica.length; i++) {

            var v1 = estatistica[i].umt;
            var v2 = Math.floor(estatistica[i].mtent * 100);

            dados3.push([v1, v2]);


        }

        var data3 = google.visualization.arrayToDataTable(dados3);

        //opções para exibição do gráfico
        var options = {
            title: 'Resultados sobre as unidades entrevistadas', 'height': 260,//titulo do gráfico
            is3D: false, // false para 2d e true para 3d o padrão é false
            pieHole: 0.3,
            fontSize: 10,
            titleTextStyle: { fontSize: 13 }
        };


        //instanciando e desenhando o gráfico
        var chart = new google.visualization.PieChart(document.getElementById('entrevistados'));
        chart.draw(data3, options);




}

