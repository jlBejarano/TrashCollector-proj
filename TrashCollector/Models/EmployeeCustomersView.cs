using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class EmployeeCustomersView
    {
        public Employee employee { get; set; }
        public string DaySelected { get; set; }
        public SelectList DaysToChoose { get; set; }
        public List<Customer> Customers { get; set; }
        public bool PickUpConfirmed { get; set; }
    }
}
