using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Example01.Models
{
    public class Student
    {
        [Key]
        public string RollNumber { get; set; }
        [ForeignKey("Punishment")]
        public int PunishmentId { get; set; }
        public Punishment Punishment { get; set; }
        public int CountP { get; set; }
        public DateTime TimeP { get; set; }
        public Student()
        {
            TimeP = DateTime.Now;
        }
    }
}