using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 3, 4, 2, 3 };
            //ElementRepeatedOnce(arr);
        }

        public int ElementRepeatedOnce(int[] arr)
        {
            Dictionary<int, int> myDictionary = new Dictionary<int, int>();
            foreach (int count in arr)
            {

                if (myDictionary.ContainsKey(count))
                {
                    myDictionary[count]++;
                }
                else
                {
                    myDictionary[count] = 1;
                }
            }
            var myResult = myDictionary.OrderBy(i => i.Value).First().Key;
            return (myResult);
        }

        public bool ContainsDuplicatedValueOrNot(int[] arr)
        {
            bool result = true;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                set.Add(i);
            }
            if (arr.Length == set.Count)
            {
                result = false;
            }
            return result;
        }
    }
}
