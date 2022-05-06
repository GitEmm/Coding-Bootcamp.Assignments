using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.domain;


namespace IndividualProjectPartA.Services
{
    class AssignmentService
    {
        //fields and properties
        private int _numberOfAssignments;

        public List<Assignment> Assignments;
        private AssignmentDetails assignmentDetails;


        //Constructor(s)
        public AssignmentService()
        {
            Initialize();
            Assignments = GenerateAssignments();
        }
        

        public AssignmentService(AssignmentDetails inAssignmentDetails, int inNumberOfAssignments)
        {
            Initialize(inAssignmentDetails, inNumberOfAssignments);
            Assignments = GenerateAssignments();

        }

        public void Initialize() // Initializes the maximum capacity or number of the assignments
        {

        }

        public void Initialize(AssignmentDetails inAssignmentDetails, int inNumberOfAssignments)
        {
            _numberOfAssignments = inNumberOfAssignments;
            assignmentDetails = inAssignmentDetails;

        }


        public List<Assignment> GenerateAssignments()   // Generate a list of all the assignments across all the courses available
        {
            List<Assignment> assignments = new List<Assignment>();

            Console.WriteLine("A list containing assignments has been created!");
            return assignments;
        }

        /*public List<Assignment> GetAssignments()   // Output a list of all the assignments across all the courses available
        {

        }*/
    }
}
