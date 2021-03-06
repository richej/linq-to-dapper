﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UnitTests.Models
{
    [Table("Machine")]
    public class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DeliveredOn { get; set; }
        public bool IsCool { get; set; }

        public static string MyStaticField { get;set;}
        public List<bool> JustAList { get; set; }
        public bool[] JustAnArray { get; set; }
    }
}
