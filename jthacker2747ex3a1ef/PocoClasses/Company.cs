using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jthacker2747ex3a1ef.Model
{
    public class Company
    {
        private static AdventureWorksEFEntities dbContext = new AdventureWorksEFEntities();

        public static List<ShipMethod> getShipMethods()
        {
            List<ShipMethod> shipMethodList = new List<ShipMethod>();
            try
            {
                shipMethodList =
                    (from s in dbContext.ShipMethods
                     orderby s.Name 
                     select s).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return shipMethodList;
        }
        public static List<Vendor> getVendors()
        {
            List<Vendor> vendorList = new List<Vendor>();
            try
            {
                vendorList =
                    (from v in dbContext.Vendors
                     orderby v.Name
                     select v).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return vendorList;
        }

        public static List<Employee> getEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            try
            {
                employeeList =
                    (from e in dbContext.Employees.Include("Person")
                     orderby e.Person.LastName, e.Person.FirstName
                     select e).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return employeeList;
        }

    }
    
}
