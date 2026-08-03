using System.ComponentModel.DataAnnotations;

namespace PracticesAPI.Entity
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int DeptId { get; set; }
        public string? mobile { get; set; }
        public string? Email { get; set; }
        public decimal Salary { get; set; } = 0;

        public Department? Department { get; set; }
    }
}
