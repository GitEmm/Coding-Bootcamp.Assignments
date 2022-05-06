using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectPartA.Services;

namespace IndividualProjectPartA.domain
{
    class AssignmentDetails
    {

        // Not very usefull...

        private Assignment _detailsOfAssignment;

        public Assignment DetailsOfAssignment
        {
            get { return _detailsOfAssignment; }
            set { _detailsOfAssignment = value; }
        }


        // type can be either "Assignment" or "Project (personal or group)"
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }




    }
}
