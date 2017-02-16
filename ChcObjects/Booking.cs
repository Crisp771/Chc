using ChcDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChcObjects
{
    [DataContract]
    public class Booking : IBooking
    {
        private IChcDBEntities _context;

        [Key]
        [DataMember]
        public int BookingID { get; set; }
        [DataMember]
        [UIHint("GridForeignKey")]
        public int SiteID { get; set; }
        [DataMember]
        [UIHint("GridForeignKey")]
        public int ServiceID { get; set; }
        [DataMember]
        [DataType(DataType.Currency)]
        [Display(Name = "In Price", Prompt = "Please enter an In Price.", Description = "In Price")]
        public Nullable<decimal> InPrice { get; set; }
        [DataMember]
        [DataType(DataType.Currency)]
        [Display(Name = "Out Price", Prompt = "Please enter an Out Price.", Description = "Out Price")]
        public Nullable<decimal> OutPrice { get; set; }
        [DataMember]
        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Booking Service Date", Prompt = "Service Date", Description = "Service Date")]
        public System.DateTime ServiceDate { get; set; }
        [DataMember]
        public bool Deleted { get; set; }

        public Booking()
        {
            _context = new ChcDBEntities();
        }

        public Booking(IChcDBEntities context)
        {
            _context = context;
        }

        public Booking(IBooking booking)
        {
            _context = new ChcDBEntities();

            this.BookingID = booking.BookingID;
            this.Deleted = booking.Deleted;
            this.InPrice = booking.InPrice;
            this.OutPrice = booking.OutPrice;
            this.ServiceDate = booking.ServiceDate;
            this.ServiceID = booking.ServiceID;
            this.SiteID = booking.SiteID;
        }

        public Booking(IChcDBEntities context, IBooking booking)
        {
            _context = context;

            this.BookingID = booking.BookingID;
            this.Deleted = booking.Deleted;
            this.InPrice = booking.InPrice;
            this.OutPrice = booking.OutPrice;
            this.ServiceDate = booking.ServiceDate;
            this.ServiceID = booking.ServiceID;
            this.SiteID = booking.SiteID;
        }

        public IList<Booking> GetBookings()
        {
            return _context.tblBookings.ToList().Select(s => new Booking(s)).ToList();
        }

        public Booking GetBooking(int id)
        {
            return new Booking(_context.tblBookings.Find(id));
        }

        public IBooking CreateBooking(IBooking booking)
        {
            return _context.tblBookings.Add(new tblBooking(booking));
        }

        public IBooking UpdateBooking(IBooking booking)
        {
            IBooking originalBooking = _context.tblBookings.Find(booking.BookingID);
            originalBooking = booking;
            _context.SaveChanges();
            return originalBooking;
        }
    }
}
