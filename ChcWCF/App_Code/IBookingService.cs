using ChcObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IBookingService
{
    [OperationContract]
    Service GetServiceById(int id);
    [OperationContract]
    IList<Service> GetServices();
    [OperationContract]
    Service CreateService(Service service, int userId);
    [OperationContract]
    Service UpdateService(Service service, int userId);
    [OperationContract]
    IList<Container> GetContainers();
    [OperationContract]
    IList<Carrier> GetCarriers();
    [OperationContract]
    IList<ScheduleFrequency> GetScheduleFrequncies();
    [OperationContract]
    IList<DisposalLocation> GetDisposalLocations();
    [OperationContract]
    IList<EWC> GetEWCs();
}

