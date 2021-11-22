using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Searcher
    {
        public List<Staff> Search(List<Staff> theStaff, string term)
        {
            List<Staff> searchResults = new List<Staff>();

            //Lamda expression used to search a list (First and Last names only), x represents each object in the list
            searchResults = theStaff.Where(x => (x.FirstName + " " + x.LastName).Contains(term)).ToList();

            //This version includes the Office property as a searchable field
            //searchResults = theStaff.Where(x => (x.FirstName + " " + x.LastName + " " + x.Office).Contains(term)).ToList();

            //A quicker way to write the above line is to just use the ToString() method as it already represents all three properties
            //searchResults = theStaff.Where(x => x.ToString().Contains(term)).ToList();

            return searchResults;
        }
    }
}
