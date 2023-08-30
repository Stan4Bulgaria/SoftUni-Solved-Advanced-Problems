
using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DifiningClasses
{
    class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }
        public void AddMember(Person familMembers)
        {
            People.Add(familMembers);
        }
        public Person GetOldestMember()
        {
            int oldest = int.MinValue;
            Person oldestFam = null;
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].Age > oldest)
                {
                    oldestFam = People[i];
                    oldest = oldestFam.Age;
                }
            }
            return oldestFam;
        }
    }
}
