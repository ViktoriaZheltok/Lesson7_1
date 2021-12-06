using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_1
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int GroupNumber { get; set; }
        public string Gender { get; set; }
        public List<string> listOfFavouriteSubject = new List<string>() { };

        public override string ToString()
        {
            string s = Name + ", " + Age + ", " + Gender + ", " + GroupNumber;
            foreach (var i in this.listOfFavouriteSubject)
            {
                s += ", " + i;
            }

            return s;
        }
       
    }
}
