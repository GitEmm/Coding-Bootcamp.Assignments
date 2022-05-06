using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.Services;


namespace IndividualProjectPartA.domain
{
    class Trainer : SchoolMember
    {
   
        //The subject that a trainer teaches (C#, Java, Python, Javascript)
        private string _subject;


        //***** Maybe i shouldnt give access .... ??? ******
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }


        //Constructor(s)
        public Trainer()
        {

        }

        /*public Trainer(string inFirstName, string inLastName):
            base(inFirstName, inLastName)
        {

        } */
       

        public Trainer(string inFirstName, string inLastName, string inSubject)
        {
            this.FirstName = inFirstName;
            this.LastName = inLastName;
            this.Subject = inSubject;
        }
        
    }
}
