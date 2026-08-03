using System.ComponentModel.DataAnnotations;

namespace PracticesAPI.Entity
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

    }
}
