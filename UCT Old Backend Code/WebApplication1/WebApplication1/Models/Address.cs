﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AETProject.Models
{
    [Table("address")]
    public class Address
    {
        [Key]
        public int addressId { get; set; }
        [ForeignKey("User")]
        public int userId { get; set; }
        public virtual User User { get; set; }
        public string streetName { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string suburbTownship { get; set; }
        public string poastalCode { get; set; }
    }
}