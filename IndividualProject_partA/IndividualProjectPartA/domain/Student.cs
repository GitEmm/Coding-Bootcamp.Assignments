using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.Services;


namespace IndividualProjectPartA.domain
{
    class Student : SchoolMember
    {

        //The student's date of birth
        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        //The tuition fees that a student must pay (in euros)
        private int _tuitionFees;

        public int TuitionFees
        {
            get { return _tuitionFees; }
            set { _tuitionFees = value; }
        }


        //Constructor(s)
        public Student()
        {

        }
        
        /*public Student(string inFirstName, string inLastName):
            base(inFirstName, inLastName)
        {
            
        }*/

        public Student(string inFirstName, string inLastName, DateTime inDateOfBirth, int inTuitionFees)
        {
            this.FirstName = inFirstName;
            this.LastName = inLastName;
            this.DateOfBirth = inDateOfBirth;
            this.TuitionFees = inTuitionFees;
        }

    }
}
