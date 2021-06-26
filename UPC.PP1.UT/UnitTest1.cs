using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UPC.PP1.BL;
using UPC.PP1.BL.BusinessLogic;

namespace UPC.PP1.UT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Registrar()
        { 
            var objCliente = new Cliente()
            {
                nu_dni = 45987656,
                tx_nombre = "Cliente Prueba Unitaria",
                tx_estado = "N"
            };

            var objClienteBL = new ClienteBL();
            var dni = objClienteBL.Registrar(objCliente);

            Assert.AreEqual(45987656, dni);
        }

        [TestMethod]
        public void Buscar()
        {
            var objClienteBL = new ClienteBL();
            var objCliente = objClienteBL.Buscar(45987656);

            Assert.AreEqual(45987656, objCliente.nu_dni);
        }


        [TestMethod]
        public void Modificar()
        {
            var objCliente = new Cliente()
            {
                nu_dni = 43952353,
                tx_nombre = "Cliente Prueba Modificado",
                tx_estado = "S"
            };

            var objClienteBL = new ClienteBL();
            var resultado = objClienteBL.Modificar(objCliente);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void Eliminar()
        {
            var objClienteBL = new ClienteBL();
            var resultado = objClienteBL.Eliminar(45987656);

            Assert.AreEqual(true, resultado);
        }


    }
}
