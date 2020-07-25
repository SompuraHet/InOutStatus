using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InOutStatus.Models
{
    public class UserStatus
    {
        public int Id { get; set; }

        public string WorkStatus { get; set; }

        public string Location { get; set; }

        public string Comment { get; set; }

        public string QuickSet { get; set; }
    }
}