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

    public ClienteModel Buscar(int dniCliente)
    {
        var objCliente = new ClienteModel();

        try
        {
                var cliente = objClienteBL.Buscar(dniCliente);

                objCliente.Dni = cliente.nu_dni;
                objCliente.Nombres = cliente.tx_nombre;
                objCliente.Estado = cliente.tx_estado;

        }
        catch (Exception ex)
        {

            throw ex;
            //objCliente.MessageError = ex.Message;
        }

        return objCliente;

    }

    public bool Eliminar(int dniCliente)
    {
        try
        {
            var resultado = objClienteBL.Eliminar(dniCliente);
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
                nu_dni = objCliente.Dni,
                tx_nombre = objCliente.Nombres,
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
                nu_dni = objCliente.Dni,
                tx_nombre = objCliente.Nombres,
                tx_estado = objCliente.Estado
            };

            var dni = objClienteBL.Registrar(cliente);

            return dni;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        
 
    }
}
