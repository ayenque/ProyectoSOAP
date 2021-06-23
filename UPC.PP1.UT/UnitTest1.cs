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
    }
}
