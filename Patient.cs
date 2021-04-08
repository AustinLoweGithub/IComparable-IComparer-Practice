using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IComparablePractice
{
   public class Patient : IComparable<Patient>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int weight { get; set; }

        static Random rand = new Random();

        public Patient(string name)
        {

            Name = name;
            Age = rand.Next(20, 80);
            weight = rand.Next(160, 280);



        }

        public int CompareTo(Patient other)
        {

            return Name.CompareTo(other.Name);

        }

        

    }
}
