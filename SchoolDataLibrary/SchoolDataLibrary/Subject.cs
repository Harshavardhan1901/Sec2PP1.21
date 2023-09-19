using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataLibrary
{
    public class Subject
    {
        public string SubjectName { get; set; }

        public Subject(string subjectName)
        {
            SubjectName = subjectName;
        }

        public string GetSubjectName()
        {
            return SubjectName;
        }
    }
}
