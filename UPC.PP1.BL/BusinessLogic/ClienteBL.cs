using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.PP1.BL.DataAcces;

namespace UPC.PP1.BL.BusinessLogic
{

    public class ClienteBL
    {
        private readonly ClienteDA objClienteDA;


        public ClienteBL()
        {
            objClienteDA = new ClienteDA();

        }

        public int Registrar(Cliente objCliente)
        {
            try
            {
                return objClienteDA.Registrar(objCliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
         }
        public Cliente Buscar(int dniCliente)
        {
            try
            {
                return objClienteDA.Buscar(dniCliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public bool Modificar(Cliente objCliente)
        {
            try
            {
                return objClienteDA.Modificar(objCliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Eliminar(int dniCliente)
        {
            try
            {
                return objClienteDA.Eliminar(dniCliente);

            }
            catch (Exception ex)
            {

                throw ex;
            }
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














