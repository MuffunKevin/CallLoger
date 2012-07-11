using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CallLoger.Models
{
    public class Caller
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
