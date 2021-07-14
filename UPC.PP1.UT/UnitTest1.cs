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
                tipo_doc = "DNI",
                nu_doc = "46984631",
                tx_nombres = "Nadia Alvarez",
                email = "nadia@nadie.com",
                nu_telefono = "+514656594",
                tx_direccion = "Av. La Marina 1515 - San Miguel",
                tx_estado = "Activo",
            };

            var objClienteBL = new ClienteBL();
            var idCliente = objClienteBL.Registrar(objCliente);

            Assert.AreEqual(4, idCliente);
        }

        [TestMethod]
        public void Buscar()
        {
            var objClienteBL = new ClienteBL();
            var objCliente = objClienteBL.Buscar(2);

            Assert.AreEqual(2, objCliente.id_cliente);
        }


        [TestMethod]
        public void Modificar()
        {
            var objCliente = new Cliente()
            {
                id_cliente = 4,
                tipo_doc = "DNI",
                tx_nombres = "Nadia Alvarez Perez",
                nu_doc = "46984631",
                email = "nadia.alvarez@hotmail.com",
                nu_telefono = "+514656594",
                tx_direccion = "Av. La Marina 1515 - San Miguel",
                tx_estado = "Inactivo",
            };

            var objClienteBL = new ClienteBL();
            var resultado = objClienteBL.Modificar(objCliente);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void Eliminar()
        {
            var objClienteBL = new ClienteBL();
            var resultado = objClienteBL.Eliminar(4);

            Assert.AreEqual(true, resultado);
        }


    }
}
