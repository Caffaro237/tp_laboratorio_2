using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace Test_Unitarios
{
    [TestClass]
    public class TestsUnitarios
    {
        [TestMethod]
        public void VerificarIgualdad()
        {
            //Arrange
            bool respuesta;

            Notebook notebook = new Notebook(1, EnumMarcas.Asus.ToString(), EnumCPU.IntelI7.ToString(), EnumGPU.RTX2080.ToString(), 16, 1000, 17.3, 120);
            PCEscritorio pcEscritorio= new PCEscritorio(2, EnumMarcas.Asus.ToString(), EnumCPU.IntelI7.ToString(), EnumGPU.RTX2080.ToString(), 16, 1000);
            

            //Act
            respuesta = notebook == pcEscritorio;


            //Assert
            Assert.IsFalse(respuesta);

        }

        [TestMethod]
        public void VerificarInstanciacionNotebook()
        {
            //Arrange
            Notebook notebook;

            //Act
            notebook = new Notebook(1, EnumMarcas.Asus.ToString(), EnumCPU.IntelI7.ToString(), EnumGPU.RTX2080.ToString(), 16, 1000, 17.3, 120);

            //Assert
            Assert.IsNotNull(notebook);
        }

        [TestMethod]
        public void VerificarInstanciacionPCEscritorio()
        {
            //Arrange
            PCEscritorio pcEscritorio;

            //Act
            pcEscritorio = new PCEscritorio(1, EnumMarcas.Asus.ToString(), EnumCPU.IntelI7.ToString(), EnumGPU.RTX2080.ToString(), 16, 1000);

            //Assert
            Assert.IsNotNull(pcEscritorio);
        }
    }
}
