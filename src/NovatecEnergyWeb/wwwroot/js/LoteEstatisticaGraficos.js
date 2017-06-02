

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
        var v2 = Math.floor(estatistica[i].mtpot * 100);

        dados.push([v1,v2]);
      
        
    }

   /* for (var i = 0; i < dados.length; i++) {

        alert(dados[i]);
    }*/


        var data = google.visualization.arrayToDataTable(dados);
    
        //opções para o gráfico colunas
        var options1 = {
            title: 'Resultados sobre as unidades potenciais', 'height': 300,
            //hAxis: { title: 'Resultados sobre as unidades visitadas', titleTextStyle: { color: 'red' } }//legenda na horizontal
        };

        //instanciando e desenhando o gráfico
        var coluna = new google.visualization.ColumnChart(document.getElementById('colunas'));
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
            title: 'Resultados sobre as unidades visitadas',//titulo do gráfico
            is3D: false, // false para 2d e true para 3d o padrão é false

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
            title: 'Resultados sobre as unidades entrevistadas',//titulo do gráfico
            is3D: false, // false para 2d e true para 3d o padrão é false

        };


        //instanciando e desenhando o gráfico
        var chart = new google.visualization.PieChart(document.getElementById('entrevistados'));
        chart.draw(data3, options);



    }

