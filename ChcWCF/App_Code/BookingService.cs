using ChcObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class BookingService : IBookingService
{
    public Service GetServiceById(int id)
    {
        return new Service(id);
    }

    public IList<Service> GetServices()
    {
        return new Service().GetServices();
    }

    public Service CreateService(Service service)
    {
        return new Service().CreateService(service);
    }

    public Service UpdateService(Service service)
    {
        return new Service().UpdateService(service);
    }

    public IList<Container> GetContainers()
    {
        return new Container().GetContainers();
    }

    public IList<Carrier> GetCarriers()
    {
        return new Carrier().GetCarriers();
    }

    public IList<ScheduleFrequency> GetScheduleFrequncies()
    {
        return new ScheduleFrequency().GetScheduleFrequencies();
    }

    public IList<DisposalLocation> GetDisposalLocations()
    {
        return new DisposalLocation().GetDisposalLocations();
    }
}
