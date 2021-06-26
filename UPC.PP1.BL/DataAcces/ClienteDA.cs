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

            try
            {
                dc.Clientes.InsertOnSubmit(objCliente);
                dc.SubmitChanges();
                return objCliente.nu_dni;
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
                var query = (from cl in dc.Clientes
                            where cl.nu_dni.Equals(dniCliente)
                            select cl).Single();
                return query;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Cliente BuscarconFind(int dniCliente)
        {
            try
            {
                var query = dc.Clientes.First(x => x.nu_dni.Equals(dniCliente));
                return query;


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
                var query = dc.Clientes.First(x => x.nu_dni.Equals(objCliente.nu_dni));
                
                query.tx_nombre = objCliente.tx_nombre;
                query.tx_estado = objCliente.tx_estado;

                dc.SubmitChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool Eliminar(int dniCliente)
        {
            try
            {
                var query = dc.Clientes.First(x => x.nu_dni.Equals(dniCliente));
                dc.Clientes.DeleteOnSubmit(query);
                dc.SubmitChanges();

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}






/**
public Cliente Buscar(int nu_dni)
{
    throw new NotImplementedException();
}
**/