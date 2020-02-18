using System;

namespace ClassLibrary1.model
{
    public class Gender
    { 
        public string Name { get; }
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("imja ne moshe botu pystum abo nu4", nameof(name));

            }

            Name = name;

            public override string ToString()
        {
            return Name;
        }

    }


    }
}
