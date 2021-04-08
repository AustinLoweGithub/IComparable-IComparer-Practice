using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IComparablePractice
{
    public class PatientComparer : IComparer<Patient>
    {




        public int Compare(Patient left, Patient right)
            {

            return left.Age - right.Age; 

            }
                


        




    }
}
