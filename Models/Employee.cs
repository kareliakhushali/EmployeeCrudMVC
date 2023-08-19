using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCrudMVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage ="* Name cannot be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "* City cannot be empty")]
        public string City { get; set; }
        [Required(ErrorMessage = "* State cannot be empty")]
        public string State { get; set; }
        [Required]
        public decimal? Salary { get; set; }


    }
}
