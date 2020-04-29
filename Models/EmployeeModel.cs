using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Models
{
    public class EmployeeModel
    {
        
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]

        public string EmployeeCode { get; set; }
        [Required]
        public string Gender { get; set; }

        public int Designation { get; set; }
        public string DesignationName { get; set; }

        public int Department { get; set; }
        public string DepartmentName { get; set; }
        [Required]
        public string DOB { get; set; }

        [Required]
        public int Salary { get; set; }


    }
}
