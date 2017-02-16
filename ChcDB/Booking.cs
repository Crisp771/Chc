using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChcDB
{
    public partial class tblBooking : IBooking
    {
        public tblBooking(IBooking booking)
        {
            this.BookingID = booking.BookingID;
            this.Deleted = booking.Deleted;
            this.InPrice = booking.InPrice;
            this.OutPrice = booking.OutPrice;
            this.ServiceDate = booking.ServiceDate;
            this.ServiceID = booking.ServiceID;
            this.SiteID = booking.SiteID;
        }
    }
}
