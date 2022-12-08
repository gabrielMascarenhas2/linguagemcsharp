using AdvocaciaPrincipal.models;
using System;
using Xunit;

namespace advocaciatddd
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            advogado ad = new advogado();
            ad.idade = 20;
            bool esperado = true;
            bool resultado = false;

            resultado = ad.verificarseadvogadoemaiorqueidade();
            Assert.Equal(esperado, resultado);
        }
    }
}
