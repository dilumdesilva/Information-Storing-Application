using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Library
{
    public class Student
    {
        public int age { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string universityID { get; set; }
        public int StudentID { get; set; }
        public string adress { get; set; }
        public int DepartmentID { get; set; }
        public Department ObjDepartment { get; set; }
        public string FullName { get; set; }


        //this feilds has changed during the development procedure.
        public string firstName { get; set; }
        public string lastName { get; set; }

    }
}
