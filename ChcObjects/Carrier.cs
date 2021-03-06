﻿using ChcDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChcObjects
{
    public class Carrier : ICarrier
    {
        private readonly IChcDBEntities _context;
        [Key]
        [DataMember]
        public int CarrierID { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string CarrierName { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(200)]
        public string AddressLine1 { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(200)]
        public string AddressLine2 { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(200)]
        public string AddressLine3 { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(8)]
        public string Postcode { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(15)]
        public string WasteCarriersLicence { get; set; }
        [DataMember]
        [DataType(DataType.Date)]
        public System.DateTime ExpiryDate { get; set; }

        public Carrier()
        {
            _context = new ChcDBEntities();
        }

        public Carrier(IChcDBEntities context)
        {
            _context = context;
        }
        public Carrier(ICarrier carrier)
        {
            _context = new ChcDBEntities();

            this.CarrierID = carrier.CarrierID;
            this.CarrierName = carrier.CarrierName;
        }

        public IList<Carrier> GetCarriers()
        {
            return _context.tblCarriers.ToList().Select(s => new Carrier(s)).ToList();
        }
    }
}
