using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here
                int l = nums.Length; // storing length of nums in l
                // storing the result missing numbers in a list
                List<int> result = new List<int>();
                // using hashset collection to store all elements in nums in a set
                HashSet<int> set = new HashSet<int>(nums);
                for (int i = 1; i < l; i++)
                {
                    if (!set.Contains(i)) // contains function checks if set contains the particular number or not
                    {
                        result.Add(i); // adding the missing numbers to result;
                    }
                }
                return new List<int>(result); // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Write your code here
                // declaring two lists to store even and odd integers in each
                List<int> even = new List<int>();
                List<int> odd = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0) // checking even or odd condition by checking reminder if divided by 2
                        even.Add(nums[i]); // adding to even list
                    else odd.Add(nums[i]); // adding to ood list

                }
                even.AddRange(odd); // appending elements in odd list to even
                // converting even list to an array to return the result
                int[] result = even.ToArray();
                return result; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here
                int l = nums.Length;
                int[] result = new int[2]; // to store the result indices
                for (int i = 0; i < l; i++)
                {
                    for (int j = i + 1; j < l; j++)
                    {
                        if (nums[i] + nums[j] == target)// checking for sum of two numbers in array adding up to target or not
                        {
                            result[0] = i;
                            result[1] = j;
                            break;
                        }


                    }
                }
                return result; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Write your code here
                int l = nums.Length;
                Array.Sort(nums);// sorting the array using sort function
                int maxprodcut = nums[l - 3] * nums[l - 2] * nums[l - 1]; // product of 3 max integers in array
                return maxprodcut; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                string binary = Convert.ToString(decimalNumber, 2);// converting decimal to binary using ToString function
                return binary; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here
                Array.Sort(nums);
                int min = nums[0];
                return min; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                string s1 = x.ToString(); // converting x to string
                char[] chars = s1.ToCharArray(); // converting string to char array
                Array.Reverse(chars); // revsering the char array
                string s2 = new string(chars);// converting char array to string
                int y = int.Parse(s2); // converting string to int
                if (x == y) // comparing x and y if equal return true else false
                    return true;
                else
                    return false; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                int[] f = new int[n+1]; // creating an array to store sequence
                f[0] = 0;
                f[1] = 1;
                int i = 2; // intializing i to 2
                while (i <= n) // checking for condition if i <= n
                {
                    f[i] = f[i - 1] + f[i - 2];
                    i++;
                }
                return f[n]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
