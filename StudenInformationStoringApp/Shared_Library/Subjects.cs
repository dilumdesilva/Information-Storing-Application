using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Library
{
    public class Subjects
    {
        public int SubjectID { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public Semesters ObjSemesters { get; set; }

        public int Mark { get; set; }
        public string Grade { get; set; }
    }
}
