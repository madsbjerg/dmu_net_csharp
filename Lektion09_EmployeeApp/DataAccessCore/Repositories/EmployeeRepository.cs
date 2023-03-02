using DTO.Model;
using EmployeeDataAccess.Context;
using EmployeeDataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EmployeeDataAccess.Repositories
{
    public class EmployeeRepository
    {
        public static Employee getEmployee(int id)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                //Maybe throw exception if not found
                return EmployeeMapper.Map(context.Employees.Find(id));
            }
        }
        public static void AddEmployee(Employee employee)
        {
            using (EmployeeContext context = new EmployeeContext()) 
            {
                context.Employees.Add(EmployeeMapper.Map(employee));
                context.SaveChanges();
            }
        }

        public static void EditEmployee(Employee employee)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                //Virker ikke:
                //Model.Employee dataemp = EmployeeMapper.Map(employee);
                //Virker:
                Model.Employee dataemp = context.Employees.Find(employee.EmployeeId);
                EmployeeMapper.Update(employee, dataemp);
                //Virker måske:
                //Model.Employee dataemp = EmployeeMapper.Map(employee);
                //context.Entry(dataemp).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
