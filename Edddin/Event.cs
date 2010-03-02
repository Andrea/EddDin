using System;

namespace Edddin
{
    public class Event
    {
        
        public Event(string name, Person person)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException();
            if (person == null) throw new ArgumentException();

        }
    }
}