﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AunctionApp.DAL.Entities
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }

        [Range(100, 10000000, ErrorMessage ="Actual Amount must be within 100- 10000000")]
        public long ActualAmount { get; set; }
        public byte[]? ProductImage { get; set; }
        public bool IsSold { get; set; }
        public List<Bid>? Bids { get; set;}
    }
}
