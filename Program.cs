using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IComparablePractice
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Patient> _NewPatients = new List<Patient>
            {

                new Patient ("Fred"), new Patient("George"), new Patient("Sally"),
                new Patient ("Greg"), new Patient("Mike"), new Patient("Karen"),
            };

            Console.WriteLine("Select to sort by name by entering 1 or age by entering 2.\n\n");

            bool _validentry = false;

            while (!_validentry)
            {

                string _selection = Console.ReadLine();

                if (_selection == "1")
                {
                    _NewPatients.Sort();
                    _NewPatients.ForEach(Patient => Console.WriteLine(Patient.Name + " Age " + Patient.Age + " weight " + Patient.weight));

                    _validentry = true;

                }

                else if (_selection == "2")
                {

                    _NewPatients.Sort(new PatientComparer());
                    _NewPatients.ForEach(Patient => Console.WriteLine(Patient.Name + " Age " + Patient.Age + " weight " + Patient.weight));

                    _validentry = true;

                }

                else
                {
                    Console.WriteLine("Invalid Entry!!!\n\n");
                }

            }



            Console.ReadLine();

             }

            


        }
    }

