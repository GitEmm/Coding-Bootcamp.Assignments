using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.Services;


namespace IndividualProjectPartA.domain
{
    class Course
    {
        //fields and properties

        //The title of the course (CB1 to CB10)
        private string _title;
        
        public string Title
        {
            get { return _title.ToUpper(); }
            set { _title = value; }
        }

        /*The type of the course 
         * (for C#: FTCS, PTCS)
         * (for Java: FTJV, PTJV)
         * (for Python: FTPT, PTPT)
         * (for Javascript: FTJS, PTJS)
        */
        private string _type;

        public string Type
        {
            get { return _type.ToUpper(); }
            set { _type = value; }
        }


        //The stream of the course (which can be Web, Mobile, Games, Desktop, Cloud)
        private string _stream;

        public string Stream
        {
            get { return _stream.ToUpper(); }
            set { _stream = value; }
        }

        //The date that the course starts
        private DateTime _start_date;

        public DateTime StartDate
        {
            get { return _start_date; }
            set { _start_date = value; }
        }

        //The date that the course ends
        private DateTime _end_date;

        public DateTime EndDate
        {
            get { return _end_date; }
            set { _end_date = value; }
        }


        //Constructor(s)
        public Course()
        {

        }
        
        public Course(string inTitle, string inStream, string inType, DateTime inStartDate, DateTime inEndDate)
        {
            this.Title = inTitle;
            this.Stream = inStream;
            this.Type = inType;
            this.StartDate = inStartDate;
            this.EndDate = inEndDate;

        }


    }
}
