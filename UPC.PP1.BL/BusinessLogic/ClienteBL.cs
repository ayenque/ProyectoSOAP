using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.PP1.BL.DataAcces;

namespace UPC.PP1.BL.BusinessLogic
{

    class ClienteBL
    {
        private readonly ClienteDA objClienteDA;


        public ClienteBL()
        {
            objClienteDA = new ClienteDA();

        }

        public int Registrar(Cliente objCliente)
        {
           return objClienteDA.Registrar(objCliente);

        }
    }

    /**
    class ClienteBL
    {
        private readonly ClienteDA objClienteDA;
        
    public ClienteBL()
        {
            objClienteDA = new ClienteDA();

        }

        public int Registrar(Cliente objCliente)
        {

            var cliente = objClienteDA.Buscar(objCliente.nu_dni);

            if (cliente == null)
                return objClienteDA.Registrar(objCliente);
            else
                return cliente.nu_dni;
        }
    }
   **/

}














