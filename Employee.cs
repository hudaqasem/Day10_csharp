using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Employee : IComparable<Employee> , ICloneable
    {
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        #endregion

        #region constructors
        public Employee()
        {
            
        }
        public Employee(int _id, string _name, double _salary)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return $"EmpId {Id}, EmpName {Name}, EmpSalary {Salary}";
        }

        public int CompareTo(Employee? other)
        {
            return this.Salary.CompareTo(other.Salary);
        }

        public object Clone()
        {
            return new Employee()
            {
                Id = this.Id, Name = this.Name, Salary = this.Salary    
            };
        }
        #endregion
    }
}
