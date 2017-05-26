

  /*------------------chamando as funcoes no onLoad loteEstatistica.js---------------------*/


    //carregando modulo visualization
    google.load("visualization", "1", { packages: ["corechart"] });

   
    function graficos() {

        /*---------grafico barras--------------*/
        //variavel com armazenamos os dados, um array de array's
        //no qual a primeira posição são os nomes das colunas
        var data = google.visualization.arrayToDataTable([
            ['Potencial', 'valor'],
            ['Contratados', 21],
            ['Não contratados', 25],


        ]);
        //opções para exibição do gráfico
        var options = {
            title: 'Potencial',//titulo do gráfico
            is3D: false, // false para 2d e true para 3d o padrão é false

        };
        //cria novo objeto PeiChart que recebe
        //como parâmetro uma div onde o gráfico será desenhado
        var chart = new google.visualization.PieChart(document.getElementById('chart_div'));
        //desenha passando os dados e as opções
        chart.draw(data, options);


        /*---------grafico barras--------------*/
        //montando o array com os dados
        var data = google.visualization.arrayToDataTable([
            ['Ano', 'Vendas', 'Despesas'],
            ['2004', 1000, 400],
            ['2005', 1170, 460],
            ['2006', 660, 1120],
            ['2007', 1030,  540]
        ]);

        /*-----------------------gráfico barras---------------------------------------*/
        //opçoes para o gráfico barras
        var options = {
            title: 'Performance',
            vAxis: {title: 'Anos', titleTextStyle: {color: 'red' } }//legenda vertical
        };
        //instanciando e desenhando o gráfico barras
        var barras = new google.visualization.BarChart(document.getElementById('barras'));
        barras.draw(data, options);

        
         /*-----------------------gráfico linhas---------------------------------------*/
        //opções para o gráfico linhas
        var options1 = {
            title: 'Performance',
            hAxis: {title: 'Anos', titleTextStyle: {color: 'red' } }//legenda na horizontal
        };
        //instanciando e desenhando o gráfico linhas
        var linhas = new google.visualization.LineChart(document.getElementById('linhas'));
        linhas.draw(data, options1);


        /*-----------------------gráfico colunas---------------------------------------*/
        //opções para o gráfico linhas
        var options1 = {
            title: 'Colunas',
            hAxis: { title: 'Anos', titleTextStyle: { color: 'red' } }//legenda na horizontal
        };
        //instanciando e desenhando o gráfico
        var coluna = new google.visualization.ColumnChart(document.getElementById('colunas'));
        coluna.draw(data, options1);

    }

