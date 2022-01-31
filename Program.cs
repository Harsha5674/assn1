using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here
                String final_string = "";
                foreach (char h in s)
                    //introducing for loop to check the complete string
                {
                    if (h != 'A' & h != 'E' & h != 'I' & h != 'O' & h != 'U' & h != 'a' & h != 'e' & h != 'i' & h != 'o' & h != 'u')
                    {
                        final_string = final_string + h;
                        //adding the checked string to the empty string, i.e the final string
                    }
                }
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                string[] har1 = bulls_string1;
                string[] har2 = bulls_string2;
                //stores the bulls_string values in these variables
                string ts1 = "";
                string ts2 = "";
                //assignmeent of empty strings to store the operation values
                for (int i = 0; i < har1.Length; i++)
                {
                   ts1 = ts1 + har1[i];
                }
                //the empty string value is added with the first value of string and increments thereby

                for (int i = 0; i < har2.Length; i++)
                {
                    ts2 = ts2 + har2[i];
                }
                //the same operation is done for the next string
                if (ts1 == ts2)
                    //compares both the strings to return whether true or false
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
            /*
            <summary> 
           You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
           Return the sum of all the unique elements of nums.
           Example 1:
           Input: bull_bucks = [1,2,3,2]
           Output: 4
           Explanation: The unique elements are [1,3], and the sum is 4.
           Example 2:
           Input: bull_bucks = [1,1,1,1,1]
           Output: 0
           Explanation: There are no unique elements, and the sum is 0.
           Example 3:
           Input: bull_bucks = [1,2,3,4,5]
           Output: 15
           Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
           </summary>
            */

            private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                int h = 0;
                int length = bull_bucks.Length;
                foreach (int b in bull_bucks)
                    //checks each of the element in the string using "for each" command
                {
                    int count = 0;
                    for (int j = 0; j < length; j++)
                    {
                        if (b == bull_bucks[j])
                        {
                            count = count + 1;
                        }
                    }
                    if (count == 1)
                        //comes out when the count value equals 1
                    {
                        h = h + b;
                    }
                }
                return h;

            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int b = bulls_grid.Length;
                int s = Convert.ToInt32(Math.Sqrt(b));
                int h = 0;
                for (int j = 0; j < s; j++)
                {
                    h = h + bulls_grid[j, j] + bulls_grid[j, s - j - 1];
                }
                if (s % 2 != 0)
                {
                    return h - bulls_grid[(s - 1) / 2, (s - 1) / 2];
                }
                else
                {
                    return h;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                string[] l = new string[bulls_string.Length];
                string b = "";
                for (int j = 0; j < bulls_string.Length; j++)
                {
                    int a = indices[j];
                    l[a] = Convert.ToString(bulls_string[j]);
                }
                for (int j = 0; j < bulls_string.Length; j++)
                {
                    b = b + l[j];
                }
                return b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                string[] m = new string[bulls_string6.Length];
                for (int j = 0; j < bulls_string6.Length; j++)
                {
                    if (bulls_string6[j] == ch)
                    {
                        m = bulls_string6.Split(ch);
                    }
                }
                string c = "";
                for (int k = m[0].Length - 1; k >= 0; k--)
                {
                    c = c + bulls_string6[k];
                }
                String prefix_string = ch + c + m[1];
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}