namespace Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Person
    {
        private string name;
        private Nullable<int> age;

        public string Name
        {
            get { return this.name; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentException("Name required.");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public Nullable<int> Age
        {
            get { return this.age; }
            set
            {
                if(age <= 0 || age >= 120)
                {
                    throw new ArgumentException("Age cannot be negative or bigger than 120.");
                }
            }
        }

        public Person(string name, Nullable<int> age) 
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Name: " + this.name);

            if(this.age == null)
            {
                builder.Append("Age: null");
            }
            else
            {
                builder.Append("Age: " + this.age);
            }
            return builder.ToString();
        }
    }
}
