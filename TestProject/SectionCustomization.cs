using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public partial class Section
    {
        override public string ToString()
        {
            return "Section ID: " + Id + " " + Semester + " " + Course.Department + " " + Course.Number + "-" + Course.Name + " with Instructor ID: " + InstructorId + " " + Instructor.Name + " Day/Time: " + DayTime;
        }

        public string FullDescription => ToString();
    }
}
