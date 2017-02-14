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
    public class EWC :IEwc
    {
        private readonly IChcDBEntities _context;
        [DataMember]
        public int Chapter { get; set; }
        [DataMember]
        public int SubChapter { get; set; }
        [DataMember]
        public int WasteType { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(250)]
        public string Description { get; set; }
        [DataMember]
        public bool IsHazardous { get; set; }
        [DataMember]
        [Key]
        [DataType(DataType.Text)]
        [StringLength(6)]
        public string EWCode { get; set; }

        public EWC()
        {
            _context = new ChcDBEntities();
        }

        public EWC(IChcDBEntities context)
        {
            _context = context;
        }
        public EWC(IEwc ewc)
        {
            _context = new ChcDBEntities();

            this.Chapter = ewc.Chapter;
            this.SubChapter = ewc.SubChapter;
            this.WasteType = ewc.WasteType;
            this.Description = ewc.Description;
            this.IsHazardous = ewc.IsHazardous;
            this.EWCode = ewc.EWCode;
        }

        public IList<EWC> GetEWCs()
        {
            return _context.tblEWCs.ToList().Select(s => new EWC(s)).ToList();
        }


    }
}
