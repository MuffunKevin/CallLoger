﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CallLoger.Models
{
    public class CallType
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}