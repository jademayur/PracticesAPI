using PracticesAPI.DTOs.Dept;

namespace PracticesAPI.Interface
{
    public interface IDepartment
    {
      Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync();
      Task<DepartmentDto> GetDepartmentByIdAsync(int deptId);
      Task<DepartmentDto> CreateDepartmentAsync(CreateDeptDto departmentDto);
      Task<bool> UpdateDepartmentAsync(int deptId, UpdateDeptDto departmentDto);
      Task<bool> DeleteDepartmentAsync(int deptId);



    }
}
