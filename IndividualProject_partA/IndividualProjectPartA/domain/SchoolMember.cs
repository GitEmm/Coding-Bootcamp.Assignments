using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.Services;


namespace IndividualProjectPartA.domain
{
    class SchoolMember
    {
     
        //Represents every member of the school, be it a student or a trainer

        //The first name of the SchoolMember
        private string _firstName;

        public string FirstName
        {
            get { return _firstName.ToUpper(); }
            set { _firstName = value; }
        }

        //The last name of the ShcoolMember
        private string _lastName;

        public string LastName
        {
            get { return _lastName.ToUpper(); }
            set { _lastName = value; }
        }


        //Constructor(s)
        public SchoolMember()
        {

        }

        public SchoolMember(string inFirstName, string inLastName)
        {
            this.FirstName = inFirstName;
            this.LastName = inLastName;
        }
        
    }
}
