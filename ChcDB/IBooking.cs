using System;

namespace ChcDB
{
    public interface IBooking
    {
        int BookingID { get; set; }
        int SiteID { get; set; }
        int ServiceID { get; set; }
        Nullable<decimal> InPrice { get; set; }
        Nullable<decimal> OutPrice { get; set; }
        System.DateTime ServiceDate { get; set; }
        bool Deleted { get; set; }
    }
}