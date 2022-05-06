using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.domain;

namespace IndividualProjectPartA.Services
{
    class TrainerService
    {
        //fields and properties

        private int _numberOfTrainers;
        public List<Trainer> Trainers { get; private set; }
        
        
        
        //Constructor(s)
        public TrainerService()
        {
            Initialize();
            Trainers = GenerateTrainers();
        }
        

        //methods

        public void Initialize() // Initializes the maximum capacity or number of the trainers
        {
            // TO DO ------------------------------
        }

        public List<Trainer> GenerateTrainers()  // Generate a list of all the trainers across all the courses available
        {
            List<Trainer> trainers = new List<Trainer>();

            Console.WriteLine("A list containing trainers has been created!");
            return trainers;
        }
        

       /* public List<Trainer> GetTrainers()   // Output a list of all the trainers across all the courses available
        {

        }*/
    }
}
