using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace IssuesWithNonGenericCollections
{
    class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();

        public Person GetPerson(int pos) => (Person)arPeople[pos];

        public void addPerson(Person p)
        {
            arPeople.Add(p);
        }

        public void ClearPeople()
        {
            arPeople.Clear();
        }

        IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();
    }
}
