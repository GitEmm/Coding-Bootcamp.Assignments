using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.Services;

namespace IndividualProjectPartA.domain
{
    class Assignment
    {
        //The title of the Assignment
        private string _title;

        public string Title
        {
            get { return _title.ToUpper(); }
            set { _title = value; }
        }

        //A brief description of the assignment
        private string _description;

        public string Description
        {
            get { return _description.ToLower(); }
            set { _description = value; }
        }

        //The date by which the student must submit an assignment
        private DateTime _subDateTime;

        public DateTime SubDateTime
        {
            get { return _subDateTime; }
            set { _subDateTime = value; }
        }

        //The oral mark of the assignment (0>= oralMark <=100)
        private int _oralMark;

        public int OralMark
        {
            get { return _oralMark; }
            set { _oralMark = value; }
        }

        //The total mark of the assignment (0>= totalMark <=100)
        private int _totalMark;

        public int TotalMark
        {
            get { return _totalMark; }
            set { _totalMark = value; }
        }


        // Constructor(s)
        public Assignment()
        {

        }
        
        public Assignment(string inTitle, string inDescription, DateTime inSubDateTime, int inOralMark, int inTotalMark)
        {
            this.Title = inTitle;
            this.Description = inDescription;
            this.SubDateTime = inSubDateTime;
            this.OralMark = inOralMark;
            this.TotalMark = inTotalMark;

        }


    }
}
