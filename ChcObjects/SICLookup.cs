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
    public class SICLookup : ISICLookup
    {
        private readonly IChcDBEntities _context;
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(1)]
        public string Division { get; set; }
        [DataMember]
        public int MajorGroup { get; set; }
        [DataMember]
        public int IndustryGroup { get; set; }
        [Key]
        [DataMember]
        public int SIC { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(250)]
        public string Description { get; set; }

        public SICLookup()
        {
            _context = new ChcDBEntities();
        }

        public SICLookup(IChcDBEntities context)
        {
            _context = context;
        }

        public SICLookup(ISICLookup siclookup)
        {
            _context = new ChcDBEntities();
            this.Description = siclookup.Description;
            this.Division = siclookup.Division;
            this.IndustryGroup = siclookup.IndustryGroup;
            this.MajorGroup = siclookup.MajorGroup;
            this.SIC = siclookup.SIC;
        }

        public SICLookup(IChcDBEntities context, ISICLookup siclookup)
        {
            _context = context;

            this.Description = siclookup.Description;
            this.Division = siclookup.Division;
            this.IndustryGroup = siclookup.IndustryGroup;
            this.MajorGroup = siclookup.MajorGroup;
            this.SIC = siclookup.SIC;
        }

        public SICLookup(int id)
        {
            _context = new ChcDBEntities();

            var siclookup = _context.tblSICLookups.Find(id);

            this.Description = siclookup.Description;
            this.Division = siclookup.Division;
            this.IndustryGroup = siclookup.IndustryGroup;
            this.MajorGroup = siclookup.MajorGroup;
            this.SIC = siclookup.SIC;
        }

        public IList<SICLookup> GetSICLookupList()
        {
            return _context.tblSICLookups.ToList().Select(s => new SICLookup(s)).ToList();
        }
    }
}
