using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiveMe.Models
{
    public sealed class Notification
    {
        public int Id { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public List<BloodGroupType> BloodGroupTypes { get; set; }
    }
}