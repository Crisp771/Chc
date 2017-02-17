using ChcDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChcObjects
{
    public class Scheduling
    {
        private IChcDBEntities _context;

        public DateTime EventStart { get; set; }
        public string EventName { get; set; }

        public Scheduling()
        {
            _context = new ChcDBEntities();
        }

        public Scheduling(IChcDBEntities context)
        {
            _context = context;
        }

        public IList<Scheduling> GetScheduledEvents()
        {
            var bookings = new Booking(_context).GetBookings();
            var services = new Service(_context).GetServices();

            var events = new List<Scheduling>();

            events.AddRange(services.Select(s => new Scheduling() { EventStart = s.StartDate, EventName = string.Format("Service ID {0}", s.ServiceID) }));
            events.AddRange(bookings.Select(s => new Scheduling() { EventStart = s.ServiceDate, EventName = string.Format("Booking ID {0}", s.BookingID) }));

            return events;
        }
    }
}
