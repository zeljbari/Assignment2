using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_CT_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            int target = 9;
            int[] r = TargetRange(l1, target);
            for (int f = 0; f <= r.Length - 1; f++) // prints value of r
            {
                if (f != r.Length - 1)
                    Console.Write(r[f] + ",");
                else
                    Console.Write(r[f] + "");
               
            }

              Console.WriteLine(" ");
              Console.WriteLine("Question 2"); 
              string s = "University of South Florida"; 
              string rs = StringReverse(s); 
              Console.WriteLine(rs);

             Console.WriteLine("Question #3"); 
              int[] l2 = new int[] { 2, 2, 3, 5, 6 }; 
              int sum = MinimumSum(l2); 
              Console.WriteLine(sum);

              /*Console.WriteLine("Question 4"); 
              string s2 = "Dell"; 
              string sortedString = FreqSort(s2); 
              Console.WriteLine(sortedString);

              Console.WriteLine("Question 5-Part 1"); 
              int[] nums1 = { 1, 2, 2, 1 }; 
              int[] nums2 = { 2, 2 }; 
              int[] intersect1 = Intersect1(nums1, nums2); 
              Console.WriteLine("Part 1- Intersection of two arrays is: "); 
              DisplayArray(intersect1); 
              Console.WriteLine("\n"); 
              Console.WriteLine("Question 5-Part 2"); 
              int[] intersect2 = Intersect2(nums1, nums2); 
              Console.WriteLine("Part 2- Intersection of two arrays is: "); 
              DisplayArray(intersect2); Console.WriteLine("\n"); */

              Console.WriteLine("Question 6"); 
              char[] arr = new char[] { 'a', 'g', 'h', 'a' }; 
              int k = 3; 
              Console.WriteLine(ContainsDuplicate(arr, k));

              /*Console.WriteLine("Question 7"); 
              int rodLength = 4; 
              int priceProduct = GoldRod(rodLength); 
              Console.WriteLine(priceProduct);

              Console.WriteLine("Question 8"); 
              string[] userDict = new string[] { "rocky", "usf", "hello", "apple" }; 
              string keyword = "hhllo";
              Console.WriteLine(DictSearch(userDict, keyword));

              Console.WriteLine("Question 8"); 
              SolvePuzzle();*/

        }

        // public static void DisplayArray(int[] a) { foreach (int n in a) { Console.Write(n + " "); } }

        public static int[] TargetRange(int[] l1, int t)
        {
            try
            {
                int[] a = new int[l1.Length];// declaring an array called a
                a[0] = -1; //initializing the value of a[0] as -1
                int[] b = new int[] { };// creating another empty array called b

                for (int i = 0; i <= l1.Length - 1; i++) // initializing a for loop to run from i=0 to the length of l1
                {
                    if (l1[i] == t) //This if condition check if the ith element of l1 is equal to target
                    {
                        a[0] = i; // if true, the value of a[0] is assigned to i
                        Array.Resize(ref b, b.Length + 1);// Altering the size of array to hold values upto Length+1
                        b[b.Length - 1] = i; 
                    }

                    if (i == (l1.Length - 1) && a[0] == -1)// This if condition checks if the value of i is the last element of l1 and if a[0] is still -1
                    {
                        Array.Resize(ref b, 2); // Resizing the array to hold two values and storing -1 at both
                        b[0] = -1;
                        b[1] = -1;
                        break;
                    }

                }
                return b; //return the values of b

            }

            catch (Exception)
            {
                throw;
            }
        }



        public static string StringReverse(string s)
           {
            try
            {
                String str = ""; // declaring an empty string
                String string1 = "";// declaring another string called str1 to store the string after splitting 
                String string2 = ""; // declaring another string called str2 to store the string after reversing it

                for (int i = 0; i <= s.Length - 1; i++) //initializing a for loop to run from i=0 to the length of string
                {
                    if (s[i] != ' ') // as long as there is no whitespace encountered, we will keep adding the characters to the string 'str'
                    {
                        str = str + s[i];
                        if (i != s.Length - 1)
                            continue;
                    }

                    string1 = str + " ";// string1 stores the elements of str including whitespace
                    str = ""; // after passing str to string1, we are making str empty to hold new elements
                    for (int j = string1.Length - 1; j >= 0; j--) // initializing a for loop to reverse string1
                    {
                        string2 = string2 + string1[j];// string2 will store the reversed string
                    }

                }
                return string2;
            }
         
            catch (Exception)
            {
                throw;
            }
        }

         public static int MinimumSum(int[] l2)
         {
            int sum = 0;// initialized sum =0

            try
             
            {
                for (int i = 0; i <= l2.Length - 1; i++) //Initializing a for loop to run from the 0th index to last element of array
                {

                    sum = sum + l2[i]; // adding sum and the value of ith element and assigning it to sum
                    if (i != l2.Length - 1 && l2[i + 1] == l2[i]) // checking if the ith element is not the last and if so checking whether two consecutive elements are equal, if true incrementing the value if i+1 by 1
                    {
                        l2[i + 1] = l2[i + 1] + 1;
                    }
                }
                return sum; //return the value of sum
            }

            catch (Exception)
            {
                throw;
            }

            }

         /*public static string FreqSort(string s2)
         {
             try
             {                 //Write Your Code Here             }             catch (Exception)             { 

                 throw;
             }             return null;
         }
         public static int[] Intersect1(int[] nums1, int[] nums2)
         {
             try
             {                 // Write your code here             }             catch             {                 throw;             } 

                 return new int[] { };
             }


         public static int[] Intersect2(int[] nums1, int[] nums2)
             {
                 try
                 {                 // Write your code here             }             catch             {                 throw;             } 

                     return new int[] { };
                 } */


         public static bool ContainsDuplicate(char[] arr, int k)
                 {
            try
            {
                bool b;
                Dictionary<int, char> dic = new Dictionary<int, char>(); //creating a dictionary called dic to store key-value pairs

                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    dic.Add(i, arr[i]); // for loop to iterate from 0th to last element of array and add it to dic
                }
                //initializing a lookup table to store index values for each character
                var lookup = dic.ToLookup(c => c.Value, c => c.Key).Where(c => c.Count() > 1);
                //using a foreach loop to traverse through the values in lookup table and find the difference
                foreach (var item in lookup)
                {
                    var keys = item.Aggregate("", (t, u) => t + ", " + u);
                    //Finding the difference by subtracting consecutive occurrences of an element from the first occurrence
                    int diff = keys.ElementAt(5) - keys.ElementAt(2);
                    //validate if the difference is equal to target
                    if (diff >= k)
                    {
                        //return true if the condition is met
                        b = true;
                        return b;
                    }
                }
                return false;


            }

            catch (Exception)
            {
                throw;
            }
        }

        /*    public static int GoldRod(int rodLength) { try {                 //Write Your Code Here
                }
                catch (Exception)
                {

                    throw;
                }
                return 0;
            }
            public static bool DictSearch(string[] userDict, string keyword)
            {
                try
                {                 //Write Your Code Here             }             catch (Exception)             { 

                    throw;
                }             return default;
            }

            public static void SolvePuzzle()
            {
                try
                {                 //Write Your Code Here             }             catch (Exception)             { 

                    throw;
                }         }

        }*/
    }
}

 