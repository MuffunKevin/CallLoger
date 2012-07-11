using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace CallLoger.Models
{
    public class CallLogerModel : DbModel
    {
        DbSet<CallType> CallTypes { get; set; }
        DbSet<Caller> Caller { get; set; }
        DbSet<Call> Call { get; set; }
    }
}