namespace GroupStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GroupStudents
    {
        private string firstName;
        private string lastName;
        private string groupName;

        public GroupStudents(string firstName, string lastName, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.GroupName = groupName;
        }

        public string FirstName
        {
            get { return this.firstName; }

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
            get { return this.lastName; }

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

        public string GroupName
        {
            get { return this.groupName; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Group name cannot be null.");
                }
                else
                {
                    this.groupName = value;
                }
            }
        }
    }
}
