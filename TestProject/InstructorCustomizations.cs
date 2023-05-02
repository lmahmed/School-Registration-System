using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public partial class Instructor
    {
        public override string ToString()
        {
            return "Instructor ID: " + Id + " " + Name + " : " + OfficeLocation;
        }

        public string FullDescription => ToString();
    }
}
