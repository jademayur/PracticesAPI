namespace PracticesAPI.DTOs.Emp
{
    public class CreateEmpDto
    {
        public string EmpName { get; set; }
        public string? EMail { get; set; }
        public string? Mobile { get; set; }
        public int DeptId { get; set; }
        public decimal Salary { get; set; } = 0;
    }
}
