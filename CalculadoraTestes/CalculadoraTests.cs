using Calculadora.Services;

namespace CalculadoraTestes
{
    public class CalculadoraTests
    {
        private CalculadoraImp _calc;

        public CalculadoraTests()
        {
            _calc = new CalculadoraImp();
        }

        [Theory]
        [InlineData(new int[] { 2, 2 }, 4)]
        [InlineData(new int[] { 3, 3 }, 6)]
        public void SomarTeste(int[] num, int resultado)
        {
            int soma = _calc.Somar(num[0], num[1]);
            Assert.Equal(resultado, soma);
        }

        [Theory]
        [InlineData(new int[] { 2, 2 }, 0)]
        [InlineData(new int[] { 3, 2 }, 1)]
        public void SubtrairTeste(int[] num, int resultado)
        {
            int subtrair = _calc.Subtrair(num[0], num[1]);
            Assert.Equal(resultado, subtrair);
        }

        [Theory]
        [InlineData(new int[] { 2, 2 }, 4)]
        [InlineData(new int[] { 3, 2 }, 6)]
        public void MultiplicarTeste(int[] num, int resultado)
        {
            int multiplicar = _calc.Multiplicar(num[0], num[1]);
            Assert.Equal(resultado, multiplicar);
        }

        [Theory]
        [InlineData(new int[] { 10, 2 }, 5)]
        [InlineData(new int[] { 4, 2 }, 2)]
        public void DivisaoTeste(int[] num, int resultado)
        {
            int divisao = _calc.Dividir(num[0], num[1]);
            Assert.Equal(resultado, divisao);
        }

        [Fact]
        public void DivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(
                () => _calc.Dividir(2, 0));
        }
    }
}