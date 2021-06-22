using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


[ServiceContract]
public interface IClienteService
{
    [OperationContract]  
    int Registrar(ClienteModel objCliente);
}


[DataContract]
public class ClienteModel
{
    [DataMember]
    public int Dni { get; set; }

    [DataMember]
    public string Nombres { get; set; }

    [DataMember]
    public string Estado { get; set; }
}

