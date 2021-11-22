using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSort
{
    class FileManager
    {
        public List<Person> LoadPeople()
        {
            try
            {
                List<Person> thePeople = new List<Person>();
                StreamReader sr = new StreamReader("people.txt");
                while (!sr.EndOfStream)
                {
                    string temp = sr.ReadLine();
                    string[] fandl = temp.Split(' ');

                    Person p = new Person();
                    p.FirstName = fandl[0];
                    p.LastName = fandl[1];

                    thePeople.Add(p);

                }
                sr.Dispose();
                return thePeople;
            }
            catch (Exception)
            {
                
                return null;
            }
        }

        public bool SavePerson(Person person)
        {
            try
            {
                StreamWriter sw = new StreamWriter("saveperson.txt", true);
                sw.WriteLine(person.ToString());

                sw.Dispose();

                return true; 
            }
            catch (Exception)
            {
                
                return false;
            }

        }

        
       

    }
    

}
   

