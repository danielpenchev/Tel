namespace StudentsGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fn;
        private string phoneNumber;
        private string email;
        private List<int> marks;
        private Group groupNumber;

        public Student(string firstName, string lastName, string fn, string phoneNumber, string email, List<int> marks, Group groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get
            { return this.firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("First name cannot be null.");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Last name cannot be null.");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string FN
        {
            get
            {
                return this.fn;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("FN cannot be null.");
                }
                else
                {
                    this.fn = value;
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Phone number cannot be null.");
                }
                else
                {
                    this.phoneNumber = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Email cannot be null.");
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public List<int> Marks
        {
            get { return this.marks; }
        }

        public Group GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }
    }
}
