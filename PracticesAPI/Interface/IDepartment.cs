using PracticesAPI.DTOs.Dept;

namespace PracticesAPI.Interface
{
    public interface IDepartment
    {
        Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync();
        Task<DepartmentDto> GetDepartmentsAsync(int deptId);
        Task<DepartmentDto> CreateDepartmentAsync(DepartmentDto department);
        Task<bool> UpdateDepartmentAsync(int deptId, DepartmentDto department);
        Task<bool> DeleteDepartmentAsync(int deptId);
    }
}
