namespace PracticesAPI.DTOs.Emp
{
    public class EmployeeDto
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string? EMail { get; set; }
        public string? Mobile { get; set; }
        public int DeptId { get; set; }
        public string DeptName { get; set; } = string.Empty;
        public decimal Salary { get; set; } = 0;
    }
}
