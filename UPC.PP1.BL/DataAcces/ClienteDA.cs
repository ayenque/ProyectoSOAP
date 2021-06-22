using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.PP1.BL.DataAcces
{
    class ClienteDA
    {
        private readonly BDPedidosDataContext dc;
        public ClienteDA()
        {
            dc = new BDPedidosDataContext();

        }

        public int Registrar(Cliente objCliente)
        {
                dc.Clientes.InsertOnSubmit(objCliente);
                dc.SubmitChanges();
                return objCliente.nu_dni;
        }

    }
}






/**
public Cliente Buscar(int nu_dni)
{
    throw new NotImplementedException();
}
**/