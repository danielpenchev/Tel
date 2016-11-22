namespace Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte Course { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }
        public Specialties Speciality { get; set; }

        public Student(string firstName, string middleName, string lastName, int ssn,
            string address, string phoneNumber, string email, byte course,
            Universities university, Faculties faculty, Specialties speciality)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Speciality = speciality;
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }
            if (student.FirstName == this.FirstName && student.MiddleName == this.MiddleName &&
                student.LastName == this.LastName && student.SSN == this.SSN &&
                student.Address == this.Address && student.PhoneNumber == this.PhoneNumber &&
                student.Email == this.Email && student.Course == this.Course &&
                student.Speciality == this.Speciality && student.University == this.University &&
                student.Faculty == this.Faculty
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("First name: " + this.FirstName);
            sb.AppendLine("Middle name: " + this.MiddleName);
            sb.AppendLine("Last name: " + this.LastName);
            sb.AppendLine("SSN: " + this.SSN);
            sb.AppendLine("Address: " + this.Address);
            sb.AppendLine("Phone number: " + this.PhoneNumber);
            sb.AppendLine("Email: " + this.Email);
            sb.AppendLine("University: " + this.University);
            sb.AppendLine("Course: " + this.Course);
            sb.AppendLine("Faculty: " + this.Faculty);
            sb.AppendLine("Speciality: " + this.Speciality);

            return sb.ToString();
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Student Clone()
        {
            Student result = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN,
                this.Address, this.PhoneNumber, this.Email, this.Course, this.University, this.Faculty, this.Speciality);
            return result;
        }

        public int CompareTo(Student currentStudent)
        {
            int firstNameCompare = this.FirstName.CompareTo(currentStudent.FirstName);

            if (firstNameCompare != 0)
            {
                return firstNameCompare;
            }
            else
            {
                int middleNameCompare = this.MiddleName.CompareTo(currentStudent.MiddleName);

                if (middleNameCompare != 0)
                {
                    return middleNameCompare;
                }
                else
                {
                    int lastNameCompare = this.LastName.CompareTo(currentStudent.LastName);

                    if (lastNameCompare != 0)
                    {
                        return lastNameCompare;
                    }
                    else
                    {
                        int SSNCompare = this.SSN.CompareTo(currentStudent.SSN);

                        if (SSNCompare != 0)
                        {
                            return SSNCompare;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
