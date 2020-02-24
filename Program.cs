using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignnment2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            int target = 9;
            int[] r = TargetRange(l1, target);

            Console.WriteLine("[" + r[0] + "," + r[1] + "]");

            Console.WriteLine(" ");
            Console.WriteLine("Question 2");
            string s = "University of South Florida";
            string rs = StringReverse(s);
            Console.WriteLine(rs);

            Console.WriteLine("Question #3");
            int[] l2 = new int[] { 2, 2, 3, 5, 6 };
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);

            Console.WriteLine("Question 4");
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
            DisplayArray(intersect2); Console.WriteLine("\n");

            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            int k = 3;
            Console.WriteLine(ContainsDuplicate(arr, k));

            Console.WriteLine("Question 7");
            int rodLength = 4;
            int priceProduct = GoldRod(rodLength);
            Console.WriteLine(priceProduct);
            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "hhllo";
            Console.WriteLine(DictSearch(userDict, keyword));
            Console.WriteLine("Question 9");
            SolvePuzzle();
        }

        public static void DisplayArray(int[] a)
        {
            Console.Write("[");
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
            Console.Write("]");
        }
        public static int[] TargetRange(int[] marks, int target)
        {
            int firstIndex = -1;
            // Initialize first and second Index variables
            int secondIndex = -1;
            try
            {


                for (int count = 0; count < marks.Length; count++)//Loop as many times as length of marks
                {
                    // if target equals array element and the first index has not been changed yet

                    if (target == marks[count] && firstIndex == -1)

                    {

                        firstIndex = count;// assign the element index to first index and second index

                        secondIndex = firstIndex;

                    }
                    //if target equals array element and the first index has already been set

                    else if (target == marks[count])
                    {
                        secondIndex = count;//update the second index

                    }
                    else if (target != marks[count] && firstIndex != -1)
                    {
                        break;// Stop the loop if indexes have been set and the array element does not equal target
                    }
                    else

                    {
                        //do nothing if element does not equal target and indexes have not been set

                    }

                }

            }
            catch (Exception)
            {
                throw; ;
            }

            return new int[] { firstIndex, secondIndex }; ;//return the output array
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

        public static string FreqSort(string s2)
        {
            try
            {
                // empty dictionary declared
                var letterFreq = new SortedDictionary<string, int>();


                foreach (char letter in s2)
                {
                    if (letterFreq.ContainsKey(letter.ToString()))
                    {
                        letterFreq[letter.ToString()]++;

                    }
                    else
                    {
                        letterFreq.Add(letter.ToString(), 1);
                    }
                }

                string sortedString = "";

                foreach (var x in letterFreq.Reverse())
                {
                    int frequency = x.Value;
                    for (int count = 0; count < frequency; count++)
                    {
                        sortedString += x.Key;
                    }
                }
                return sortedString;


            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            try
            {
                int[] longArray;

                if (nums1.Length >= nums2.Length)
                {
                    longArray = nums1;
                }
                else
                {
                    longArray = nums2;
                }
                // sort arrays
                //Use binary search
                Array.Sort(nums1);
                Array.Sort(nums2);
                var outputList = new List<int>();

                for (int count = 0; count < longArray.Length; count++)
                {
                    int target = longArray[count];
                    if (Array.BinarySearch(nums2, target) != -1 && Array.BinarySearch(nums1, target) != -1)
                    {
                        outputList.Add(target);
                    }
                }

                return outputList.ToArray();
            }
            catch
            {
                throw;
            }
            return new int[] { };

        }

        public static int[] Intersect2(int[] nums1, int[] nums2)
        {

            try
            {
                // Use dictionary

                //initiate empty list to hold the outputs
                var outputList = new List<int>();
                // declare an array called Long array
                int[] longArray;

                if (nums1.Length >= nums2.Length)
                {
                    longArray = nums1;//Longaarray is nums1 if its length is bigger than or equal to nums2's
                }
                else
                {
                    longArray = nums2;//Longarray is nums2 if its length is greater than nums1
                }
                for (int count = 0; count < longArray.Length; count++)//Loop as many times as length of the longest array
                {

                    int element1 = longArray[count];//assign array element to element1

                    //if both inputs contain the element
                    if (nums1.Contains(element1) && nums2.Contains(element1))
                    {
                        outputList.Add(element1);//add the element to the output list variable
                    }


                }


                return outputList.ToArray();//return the elements in output list



            }
            catch
            {
                throw;
            }

            return new int[] { };

        }


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

        public static int GoldRod(int rodLength)
        {
            try
            {
                int[] output = new int[rodLength];
                /*First, we calculate combinations of the length
                with returning the maximum product.*/
                return Combinations(1, rodLength, output, 0);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured in GoldRod method:", e);
            }
            return 0;
        }

        static int product = 1;
        private static int Combinations(int i, int n, int[] a, int index)
        {
            if (n == 0)
            {
                //Calculating the product of the combination.
                int nproduct = FindtheProduct(a, index);
                //If the new product is higher, save it
                if (nproduct > product)
                    product = nproduct;
            }
            //Getting combinations using recursion.
            for (int j = i; j <= n; j++)
            {
                a[index] = j;
                Combinations(j, n - j, a, index + 1);
            }

            //Returning the highest product out of them.
            return product;

        }
        private static int FindtheProduct(int[] a, int n)
        {
            int x = 1;
            for (int i = 0; i < n; i++)
                x = x * a[i];
            return x;
        }

        public static bool DictSearch(string[] userDict, string keyword)
        {

            try
            {

                bool foundOneDifferenceWord = false;// initiate a bool variable with false
                for (int i = 0; i < userDict.Length; i++)//loop through the array
                {
                    string word = userDict[i];// assign each word in the array to variable word


                    if (keyword.Length == word.Length)//if word is the same length as keyword
                    {
                        int differences = 0;//intiate a variable to count the differences in the word
                        for (int count = 0; count < keyword.Length; count++)//loop through each character of both words
                        {

                            if (keyword[count] != word[count])//if difference is found
                            {
                                differences++;//increment differences to show difference found
                            }

                        }

                        if (differences == 1)//if total amount of differences is exactly 1
                        {
                            foundOneDifferenceWord = true;//the bool should return true
                        }
                        else
                        {
                            continue;// check next word
                        }
                    }

                }
                if (foundOneDifferenceWord == true)
                {
                    return true;//return true if a word is found that has only 1 character difference
                }
                else
                {
                    return false;//else return false 
                }
            }
            catch (Exception)
            {
                throw;
            }
            return default;
        }
        public static char[] UniqueLetters(string word, string word2, string word3)
        {
            char[] uniqueLetters = new char[] { };

            string allLetters = word + word2 + word3;

            for (int number = 0; number < allLetters.Length; number++)
            {
                char letter = allLetters[number];

                if (uniqueLetters.Contains(letter) == false)
                {
                    uniqueLetters.Append(letter);
                }

            }


            return uniqueLetters;
        }
        public static void SolvePuzzle()
        {
            try
            {
                string input1 = "UBER";
                string input2 = "COOL";
                string sumInput = "UNCLE";


                char[] input1Array = input1.ToArray();
                char[] input2Array = input2.ToArray();
                char[] sumInputArray = sumInput.ToArray();



                //for loop through all the arrays at once
                //begin at last index and work my way back
                //if the characters are same, then assign 0 to that character
                List<int> possibleDigits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


                char[] uniqueLetters = UniqueLetters(input1, input2, sumInput);
                var dict = new Dictionary<char, int>();
                foreach (char letter in uniqueLetters)
                {

                }

                for (int count = 0; count > 10; count--)
                {
                    char letter1 = input1Array[count];
                    char letter2 = input2Array[count];
                    char letter3 = sumInputArray[count];


                }
                // Every letter is a number between 0 and 9
                // No 2 letters will have the same number value
                // two input strings have to equal output string
                // if output number's length =n and both input words length n-1, leftmost digit ==1
                // if output number's length == length of both input words, leftmostdigit>=2


            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

