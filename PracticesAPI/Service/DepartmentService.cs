using Microsoft.EntityFrameworkCore;
using PracticesAPI.Data;
using PracticesAPI.DTOs.Dept;
using PracticesAPI.Entity;
using PracticesAPI.Interface;

namespace PracticesAPI.Service
{
    public class DepartmentService : IDepartment
    {
        private readonly AppDbContext _context;
        public DepartmentService(AppDbContext context)
        {
            _context = context;
        }
        //get all departments
        public async Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync()
        {
            var departments = await _context.Departments.ToListAsync();
            return departments.Select(department => new DepartmentDto
            {
                DeptId = department.DeptId,
                DeptName = department.DeptName
            });
        }
        //get department by id
        public async Task<DepartmentDto> GetDepartmentsAsync(int deptId)
        {
            var dept = await _context.Departments.FindAsync(deptId);
            if (dept == null)
            {
                return null;
            }
            return new DepartmentDto
            {
                DeptId = dept.DeptId,
                DeptName = dept.DeptName
            };
        }
        //create department
        public async Task<DepartmentDto> CreateDepartmentAsync(DepartmentDto department)
        {
            var dept = new Department
            {
                DeptName = department.DeptName
            };
            _context.Departments.Add(dept);
            await _context.SaveChangesAsync();
            return new DepartmentDto
            {
                DeptId = dept.DeptId,
                DeptName = dept.DeptName
            };
        }
        //update department
        public async Task<bool> UpdateDepartmentAsync(int deptId, DepartmentDto department)
        {
            var dept = await _context.Departments.FindAsync(deptId);
            if (dept == null)
            {
                return false;
            }
            dept.DeptName = department.DeptName;
            await _context.SaveChangesAsync();
            return true;
        }
        //delete department
        public async Task<bool> DeleteDepartmentAsync(int deptId)
        {
            var dept = await _context.Departments.FindAsync(deptId);
            if (dept == null)
            {
                return false;
            }
            _context.Departments.Remove(dept);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
