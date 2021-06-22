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

    public int Registrar(ClienteModel objCliente)
    {
        var cliente = new Cliente
        {
            nu_dni = objCliente.Dni,
            tx_nombre = objCliente.Nombres,
            tx_estado = objCliente.Estado
        };

        return objClienteBL.Registrar(cliente);
    }
}
