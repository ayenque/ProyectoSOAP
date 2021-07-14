using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UPC.PP1.BL;
using UPC.PP1.BL.BusinessLogic;

public class ClienteService : IClienteService
{
    private readonly ClienteBL objClienteBL;
    public ClienteService()
    {
        objClienteBL = new ClienteBL();
    }

    public ClienteModel Buscar(int idCliente)
    {
        var objCliente = new ClienteModel();

        try
        {
                var cliente = objClienteBL.Buscar(idCliente);

                objCliente.Id = cliente.id_cliente;
                objCliente.TipoDoc = cliente.tipo_doc;
                objCliente.NuDoc = cliente.nu_doc;
                objCliente.Nombres = cliente.tx_nombres;
                objCliente.Email = cliente.email;
                objCliente.Telefono = cliente.email;
                objCliente.Direccion = cliente.tx_direccion;
                objCliente.FecCreacion = cliente.fec_creacion;
                objCliente.FecActualizacion = cliente.fec_actualizacion;
                objCliente.Estado = cliente.tx_estado;


        }
        catch (Exception ex)
        {

            throw ex;
            //objCliente.MessageError = ex.Message;
        }

        return objCliente;

    }

    public bool Eliminar(int idCliente)
    {
        try
        {
            var resultado = objClienteBL.Eliminar(idCliente);
            return resultado;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public bool Modificar(ClienteModel objCliente)
    {
        try
        {
            var cliente = new Cliente()
            {
                tipo_doc = objCliente.TipoDoc,
                nu_doc = objCliente.NuDoc,
                tx_nombres = objCliente.Nombres,
                email = objCliente.Email,
                nu_telefono = objCliente.Telefono,
                tx_direccion = objCliente.Direccion,
                tx_estado = objCliente.Estado,
            };

            var resultado = objClienteBL.Modificar(cliente);

            return resultado;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }


    public int Registrar(ClienteModel objCliente)
    {
        try
        {
            var cliente = new Cliente()
            {

                tipo_doc = objCliente.TipoDoc,
                nu_doc = objCliente.NuDoc,
                tx_nombres = objCliente.Nombres,
                email = objCliente.Email,
                nu_telefono = objCliente.Telefono,
                tx_direccion = objCliente.Direccion,
                tx_estado = objCliente.Estado,
            };

            var id = objClienteBL.Registrar(cliente);

            return id;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        
 
    }
}
