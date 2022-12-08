using AdvocaciaPrincipal.models;
using System;
using Xunit;

namespace advocaciatddd
{
    public class TratamentoDeTextoTDD
    {
        [Fact]
        public void Retornarqtdetextosenai()
        {

            int esperado = 5;
            int resultado = 0;

            TratamentoDeTexto tratamento = new TratamentoDeTexto();
            resultado = tratamento.qtdDeTexto("SENAI");

            Assert.Equal(esperado, resultado);




        }
        [Fact]
        public void












    }
}
