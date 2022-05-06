using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.Services;

namespace IndividualProjectPartA.domain
{
    class CourseDetails
    {
        //fields and properties

        private Course _detailsOfCourse; // The Course's info

        public Course DetailsOfCourse 
        {
            get { return _detailsOfCourse; }
            set { _detailsOfCourse = value; }
        }


        private List<Student> _studentsOfCourse;  // A list of all the students of the course

        public List<Student> StudentsOfCourse
        {
            get { return _studentsOfCourse; }
            set { _studentsOfCourse = value; }
        }


        private List<Trainer> _trainerOfCourse;  // A list of all the trainers of the course

        public List<Trainer> TrainersOfCourse
        {
            get { return _trainerOfCourse; }
            set { _trainerOfCourse = value; }
        }


        private List<Assignment> _assignmentsOfCourse; // A list of all the assignments of the course

        public List<Assignment> AssignmentsOfCourse
        {
            get { return _assignmentsOfCourse; }
            set { _assignmentsOfCourse = value; }
        }
               
        //Constructor(s)

        public CourseDetails()
        {

        }




        //Methods





    }
}
