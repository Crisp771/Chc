namespace ChcDB
{
    public interface ICarrier
    {
        int CarrierID { get; set; }
        string CarrierName { get; set; }
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string AddressLine3 { get; set; }
        string Postcode { get; set; }
        string WasteCarriersLicence { get; set; }
        System.DateTime ExpiryDate { get; set; }
    }
}