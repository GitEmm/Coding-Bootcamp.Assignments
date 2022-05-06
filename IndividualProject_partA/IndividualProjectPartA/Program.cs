using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.Services;
using IndividualProjectPartA.domain;


namespace IndividualProjectPartA
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a reference to an instance of the UserInputService class 
            UserInputService userInputService = new UserInputService();
            

            // Create a reference to an instance of the PrivateSchool class and feed it information about its contents
            PrivateSchool privateSchool = new PrivateSchool(userInputService);
           
            // Begin the creation of the data that make a school
            privateSchool.StartSchool();

            // Call the Output service to present the information to the user
            // TO DO -------------------------------------------------------

            //UserOutputService userOutputService = new UserOutputService();
        }
    }
}
