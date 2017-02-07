namespace ChcDB
{
    public interface ISite
    {
        int SiteID { get; set; }
        string SiteName { get; set; }
        string Address { get; set; }
        int SICcode { get; set; }
        string ContactDetails { get; set; }
        string ActionDetails { get; set; }
    }
}