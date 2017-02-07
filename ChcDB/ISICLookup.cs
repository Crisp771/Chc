namespace ChcDB
{
    public interface ISICLookup
    {
        string Division { get; set; }
        int MajorGroup { get; set; }
        int IndustryGroup { get; set; }
        int SIC { get; set; }
        string Description { get; set; }
    }
}