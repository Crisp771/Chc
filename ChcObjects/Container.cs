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
    public class Container : IContainer
    {
        private readonly IChcDBEntities _context;
        [Key]
        [DataMember]
        public int ContainerID { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string ContainerName { get; set; }
        public Container()
        {
            _context = new ChcDBEntities();
        }

        public Container(IChcDBEntities context)
        {
            _context = context;
        }
        public Container(IContainer container)
        {
            _context = new ChcDBEntities();

            this.ContainerID = container.ContainerID;
            this.ContainerName = container.ContainerName;
        }

        public IList<Container> GetContainers()
        {
            return _context.tblContainers.ToList().Select(s => new Container(s)).ToList();
        }
    }
}
