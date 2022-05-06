using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.Services;


namespace IndividualProjectPartA.domain
{
    class DataInput
    {
        // A class that represents a lump of data input that can be used as a single entity...


        //fields and properities (to be continued.....)
        public int noOfCourses { get; set; }
        public Course course { get; set; }

        public int noOfStudents { get; set; }
        public Student student { get; set; }

        public int noOfTrainers { get; set; }
        public Trainer trainer { get; set; }

        public int noOfAssignments { get; set; }
        public Assignment assignment { get; set; }

        //Constructor(s)
        /*public DataInput()
        {

        }
        */
    }
}
