using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.Services;

namespace IndividualProjectPartA.domain
{
    class StudentDetails
    {
        //fields and properties

        private Student _detailsOfStudent; // The student's info

        public Student DetailsOfStudent
        {
            get { return _detailsOfStudent; }
            set { _detailsOfStudent = value; }
        }

        private List<Assignment> _assignmentsOfStudent;  // The assignments that the student has

        public List<Assignment> AssignmentsOfStudent
        {
            get { return _assignmentsOfStudent; }
            set { _assignmentsOfStudent = value; }
        }

        private List<Course> _coursesOfStudent;  // The courses that the student has

        public List<Course> CoursesOfStudent
        {
            get { return _coursesOfStudent; }
            set { _coursesOfStudent = value; }
        }


        //Constructor(s)
        public StudentDetails()
        {


        }

        //Methods

    }
}
