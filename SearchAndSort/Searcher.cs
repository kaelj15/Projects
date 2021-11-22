using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSort
{
    class Searcher
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="theList"></param>
        /// <param name="term"></param>
        /// <returns></returns>
        public List<Person> StartsWith (List<Person> theList, string term)
        {
            List<Person> results = new List<Person>();
            for (int i=0; i < theList.Count; i++)
            {
                if(theList[i].ToString().ToLower().StartsWith(term.ToLower()))
                {
                    results.Add(theList[i]);
                }
            }
            return results;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="theList"></param>
        /// <param name="term"></param>
        /// <returns></returns>
        public List<Person> EndsWith(List<Person> theList, string term)
        {
            List<Person> results = new List<Person>();
            for (int i = 0; i < theList.Count; i++)
            {
                if (theList[i].ToString().ToLower().EndsWith(term.ToLower()))
                {
                    results.Add(theList[i]);
                }
            }
            return results;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="theList"></param>
        /// <param name="term"></param>
        /// <returns></returns>
        public List<Person> Contains(List<Person> theList, string term) //
        {
            List<Person> results = new List<Person>();
            for (int i = 0; i < theList.Count; i++)
            {
                if (theList[i].ToString().ToLower().Contains(term.ToLower()))
                {
                    results.Add(theList[i]);
                }
            }
            return results;
        }
    }
}
