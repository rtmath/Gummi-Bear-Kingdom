﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GummiBearKingdom.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Cost { get; set; }
        public string CountryOfOrigin { get; set; }
        public string ProductDescription { get; set; }
    }
}
