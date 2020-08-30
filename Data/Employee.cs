using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace test1.Data
{
   public  class Employee
    {
        [Key]
        public int Employeeid { get; set; }
        public string Employeename { get; set; }
        public string Employyephone { get; set; }
    }
}
