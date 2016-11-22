using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{

    public static class IEnumerableExtension
    {
        // Sum
        public static T SumExtension<T>(this IEnumerable<T> arr)
        {
            if (arr.Count() == 0)
            {
                throw new NullReferenceException("Fill the array bro!");
            }
            else
            {
                dynamic sum = 0;

                foreach (var element in arr)
                {
                    sum += element;
                }

                return sum;
            }
        }

        // Product
        public static T ProductExtension<T>(this IEnumerable<T> arr)
        {
            if (arr.Count() == 0)
            {
                throw new NullReferenceException("Fill the array!");
            }
            else
            {
                dynamic product = 1;

                foreach (var element in arr)
                {
                    product *= element;
                }

                return product;
            }
        }

        // Min
        public static T MinExtension<T>(this IEnumerable<T> arr)
        {
            if (arr.Count() == 0)
            {
                throw new NullReferenceException("Fill the array!");
            }
            else
            {
                dynamic minValue = arr.First();

                foreach (var element in arr)
                {
                    if (minValue > element)
                    {
                        minValue = element;
                    }
                }

                return minValue;
            }
        }

        // Max
        public static T MaxExtension<T>(this IEnumerable<T> arr)
        {
            if (arr.Count() == 0)
            {
                throw new NullReferenceException("Fill the array!");
            }
            else
            {
                dynamic maxValue = arr.First();

                foreach (var element in arr)
                {
                    if (maxValue < element)
                    {
                        maxValue = element;
                    }
                }

                return maxValue;
            }
        }

        // Average
        public static T AverageExtension<T>(this IEnumerable<T> arr)
        {
            if (arr.Count() == 0)
            {
                throw new NullReferenceException("Fill the array!");
            }
            else
            {
                dynamic sum = 0;

                foreach (var element in arr)
                {
                    sum += element;
                }

                return sum / arr.Count();
            }
        }
    }
}
