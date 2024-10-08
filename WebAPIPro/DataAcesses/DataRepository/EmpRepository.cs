using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebAPIPro.DB_Context;
using WebAPIPro.Models;

namespace WebAPIPro.DataAcesses.DataRepository
{
    public class EmpRepository : IEmpRepository
    {
        public QIS2Context QIS2Context;

        public EmpRepository(QIS2Context qIS2Context)
        {
            QIS2Context = qIS2Context;
        }


        public async Task<int> DeleteEmployee(int EmpNo)
        {
          var  empdel=  await QIS2Context.Employees.FindAsync(EmpNo);
            QIS2Context.Employees.Remove(empdel);
            return await QIS2Context.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await QIS2Context.Employees.ToListAsync();
        }

        public Task<Employee> GetEmployeeByEmailAndPassword(string email, string Password)
        {
            //throw new NotImplementedException();
            return QIS2Context.Employees.Where(x=>x.Email==email && x.password==Password).FirstOrDefaultAsync();
        }

        public async Task<List<Employee>> GetEmployeeByGender(string gender)
        {
            //throw new NotImplementedException();
            return await QIS2Context.Employees.Where(x=>x.Gender==gender).ToListAsync();
        }

        public async  Task<Employee> GetEmployeeById(int empId)
        {
            //throw new NotImplementedException();
            return  await QIS2Context.Employees.FindAsync(empId);  
        }

        public  async Task<Employee> GetEmployeeByName(string empName)
        {
            //throw new NotImplementedException();
            return await QIS2Context.Employees.FindAsync(empName);
        }

        public async Task<int> InsertEmployee(Employee Emp)
        {
             await QIS2Context.Employees.AddAsync(Emp);
            return await QIS2Context.SaveChangesAsync();

        }

        public async Task<int> UpdateEmployee(Employee Emp)
        {
           QIS2Context.Employees.Update(Emp);
            return await QIS2Context.SaveChangesAsync();
        }


    }
}
