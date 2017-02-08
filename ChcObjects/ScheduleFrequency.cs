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
    public class ScheduleFrequency : IScheduleFrequency
    {
        private readonly IChcDBEntities _context;
        [Key]
        [DataMember]
        public int ScheduleFrequencyID { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string FrequencyName { get; set; }
        public ScheduleFrequency()
        {
            _context = new ChcDBEntities();
        }

        public ScheduleFrequency(IChcDBEntities context)
        {
            _context = context;
        }
        public ScheduleFrequency(IScheduleFrequency scheduleFrequency)
        {
            _context = new ChcDBEntities();

            this.ScheduleFrequencyID = scheduleFrequency.ScheduleFrequencyID;
            this.FrequencyName = scheduleFrequency.FrequencyName;
        }

        public IList<ScheduleFrequency> GetScheduleFrequencies()
        {
            return _context.tblScheduleFrequencies.ToList().Select(s => new ScheduleFrequency(s)).ToList();
        }
    }
}
