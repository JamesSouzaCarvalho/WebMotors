
function gerarGraficoMetaDiaria(dados) {

    var contexto = document.getElementsByClassName("grafico-meta-diaria");

    new Chart(contexto, {
        type: 'line',
        data: {
            labels: [dados.Mes],
            datasets: [{
                label: "Meta",
                data: [dados.ValorMeta],
                borderWidth: 3,
                borderColor: 'rgba(0, 0, 255, 1)',
                backgroundColor: 'transparent'
            },
            {
                label: "Vendas",
                data: [dados.Valor],
                borderWidth: 3,
                borderColor: 'rgba(200, 0, 0, 0.7)',
                backgroundColor: 'transparent'
            }]
        },
        options: {
            title: {
                display: true,
                fontSize: 30,
                text: 'Meta - Diária'
            },
            tooltips: {
                enabled: true
            },
            scales: {
                yAxes: [{
                    display: true,
                    scaleLabel: {
                        display: true,
                        labelString: 'Valores'
                    },
                    ticks: {
                        callback: function (value) {
                            return 'R$ ' + value;
                        }
                    }
                }],
                xAxes: [{
                    display: true,
                    scaleLabel: {
                        display: true,
                        labelString: 'Meses'
                    }
                }]
            }
        }
    });
}



//Criar Gráfico Vazio
var ctx = document.getElementById("grafico-meta-anual");
var grafico = new Chart(ctx, {
    type: 'bar',
    data: {
        labels: [],
        datasets: [{
            label: 'Meta',
            data: [],
            borderWidth: 1,
            backgroundColor: '#1E90FF',
            borderColor: '#00008B'
        },
        {
            label: 'Venda',
            data: [],
            borderWidth: 1,
            backgroundColor: '#98FB98',
            borderColor: '#2E8B57'
        }]
    },
    options: {
        responsive: true,
        title: {
            display: true,
            text: "Metas Mensais - 2020"
        },
        legend: {
            display: true
        },
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true,
                    //Define Moeda R$ no resultado do eixo Y
                    callback: function (value) {
                        return (value).toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
                    }
                }
            }]
        },
        tooltips: {
            callback: {
                value: function (value) {
                    return (value).toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
                }
            }
        }
    }
});

function gerarGraficoMetaAnual() {
    $.ajax({
        url: '../Meta/DadosMeta',
        success: function (data) {

            $.each(data, function (i, obj) {
                grafico.data.labels.push(obj.MesNome.toUpperCase());
                grafico.data.datasets[0].data.push(obj.ValorMeta);
            });

            grafico.update();
        }   
    });
    $.ajax({
        url: '../Venda/DadosVenda',
        success: function (data) {

            $.each(data, function (i, obj) {
                //grafico.data.labels.push(obj.MesNome.toUpperCase());
                grafico.data.datasets[1].data.push(obj.ValorVenda);
            });

            grafico.update();
        }
    });

};



