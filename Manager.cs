using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Manager : Employee, IComparable<Manager>
    {
        #region property
        public string Phone { get; set; } 
        #endregion

        #region constructors
        public Manager(int _id, string _name, double _salary , string Ph) : base(_id, _name, _salary)
        {
            Phone = Ph;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Mnager Name : {Name} , Salary : {Salary} , Phone : {Phone}";
        }
        public int CompareTo(Manager? other)
        {
            return this.Salary.CompareTo(other.Salary);
        } 
        #endregion
    }
}
