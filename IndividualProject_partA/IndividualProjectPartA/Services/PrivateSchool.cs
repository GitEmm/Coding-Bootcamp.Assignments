using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.domain;


namespace IndividualProjectPartA.Services
{
    class PrivateSchool
    {
        //fields and properities (to be continued.....)
        private UserInputService _userInput;

        public UserInputService UserInput
        {
            get { return _userInput; }
            set { _userInput = value; }
        }


        /*private CourseDetails _courseDetails;
        
        public CourseDetails CourseDetails
        {
            get { return _courseDetails; }
            set { _courseDetails = value; }
        }

        //private StudentDetails _studentDetails;
        // private AssignmentDetails _assignmentDetails;


        private int _numberOfCourses;

        public int NumberOfCourses
        {
            get { return _numberOfCourses; }
            set { _numberOfCourses = value; }
        }
        */

        //Constructor(s)

        public PrivateSchool()
        {

        }


        /*public PrivateSchool(CourseDetails inCourseDetails, int inNumberOfCourses)
        {
            CourseDetails = inCourseDetails;
            NumberOfCourses = inNumberOfCourses;
        }*/


        // The constructor who is responsible for creating a PrivateSchool with data gathered by the input of the user
        public PrivateSchool(UserInputService inUserInput)
        {
            //CourseDetails = userInputService.CourseDetails;
            //NumberOfCourses = userInputService.NumberOfCourses;

            this.UserInput = inUserInput;
        }
        

        // Initializes all the services of the School
        public void StartSchool()
        {
            // run all the services to generate the contents of the school

            //CourseService courseService = new CourseService();
            //StudentService studentService = new StudentService();
            //TrainerService trainerService = new TrainerService();
            //AssignmentService assignmentService = new AssignmentService();

            // or run the manager service
            ManagerService managerService = new ManagerService(UserInput);
        }

    }
}
