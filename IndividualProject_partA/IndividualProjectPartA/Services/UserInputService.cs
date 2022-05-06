using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.domain;
using IndividualProjectPartA.Services;


namespace IndividualProjectPartA.Services
{
    class UserInputService
    {
        //fields and properties
        //private DataInput dataInput { get; set; }
        public List<CourseDetails> courseInputCatalog {get; private set; }
        private int numberOfCourses { get; set; }
        
        private int numberOfStudents { get; set; }
        public List<StudentDetails> studentInputCatalog { get; private set; }


        private int numberOfTrainers { get; set; }
        public List<Trainer> trainerInputCatalog { get; private set; }

        private int numberOfAssignments { get; set; }
        public List<Trainer> assignmentInputCatalog { get; private set; }


        //Constructor(s)
        public UserInputService()
        {
            /* Ask the user to input all the required fields according to his/her choice,
               with the ability to add more than one entry at a time */
            // A user makes a choice as to what information wants to provide first
            
            StartInput();
            
            for (int i = 1; i <= numberOfCourses; i++)
            {
                Course course = new Course();
                CourseDetails courseDetails = new CourseDetails();
                courseDetails.DetailsOfCourse = course;

                //Console.WriteLine("TEST 1");

                Console.WriteLine($"What is the title of the {i} course?");
                courseDetails.DetailsOfCourse.Title = Console.ReadLine();

                Console.WriteLine($"What is the stream of course: {courseDetails.DetailsOfCourse.Title} ?");
                courseDetails.DetailsOfCourse.Stream = Console.ReadLine();

                Console.WriteLine($"What is the type of course: {courseDetails.DetailsOfCourse.Title} ?");
                courseDetails.DetailsOfCourse.Type = Console.ReadLine();

                Console.WriteLine($"What is the start date of course: {courseDetails.DetailsOfCourse.Title} ?");
                courseDetails.DetailsOfCourse.StartDate = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine($"What is the end date of course: {courseDetails.DetailsOfCourse.Title} ?");
                courseDetails.DetailsOfCourse.EndDate = Convert.ToDateTime(Console.ReadLine());

                this.courseInputCatalog.Add(courseDetails);
                Console.WriteLine("BINGO");

                
                /*
                Console.WriteLine($"Now please provide the number of the students that are in the course {courseDetails.DetailsOfCourse.Title}");
                numberOfStudents = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Now please provide the number of the trainers that are in the course {courseDetails.DetailsOfCourse.Title}");
                numberOfTrainers = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Now please provide the number of the assignments that are in the course {courseDetails.DetailsOfCourse.Title}");
                numberOfAssignments = Convert.ToInt32(Console.ReadLine());

                for (int j = 1; j <= numberOfStudents; j++)
                {


                    //SchoolMember schoolMember = new SchoolMember();
                    Student student = new Student();
                    StudentDetails studentDetails = new StudentDetails();
                    courseDetails.StudentsOfCourse[j] = student;
                    studentDetails.DetailsOfStudent = student;
                    studentDetails.CoursesOfStudent[j] = courseDetails.DetailsOfCourse;

                    Console.WriteLine("What is the first name of the student");
                    courseDetails.StudentsOfCourse[j].FirstName = Console.ReadLine();
                    studentDetails.DetailsOfStudent.FirstName = courseDetails.StudentsOfCourse[j].FirstName;

                    Console.WriteLine("What is the last name of the student");
                    courseDetails.StudentsOfCourse[j].LastName = Console.ReadLine();
                    studentDetails.DetailsOfStudent.LastName = courseDetails.StudentsOfCourse[j].FirstName;

                    Console.WriteLine("What is the date of birth of the student");
                    courseDetails.StudentsOfCourse[j].DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                    studentDetails.DetailsOfStudent.DateOfBirth = courseDetails.StudentsOfCourse[j].DateOfBirth;

                    Console.WriteLine("What are the tuition fees of the student");
                    courseDetails.StudentsOfCourse[j].TuitionFees = Convert.ToInt32(Console.ReadLine());
                    studentDetails.DetailsOfStudent.TuitionFees = courseDetails.StudentsOfCourse[j].TuitionFees;

                    this.courseInputCatalog[j].StudentsOfCourse.Add(student);
                    this.studentInputCatalog.Add(studentDetails);
                    this.studentInputCatalog[j].CoursesOfStudent.Add(courseDetails.DetailsOfCourse);



                    // Trainers in course
                    Trainer trainer = new Trainer();
                    courseDetails.TrainersOfCourse[j] = trainer;

                    Console.WriteLine("What is the first name of the trainer");
                    courseDetails.TrainersOfCourse[j].FirstName = Console.ReadLine();
                    

                    Console.WriteLine("What is the last name of the trainer");
                    courseDetails.TrainersOfCourse[j].LastName = Console.ReadLine();

                    this.courseInputCatalog[j].TrainersOfCourse.Add(trainer);

                   
                    // Assignments of course
                    Assignment assignment = new Assignment();
                    courseDetails.AssignmentsOfCourse[j] = assignment;
                    studentDetails.AssignmentsOfStudent[j] = courseDetails.AssignmentsOfCourse;
                


                }*/
            }
        }
        //methods
        public void StartInput()
        {
            Console.WriteLine("Greetings !");
            
            Console.WriteLine("What is the total number of all the courses?");
            numberOfCourses = Convert.ToInt32(Console.ReadLine());
            courseInputCatalog = new List<CourseDetails>(numberOfCourses);

            Console.WriteLine("What is the total number of all the students?");
            numberOfStudents = Convert.ToInt32(Console.ReadLine());
            studentInputCatalog = new List<StudentDetails>(numberOfStudents);

            Console.WriteLine("What is the total number of all the trainers?");
            numberOfTrainers = Convert.ToInt32(Console.ReadLine());
            trainerInputCatalog = new List<Trainer>(numberOfTrainers);

            Console.WriteLine("What is the total number of all the assignments?");
            numberOfAssignments = Convert.ToInt32(Console.ReadLine());
            assignmentInputCatalog = new List<Trainer>(numberOfAssignments);

            Console.WriteLine("Please start by providing all the information regarding each of the courses");

        }

    }
}
