using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public DateTime UpdatedAt { get; set; }

        [StringLength(128)]
        public string User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}