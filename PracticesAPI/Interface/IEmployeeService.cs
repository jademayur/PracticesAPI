using PracticesAPI.DTOs;

namespace PracticesAPI.Interface
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync();
        Task<EmployeeDto> GetEmployeeByIdAsync(int empId);
        Task<CreateEmpDto> CreateEmployeeAsync(CreateEmpDto employeeDto);
        Task<bool> UpdateEmployeeAsync(int empId,UpdateEmpDto employeeDto);
        Task<bool> DeleteEmployeeAsync(int empId);

    }
}
