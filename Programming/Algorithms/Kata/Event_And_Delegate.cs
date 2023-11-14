using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Kata_Debugger
{


    public class PersonEventArgs : EventArgs
    {
        public delegate void PersonEventHandler(object sender, PersonEventArgs e);
    }

    public class Publisher
    {
        public event PersonEventArgs.PersonEventHandler ContactNotify;

        public void CountMessages(List<string> peopleList)
        {
            foreach (string person in peopleList)
            {
                int totalLoops = 10;  // Number of total loop iterations
                int captureFrequency = 3;  // Capture the variable every 3 iterations
                int capturedValue = 0;  // Variable to capture
                object result;
                for (int i = 1; i <= totalLoops; i++)
                {
                    // Check if the current iteration is a multiple of captureFrequency
                    if (person[i] % captureFrequency == 0)
                    {
                        // Capture the variable here (in this example, we'll increment it)
                        capturedValue++;
                        result = OnContactNotify(person);

                    }


                }
                OnContactNotify(person);
            }
        }

        private object OnContactNotify(string person)
        {
            throw new NotImplementedException();
        }
    }





}
*/