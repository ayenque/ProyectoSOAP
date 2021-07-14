using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.PP1.BL.DataAcces
{
    class ClienteDA
    {
        private readonly BDClientesDataContext dc;
        public ClienteDA()
        {
            dc = new BDClientesDataContext();

        }

        public int Registrar(Cliente objCliente)
        {

            try
            {
                objCliente.fec_creacion = DateTime.Now;
                objCliente.fec_actualizacion = DateTime.Now;
                dc.Clientes.InsertOnSubmit(objCliente);
                dc.SubmitChanges();
                return objCliente.id_cliente;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }


         public Cliente Buscar(int idCliente)
        {
            try
            {
                var query = (from cl in dc.Clientes
                            where cl.id_cliente.Equals(idCliente)
                            select cl).Single();
                return query;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Cliente BuscarconFind(int idCliente)
        {
            try
            {
                var query = dc.Clientes.First(x => x.id_cliente.Equals(idCliente));
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
                var query = dc.Clientes.First(x => x.id_cliente.Equals(objCliente.id_cliente));
                
                query.tipo_doc = objCliente.tipo_doc;
                query.nu_doc = objCliente.nu_doc;
                query.tx_nombres = objCliente.tx_nombres;
                query.email = objCliente.email;
                query.nu_telefono = objCliente.nu_telefono;
                query.tx_direccion = objCliente.tx_direccion;
                query.fec_actualizacion = DateTime.Now;
                query.tx_estado = objCliente.tx_estado;

                dc.SubmitChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool Eliminar(int idCliente)
        {
            try
            {
                var query = dc.Clientes.First(x => x.id_cliente.Equals(idCliente));
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



