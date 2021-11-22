using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Sorter
    {
        public List<Staff> SortAZ(List<Staff> theStaff)
        {
            //LINQ comes in two flavours: Lambda Expressions and Query Expressions
            //They do the exact same thing, just written two different ways.
            //This method uses a Query expression, SortZA uses a Lamda expression.

            //Query Expression
            theStaff = (from n in theStaff
                        orderby n.FirstName, n.LastName
                        select n).ToList();

            return theStaff;
        }

        public List<Staff> SortZA(List<Staff> theStaff)
        {
            //Lambda Expression
            theStaff = theStaff.OrderByDescending(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            return theStaff;
        }
    }
}
