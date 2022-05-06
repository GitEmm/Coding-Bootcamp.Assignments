using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.domain;
using IndividualProjectPartA.Services;


namespace IndividualProjectPartA.Services
{
    class UserOutputService
    {
        //fields and properties


        //Constructor(s)
        public UserOutputService()
        {


            
        }

        public UserOutputService(CourseService inCourseService)
        {


            StartOutput(inCourseService);
        }

        //methods
        public void StartOutput(CourseService inCourseService) // Outputs general info of the PrivateSchool 
        {
            Console.WriteLine("The contents of the courses are:");
            for(int i = 0; i <= inCourseService.Courses.Count; i++)
            {
                Console.WriteLine(inCourseService.Courses[i].Title);
                Console.WriteLine(inCourseService.Courses[i].Stream);
                Console.WriteLine(inCourseService.Courses[i].Type);
                Console.WriteLine(inCourseService.Courses[i].StartDate);
                Console.WriteLine(inCourseService.Courses[i].EndDate);

            }
           

        }

    }
}
