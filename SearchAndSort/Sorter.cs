using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSort
{
    class Sorter
    {
        public List<Person> SortAZ (List<Person> theList)
        {
            for (int m = 0; m < theList.Count; m++)
            {
                for (int s = 0; s < theList.Count - 1; s++)
                {
                    if (theList[s].ToString().CompareTo(theList[s + 1].ToString()) > 0)
                    {
                        Person temp = theList[s];
                        theList[s] = theList[s + 1];
                        theList[s + 1] = temp;

                    }
                }
            }
            return theList;
        }
        public List<Person> SortZA(List<Person> theList)
        {
            for (int m = 0; m < theList.Count; m++)
            {
                for (int s = 0; s < theList.Count - 1; s++)
                {
                    if (theList[s].ToString().CompareTo(theList[s + 1].ToString()) < 0)
                    {
                        Person temp = theList[s];
                        theList[s] = theList[s + 1];
                        theList[s + 1] = temp;
                        
                    }


                }
            }
            return theList;
        }
        
    }
}
