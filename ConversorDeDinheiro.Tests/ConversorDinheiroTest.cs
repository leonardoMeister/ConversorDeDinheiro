using ConversorDeDinheiro.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConversorDeDinheiro.Tests
{

    [TestClass]
    public class ConversorDinheiroTest
    {
        
        
        [TestMethod]
        public void DeveRetonarOperacaoInvalida()
        {
            Assert.AreEqual("Operação inválida", new ConversorDinheiro("23,3"));
        }
        /*
        [TestMethod]
        public void DeveRetonarUmCentavoDeReal()
        {
            //arrange
            ConversorDinheiro conversorDeDinheiro = new ConversorDinheiro(0.01m);

            //action
            string resultado = conversorDeDinheiro.PorExtenso();

            //assert
            Assert.AreEqual("Um centavo de real", resultado);
        }

        

        [TestMethod]
        public void DeveRetonarQuatorzeCentavosDeReal()
        {
            Assert.AreEqual("Quatorze centavos de real", new ConversorDinheiro(0.14m).PorExtenso());
        }



        [TestMethod]
        public void DeveRetonarVinteCentavosDeReal()
        {
            Assert.AreEqual("Vinte centavos de real", new ConversorDinheiro(0.20m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetonarNoventaEhNoveCentavosDeReal()
        {
            Assert.AreEqual("Noventa e nove centavos de real", new ConversorDinheiro(0.99m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetonarUmReal()
        {
            Assert.AreEqual("Um real", new ConversorDinheiro(1.00m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetonarQuatorzeReais()
        {
            Assert.AreEqual("Quatorze reais", new ConversorDinheiro(14.00m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetonarNoventaEhNoveReais()
        {
            Assert.AreEqual("Noventa e nove reais", new ConversorDinheiro(99.00m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetonarUmReal_EhUmCentavo()
        {
            Assert.AreEqual("Um real e um centavo", new ConversorDinheiro(1.01m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetonarQuatorzeReais_EhQuatorzeCentavos()
        {
            Assert.AreEqual("Quatorze reais e quatorze centavos", new ConversorDinheiro(14.14m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetonarNoventaEhNoveReais_EhNoventaEhNoveCentavos()
        {
            Assert.AreEqual("Noventa e nove reais e noventa e nove centavos", new ConversorDinheiro(99.99m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetonarCemReais()
        {
            Assert.AreEqual("Duzentos reais", new ConversorDinheiro(200.00m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetonarCentoEhUmReais_EhUmCentavo()
        {
            Assert.AreEqual("Novecentos e noventa e nove reais e noventa e nove centavos", new ConversorDinheiro(999.99m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetonarUmMilReais()
        {
            Assert.AreEqual("Um mil reais", new ConversorDinheiro(1000.00m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetonarVinteUmMilReais()
        {
            Assert.AreEqual("Vinte um mil reais", new ConversorDinheiro(21000.00m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetonarVinteUmMil_EhOitentaEhSeis_EhCinquentaCentavos()
        {
            Assert.AreEqual("Vinte um mil quinhentos e oitenta e seis reais e cinquenta centavos", new ConversorDinheiro(21586.50m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetonarVinteUmMil_EhQuinhentosReais()
        {
            Assert.AreEqual("Vinte um mil e quinhentos reais", new ConversorDinheiro(21500.00m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetornarUmMilhaoDeReais()
        {
            Assert.AreEqual("Um milhão de reais", new ConversorDinheiro(1000000.00m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetornarUmMilhao_OitocentosEhCinquentaEhDoisMil_EhSetecentosReais()
        {
            Assert.AreEqual("Um milhão oitocentos e cinquenta e dois mil e setecentos reais", new ConversorDinheiro(1852700.00m).PorExtenso());
        }

        [TestMethod]
        public void DeveRetornarDoisMilhoes_OitocentosEhCinquentaEhDoisMil_EhSetecentosReais()
        {
            Assert.AreEqual("Oitenta e seis milhões oitocentos e cinquenta e dois mil e setecentos reais", new ConversorDinheiro(86852700.00m).PorExtenso());
        }*/
    }
}
