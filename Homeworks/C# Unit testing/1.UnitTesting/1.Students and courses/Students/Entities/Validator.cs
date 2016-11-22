namespace Students.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public static class Validator
    {
        public static bool StringIsInvalid(string name)
        {
            return string.IsNullOrWhiteSpace(name);
        }

        public static bool IdIsInRange(int id, int min, int max)
        {
            return min <= id && id <= max;
        }
    }
}
