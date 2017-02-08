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
    public class DisposalLocation : IDisposalLocation
    {
        private readonly IChcDBEntities _context;
        [Key]
        [DataMember]
        public int DisposalLocationID { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string DisposalLocationName { get; set; }
        public DisposalLocation()
        {
            _context = new ChcDBEntities();
        }

        public DisposalLocation(IChcDBEntities context)
        {
            _context = context;
        }
        public DisposalLocation(IDisposalLocation container)
        {
            _context = new ChcDBEntities();

            this.DisposalLocationID = container.DisposalLocationID;
            this.DisposalLocationName = container.DisposalLocationName;
        }

        public IList<DisposalLocation> GetDisposalLocations()
        {
            return _context.tblDisposalLocations.ToList().Select(s => new DisposalLocation(s)).ToList();
        }
    }
}
