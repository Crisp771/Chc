namespace ChcDB
{
    public interface IEwc
    {
        int Chapter { get; set; }
        int SubChapter { get; set; }
        int WasteType { get; set; }
        string Description { get; set; }
        bool IsHazardous { get; set; }
        string EWCode { get; set; }
    }
}