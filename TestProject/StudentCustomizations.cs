using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public partial class Student
    {
        public override string ToString()
        {
            return "Student ID: " + Id + " " + Name + " Major: " + Major; 
        }

        public string FullDescription => ToString();
    }
}
