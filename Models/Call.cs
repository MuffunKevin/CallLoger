using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CallLoger.Models
{
    public class Call
    {
        [Key]
        public int ID { get; set; }
        public virtual Caller Caller {get; set;}
        public DateTime DateTime { get; set; }
        public virtual CallType CallType { get; set; }
    }
}