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

    [OperationContract]
    ClienteModel Buscar(int dniCliente);


    [OperationContract]
    bool Modificar(ClienteModel objCliente);

    [OperationContract]
    bool Eliminar(int dniCliente);

}




[DataContract]
public class ClienteModel
{
    [DataMember]
    public int Dni { get; set; }

    [DataMember]
    public string Nombres { get; set; }  // el signo de pregunta indica que puede ser null

    [DataMember]
    public string Estado { get; set; }
}

