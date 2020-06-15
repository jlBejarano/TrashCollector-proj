using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public double ZipCode { get; set; }
        public string DayOfWeek { get; set; }
        public string TrashPickUp { get; set; }
        public string TempSuspendPU { get; set; }
        public double CustomerBalance { get; set; }
        [DisplayName("Extra Pick Up Date")]
        public DateTime? ExtraPickUp { get; set; }
        [DisplayName("Start Pick Up")]
        public DateTime StartDate { get; set; }
        [DisplayName("End Pick Up")]
        public DateTime EndDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime SuspendStartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime SuspendEndDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public bool ConfirmPickUp { get; set; }


        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

       
        
    }
}
