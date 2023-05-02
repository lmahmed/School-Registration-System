using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public partial class Registration
    {
        public override string ToString()
        {
            return "Registration ID: " + Id + " Student ID: " + StudentId + " " + Student.Name + " " + Section.Semester + " " + Section.Course.Department + " " + Section.Course.Number + "-" + Section.Course.Name + " with Instructor ID: " + Section.InstructorId + " " + Section.Instructor.Name + " Day/Time: " + Section.DayTime;
        }

        public string FullDescription => ToString();
    }
}
