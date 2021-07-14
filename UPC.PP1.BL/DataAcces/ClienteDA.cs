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

                if (String.IsNullOrEmpty(objCliente.tipo_doc))
                {
                    query.tipo_doc = query.tipo_doc;
                }
                else
                {
                    query.tipo_doc = objCliente.tipo_doc;
                };

                if (String.IsNullOrEmpty(objCliente.nu_doc))
                {
                    query.nu_doc = query.nu_doc;
                }
                else
                {
                    query.nu_doc = objCliente.nu_doc;
                };

                if (String.IsNullOrEmpty(objCliente.tx_nombres))
                {
                    query.tx_nombres = query.tx_nombres;
                }
                else
                {
                    query.tx_nombres = objCliente.tx_nombres;
                };


                if (String.IsNullOrEmpty(objCliente.email))
                {
                    query.email = query.email;
                }
                else
                {
                    query.email = objCliente.email;
                };

                if (String.IsNullOrEmpty(objCliente.nu_telefono))
                {
                    query.nu_telefono = query.nu_telefono;
                }
                else
                {
                    query.nu_telefono = objCliente.nu_telefono;
                };

                if (String.IsNullOrEmpty(objCliente.tx_direccion))
                {
                    query.tx_direccion = query.tx_direccion;
                }
                else
                {
                    query.tx_direccion = objCliente.tx_direccion;
                };

                if (String.IsNullOrEmpty(objCliente.tx_estado))
                {
                    query.tx_estado = query.tx_estado;
                }
                else
                {
                    query.tx_estado = objCliente.tx_estado;
                };

                query.fec_actualizacion = DateTime.Now;


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



