namespace ChcDB
{
    public interface IUserAudit
    {
        int UserAuditID { get; set; }
        System.DateTime EventDateTime { get; set; }
        string Event { get; set; }
        int UserID { get; set; }
        int CarriedOutByUserID { get; set; }

    }
}