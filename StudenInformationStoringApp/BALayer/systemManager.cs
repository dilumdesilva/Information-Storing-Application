using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Library;
using DALayer;

namespace BALayer
{
    public class systemManager
    {
        public void insertStudentDetails(student student) {
            dataAccessWorkplace objdataAccessWorkplace = new dataAccessWorkplace();
            objdataAccessWorkplace.studentDetailsInToDb(student);


        }
    }
}
