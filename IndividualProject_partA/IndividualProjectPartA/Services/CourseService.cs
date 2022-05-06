using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.domain;


namespace IndividualProjectPartA.Services
{
    class CourseService
    {
        // fields and properties

        private int _numberOfCourses; // the number of courses
        /*private Student[] _studentsOfCourse;
        private Trainer[] _trainersOfCourse;
        private Assignment[] _assignmentsOfCourse;
        */

        private CourseDetails courseDetails;
        private UserInputService courseInput;
        
        public List<Course> Courses { get; private set; }
        

        //Constructor(s)       

        public CourseService()
        {
            Initialize();
            Courses = GenerateCourses();
        }

        public CourseService(UserInputService inUserInput)
        {
                      
            Initialize(inUserInput);
            Courses = GenerateCourses(courseInput, _numberOfCourses);


        }


        /*public CourseService(CourseDetails inCourseDetails, int inNumberOfCourses)
        {
            
            Initialize(inCourseDetails, inNumberOfCourses);
            Courses = GenerateCourses();
        }

        public CourseService(Student[] inStudentsOfCourse, Trainer[] inTrainersOfCourse, Assignment[] inAssignmentOfCourse, int inNumberOfCourses)
        {
            //_numberOfCourses = inNumberOfCourses;
            Initialize(inStudentsOfCourse, inTrainersOfCourse, inAssignmentOfCourse, inNumberOfCourses);
            Courses = GenerateCourses();
        }*/



        //methods

        /*public void Initialize() // Initializes the maximum capacity or number of the courses
        {
           
        }*/

        public void Initialize()
        {
            
        }

        public void Initialize(UserInputService inUserInput)
        {
            this.courseInput = inUserInput;
            this._numberOfCourses = courseInput.courseInputCatalog.Count();
            
        }
       
        
        // possible overloaded Initialize . . .
       
        /*public void Initialize(CourseDetails inCourseDetails, int inNumberOfCourses)
        {
            _numberOfCourses = inNumberOfCourses;
            this.courseDetails = inCourseDetails;
        }


        public void Initialize(Student[] inStudentsOfCourse, Trainer[] inTrainersOfCourse, Assignment[] inAssignmentOfCourse, int inNumberOfCourses)
        {
            _numberOfCourses = inNumberOfCourses;
            _studentsOfCourse = inStudentsOfCourse;
            _trainersOfCourse = inTrainersOfCourse;
            _assignmentOfCourse = inAssignmentOfCourse;
        }*/
        

        public List<Course> GenerateCourses() // Generate a list of all the courses
        {
            List<Course> courses = new List<Course>();

            Console.WriteLine("A list containing courses has been created!");
            
            // TO DO : FILL THE LIST -----------------------------------------
            return courses;
        }

        public List<Course> GenerateCourses(UserInputService inCourseInput, int inNumberOfCourses)
        {
            List<Course> courses = new List<Course>(inNumberOfCourses);
            
            int i = 0;
            do
            {
                this.courseDetails = inCourseInput.courseInputCatalog[i];
                courses.Add(courseDetails.DetailsOfCourse);

                i++;
            } while (courses.Count < inNumberOfCourses);

            
            /* for loop                     
            for(int i=1; i<= inNumberOfCourses; i++)
            {
                Console.WriteLine(i);
                this.courseDetails = inCourseInput.courseInputCatalog[i];
                courses[i-1] = courseDetails.DetailsOfCourse;
            }
            */
            
            Console.WriteLine("A list containing courses has been created!");
           
            return courses;


        }

        // possible overloaded GenerateCourses


        /* public List<Course> GetCourses()  // Output a list of all the courses
         {
             List<Course> coursesOutput = GenerateCourses();

         }*/

    }
}
