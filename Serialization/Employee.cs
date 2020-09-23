using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Employee
    {
        public string Name {get;set;}
        public string Phone { get; set; }
        public DateTime DoB { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        [XmlIgnore]
        public string AdditionalInfo;

        public void preluare_date(string name, string phone, DateTime doB, string department, int salary) //preluare de date din controale
        {
            Name = name;
            Phone = phone;
            DoB = doB;
            Department = department;
            Salary = salary;
        }
    }
}
