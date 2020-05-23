using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class EmployeeTrashPU
    {
        public Employee Employee { get; set; }
        public DateTime PUDate { get; set; }
        public List<Customer> customers { get; set; }
    }
}
