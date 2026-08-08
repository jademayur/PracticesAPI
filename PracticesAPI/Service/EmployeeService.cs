using Microsoft.EntityFrameworkCore;
using PracticesAPI.Data;
using PracticesAPI.DTOs.Emp;
using PracticesAPI.Entity;
using PracticesAPI.Interface;

namespace PracticesAPI.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;

        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }
        //get all employees
        public async Task<EmployeeDto> GetEmployeeByIdAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return null;
            }
            return new EmployeeDto
            {
                EmpId = employee.EmpId,
                EmpName = employee.EmpName,
                EMail = employee.Email,
                Mobile = employee.mobile,
                DeptId = employee.DeptId,
                DeptName = employee.Department?.DeptName,
                Salary = employee.Salary
            };
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees.Select(employee => new EmployeeDto
            {
                EmpId = employee.EmpId,
                EmpName = employee.EmpName,
                EMail = employee.Email,
                Mobile = employee.mobile,
                DeptId = employee.DeptId,
                DeptName = employee.Department?.DeptName,
                Salary = employee.Salary
            });
        }
        //create employee
        public async Task<EmployeeDto> CreateEmployeeAsync(CreateEmpDto dto)
        {
            var employee = new Employee
            {
                EmpName = dto.EmpName,
                DeptId = dto.DeptId,
                mobile = dto.Mobile,
                Email = dto.EMail,
                Salary = dto.Salary
            };

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return new EmployeeDto
            {
                EmpId = employee.EmpId,
                EmpName = employee.EmpName,
                DeptId = employee.DeptId,
                Mobile = employee.mobile,
                EMail = employee.Email,
                Salary = employee.Salary
            };
        }

        //update employee
        public async Task<bool> UpdateEmployeeAsync(int id, UpdateEmpDto dto)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) return false;

            employee.EmpName = dto.EmpName;
            employee.DeptId = dto.DeptId;
            employee.mobile = dto.Mobile;
            employee.Email = dto.EMail;
            employee.Salary = dto.Salary;

            await _context.SaveChangesAsync();
            return true;
        }

        //delete employee
        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return false;
            }
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return true;


        }
    }
}
