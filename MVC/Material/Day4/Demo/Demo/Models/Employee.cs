﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string? Address { get; set; }
        public string? ImageUrl { get; set; }
        public int? Age { get; set; }
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        
        public Department Department { get; set; }
        
    }
}
