using PracticesAPI.DTOs.Dept;

namespace PracticesAPI.Interface
{
    public interface IDepartment
    {
        Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync();
        Task<DepartmentDto> GetDepartmentsAsync(DepartmentDto department);
        Task<DepartmentDto> CreateDepartmentAsync(DepartmentDto department);
        Task<bool> UpdateDepartmentAsync(int deptId, DepartmentDto department);
        Task<bool> DeleteDepartmentAsync(int deptId);
    }
}
