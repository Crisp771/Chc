using ChcDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChcObjects
{
    public class Service : IService
    {
        private readonly IChcDBEntities _context;
        [Key]
        [DataMember]
        public int ServiceID { get; set; }
        [DataMember]
        [Display(Name = "Site", Prompt = "Enter Site.", Description = "Site")]
        [DisplayName("Site Display")]
        [UIHint("GridForeignKey")]
        public int SiteID { get; set; }
        [DataMember]
        [DataType(DataType.Date)]
        [Display(Name = "Service Start Date", Prompt = "Start Date", Description = "Service Start Date")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime StartDate { get; set; }
        [DataMember]
        [Display(Name = "Contract Number", Prompt = "Contract Number.", Description = "Contract Number")]
        public int ContractNumber { get; set; }
        [DataMember]
        [UIHint("GridForeignKey")]
        [Display(Name = "Container Type", Prompt = "Please pick a container.", Description = "Container Type")]
        public int ContainerID { get; set; }
        [DataMember]
        [Display(Name = "EWC Number", Prompt = "Please enter an EWC.", Description = "European Waste Code")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string EWC { get; set; }
        [DataMember]
        [Display(Name = "Schedule Frequency", Prompt = "Please pick a Schedule Frequency.", Description = "Schedule Frequency")]
        [UIHint("GridForeignKey")]
        public int ScheduleFrequencyID { get; set; }
        [DataMember]
        [Display(Name = "Schedule Day", Prompt = "Please pick a Schedule Day.", Description = "Schedule Day")]
        public int ScheduleDay { get; set; }
        [DataMember]
        [DataType(DataType.Currency)]
        [Display(Name = "In Price", Prompt = "Please enter an In Price.", Description = "In Price")]
        public decimal InPrice { get; set; }
        [DataMember]
        [Display(Name = "Out Price", Prompt = "Please enter an Out Price.", Description = "Out Price")]
        [DataType(DataType.Currency)]
        public decimal OutPrice { get; set; }
        [DataMember]
        [Display(Name = "Carrier", Prompt = "Please pick a carrier.", Description = "Carrier")]
        [UIHint("GridForeignKey")]
        public int CarrierID { get; set; }
        [DataMember]
        [Display(Name = "Disposal Location", Prompt = "Please pick a disposal location.", Description = "Disposal Location")]
        [UIHint("GridForeignKey")]
        public int DisposalLocationID { get; set; }
        [DataMember]
        [Display(Name = "Is this service recurring?", Prompt = "Is Recurring.", Description = "IsRecurring")]
        public bool IsRecurring { get; set; }
        [DataMember]
        public bool Deleted { get; set; }

        public Service()
        {
            _context = new ChcDBEntities();
        }

        public Service(IChcDBEntities context)
        {
            _context = context;
        }
        public Service(IService service)
        {
            _context = new ChcDBEntities();
            this.ServiceID = service.ServiceID;
            this.SiteID = service.SiteID;
            this.StartDate = service.StartDate;
            this.ContractNumber = service.ContractNumber;
            this.ContainerID = service.ContainerID;
            this.EWC = service.EWC;
            this.ScheduleFrequencyID = service.ScheduleFrequencyID;
            this.ScheduleDay = service.ScheduleDay;
            this.InPrice = service.InPrice;
            this.OutPrice = service.OutPrice;
            this.CarrierID = service.CarrierID;
            this.DisposalLocationID = service.DisposalLocationID;
            this.IsRecurring = service.IsRecurring;
        }

        public Service(IChcDBEntities context, IService service)
        {
            _context = context;
            this.ServiceID = service.ServiceID;
            this.SiteID = service.SiteID;
            this.StartDate = service.StartDate;
            this.ContractNumber = service.ContractNumber;
            this.ContainerID = service.ContainerID;
            this.EWC = service.EWC;
            this.ScheduleFrequencyID = service.ScheduleFrequencyID;
            this.ScheduleDay = service.ScheduleDay;
            this.InPrice = service.InPrice;
            this.OutPrice = service.OutPrice;
            this.CarrierID = service.CarrierID;
            this.DisposalLocationID = service.DisposalLocationID;
            this.IsRecurring = service.IsRecurring;
        }

        public Service(int id)
        {
            _context = new ChcDBEntities();
            var service = _context.tblServices.Find(id);

            this.ServiceID = service.ServiceID;
            this.SiteID = service.SiteID;
            this.StartDate = service.StartDate;
            this.ContractNumber = service.ContractNumber;
            this.ContainerID = service.ContainerID;
            this.EWC = service.EWC;
            this.ScheduleFrequencyID = service.ScheduleFrequencyID;
            this.ScheduleDay = service.ScheduleDay;
            this.InPrice = service.InPrice;
            this.OutPrice = service.OutPrice;
            this.CarrierID = service.CarrierID;
            this.DisposalLocationID = service.DisposalLocationID;
            this.IsRecurring = service.IsRecurring;
        }

        public IList<Service> GetServices()
        {
            return _context.tblServices.Where(w=>!w.Deleted).ToList().Select(s => new Service(s)).ToList();
        }

        public Service CreateService(IService service)
        {
                 var newservice = new tblService()
                {
                    ServiceID = service.ServiceID,
                    SiteID = service.SiteID,
                    StartDate = service.StartDate,
                    ContractNumber = service.ContractNumber,
                    ContainerID = service.ContainerID,
                    EWC = service.EWC,
                    ScheduleFrequencyID = service.ScheduleFrequencyID,
                    ScheduleDay = service.ScheduleDay,
                    InPrice = service.InPrice,
                    OutPrice = service.OutPrice,
                    CarrierID = service.CarrierID,
                    DisposalLocationID = service.DisposalLocationID,
                    IsRecurring = service.IsRecurring
                };
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.tblServices.Add(newservice);
                    _context.SaveChanges();
                    var newcontractnumber = new tblContractNumber() { ServiceID = newservice.ServiceID };
                    _context.tblContractNumbers.Add(newcontractnumber);
                    _context.SaveChanges();
                    newservice.ContractNumber = newcontractnumber.ContractNumber;
                    _context.SaveChanges();
                    dbContextTransaction.Commit();
                }
                catch(Exception e)
                {
                    dbContextTransaction.Rollback();
                }
            }
            return new Service(newservice);
        }

        public Service UpdateService(IService service)
        {
            var oldservice = _context.tblServices.Find(service.ServiceID);

            oldservice.ServiceID = service.ServiceID;
            oldservice.SiteID = service.SiteID;
            oldservice.StartDate = service.StartDate;
            oldservice.ContractNumber = service.ContractNumber;
            oldservice.ContainerID = service.ContainerID;
            oldservice.EWC = service.EWC;
            oldservice.ScheduleFrequencyID = service.ScheduleFrequencyID;
            oldservice.ScheduleDay = service.ScheduleDay;
            oldservice.InPrice = service.InPrice;
            oldservice.OutPrice = service.OutPrice;
            oldservice.CarrierID = service.CarrierID;
            oldservice.DisposalLocationID = service.DisposalLocationID;
            oldservice.IsRecurring = service.IsRecurring;
            oldservice.Deleted = service.Deleted;

            _context.SaveChanges();

            return new Service(oldservice);
        }
    }
}
