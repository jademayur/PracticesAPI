using PracticesAPI.DTOs.Emp;

namespace PracticesAPI.Interface
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync();
        Task<EmployeeDto> GetEmployeeByIdAsync(int empId);
        Task<EmployeeDto> CreateEmployeeAsync(CreateEmpDto employeeDto);
        Task<bool> UpdateEmployeeAsync(int empId,UpdateEmpDto employeeDto);
        Task<bool> DeleteEmployeeAsync(int empId);

    }
}
