﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCB.NET.Domain.Model.Warehouse
{
    [Table("SMD", Schema = "store")]
    public class SMD
    {
        [Key]
        public int SMDId { get; set; }
        [Required]
        public Item Item { get; set; }
        [Required]
        public int Value { get; set; }
        [Required]
        public RatedItem RatedItem { get; set; }
        [Required]
        public string DescriptionItem { get; set; }
        [Required]
        public SMDSize Size { get; set; }
        [Required]
        public string Packages { get; set; }
        [Required]
        public int Feeder { get; set; }
        [Required]
        public int CountItem { get; set; }
        public DateTime? LastUpdate { get; set; }

        [Required]
        public virtual Board Board { get; set; }
    }
}