using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.domain;

namespace IndividualProjectPartA.Services
{
    class ManagerService
    {
        //Description of the job: Contains and manages all the school services

        //fields and properties

        private UserInputService _userInput;

        public UserInputService UserInput
        {
            get { return _userInput; }
            set { _userInput = value; }
        }

        /*private CourseService _mCourseService;

        public CourseService M_CourseService
        {
            get { return _mCourseService; }
            set { _mCourseService = value; }
        }

        private StudentService _mStudentService;

        public StudentService M_StudentService
        {
            get { return _mStudentService; }
            set { _mStudentService = value; }
        }

        private TrainerService _mTrainerService;

        public TrainerService M_TrainerService
        {
            get { return _mTrainerService; }
            set { _mTrainerService = value; }
        }

        private AssignmentService _mAssignmentService;

        public AssignmentService M_AssignmenService
        {
            get { return _mAssignmentService; }
            set { _mAssignmentService = value; }
        }*/


        //Constructors
        public ManagerService()
        {
            Initialize();
        }

        public ManagerService(UserInputService inUserInput)
        {
            this.UserInput = inUserInput;
            Initialize(UserInput);
        }

        //Methods
        public void Initialize()
        {
            CourseService courseService = new CourseService();
            //StudentService studentService = new StudentService();
            //TrainerService trainerService = new TrainerService();
            //AssignmentService assignmentService = new AssignmentService();
        }

        public void Initialize(UserInputService inUserInput)
        {
            CourseService courseService = new CourseService(inUserInput);
            UserOutputService outputService = new UserOutputService(courseService);
        }

    }
}
