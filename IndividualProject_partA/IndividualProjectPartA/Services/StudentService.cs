using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.domain;


namespace IndividualProjectPartA.Services
{
    class StudentService
    {
        //fields and properties

        private int _numberOfStudents;

        private StudentDetails studentDetails;

        public List<Student> Students{ get; private set; }



        //Constructor(s)
        public StudentService()
        {
            Initialize();
            Students = GenerateStudents();
        }
        

        public StudentService(StudentDetails inStudentDetails, int inNumberOfStudents)
        {
            Initialize(inStudentDetails, inNumberOfStudents);
            Students = GenerateStudents();
        }


        // methods
        public void Initialize() // Initializes the maximum capacity or number of the students
        {
            // TO DO -------------------------------
        }

        public void Initialize(StudentDetails inStudentDetails, int inNumberOfStudents)
        {
            _numberOfStudents = inNumberOfStudents;
            studentDetails = inStudentDetails;
        }


        public List<Student> GenerateStudents()  // Generate a list of all the Studends across all the courses available
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("A list containing students has been created!");
            return students;
            
        }

        



       /* public List<Student> GetStudents() // Output a list of all the Studends across all the courses available
        {

        }*/
    }
}
