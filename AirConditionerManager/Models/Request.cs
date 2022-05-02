using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AirConditionerManager.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        //[ForeignKey("User")]
        //public int UserId { get; set; }
        [Required]
        public string RequestName { get; set; }
        [Required]
        public string RequestDescription { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime DateOfTechVisiting { get; set; }
    }
}
