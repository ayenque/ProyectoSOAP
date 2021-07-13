using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UPC.PP1.BL;
using UPC.PP1.BL.BusinessLogic;
using UPC.PP1.REST.Models;

namespace UPC.PP1.REST.Controllers
{
    [RoutePrefix("api/busquedas")] 
    public class ClienteController : ApiController
    {
        private readonly ClienteBL objClienteBL;

        public ClienteController()
        {
            objClienteBL = new ClienteBL();
        }

        [HttpGet]
        [Route("Buscar/{dniCliente}")]
        public IHttpActionResult Buscar(int dniCliente)
        {
            var resultado = objClienteBL.Buscar(dniCliente);

            var model = new ClienteModel
            {
                Dni = resultado.nu_dni,
                Nombres = resultado.tx_nombre,
                Estado = resultado.tx_estado
            };

            return Ok(model);
        }

        [HttpDelete]
        public IHttpActionResult Eliminar(int dniCliente)
        {
            var resultado = objClienteBL.Eliminar(dniCliente);
            return Ok(resultado);
        }


        [HttpGet]
        [Route("BuscarconFind/{dniCliente}")]
        public IHttpActionResult BuscarconFind(int dniCliente)  //Otro método para buscar
        {
            var resultado = objClienteBL.BuscarconFind(dniCliente);

            var model = new ClienteModel
            {
                Dni = resultado.nu_dni,
                Nombres = resultado.tx_nombre,
                Estado = resultado.tx_estado
            };

            return Ok(model);
        }


        [HttpPost]
        [Route("registrar")]
        public IHttpActionResult Registrar(ClienteModel objCliente)
        {
            var cliente = new Cliente
            {
                nu_dni = objCliente.Dni,
                tx_nombre = objCliente.Nombres,
                tx_estado = objCliente.Estado,
            };

            var dni = objClienteBL.Registrar(cliente);
            return Ok(dni);
        }


        [HttpPut]
        [Route("modificar")]
        public IHttpActionResult Modificar(ClienteModel objCliente)
        {
            var cliente = new Cliente
            {
                nu_dni = objCliente.Dni,
                tx_nombre = objCliente.Nombres,
                tx_estado = objCliente.Estado,
            };

            var resultado = objClienteBL.Modificar(cliente);
            return Ok(resultado);
        }

    }
}
