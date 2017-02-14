namespace ChcDB
{
    public interface IService
    {
        int ServiceID { get; set; }
        int SiteID { get; set; }
        System.DateTime StartDate { get; set; }
        int ContractNumber { get; set; }
        int ContainerID { get; set; }
        string EWC { get; set; }
        int ScheduleFrequencyID { get; set; }
        int ScheduleDay { get; set; }
        decimal InPrice { get; set; }
        decimal OutPrice { get; set; }
        int CarrierID { get; set; }
        int DisposalLocationID { get; set; }
        bool IsRecurring { get; set; }
        bool Deleted { get; set; }
    }
}