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
    ClienteModel Buscar(int idCliente);


    [OperationContract]
    bool Modificar(ClienteModel objCliente);

    [OperationContract]
    bool Eliminar(int idCliente);

}




[DataContract]
public class ClienteModel
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string TipoDoc { get; set; }

    [DataMember]
    public string NuDoc { get; set; }

    [DataMember]
    public string Nombres { get; set; } 

    [DataMember]
    public string Email { get; set; }

    [DataMember]
    public string Telefono { get; set; }

    [DataMember]
    public string Direccion { get; set; }

    [DataMember]
    public DateTime? FecCreacion { get; set; }

    [DataMember]
    public DateTime? FecActualizacion { get; set; }

    [DataMember]
    public string Estado { get; set; }

    [DataMember]
    public string MessageError { get; set; }
}

