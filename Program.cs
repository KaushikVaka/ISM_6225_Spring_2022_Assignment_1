using System;
using System.Collections.Generic;
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
                int[,] bulls_grid = new int[,] { { 1,1,1,1 }, { 1,1,1,1 }, { 1,1,1,1},{ 1,1,1,1} };    
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

                //Question 6:
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

        //   String is iterated in for loop and if the character is not in vowels array, it is 
         //   concatenated to the empty string final_string and if it is a vowel, the string isn't changed
            private static string RemoveVowels(string s)
            {
                try
                {
                    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                    String final_string = "";
                    for (int i = 0; i < s.Length; i++)
                    {

                        int index = Array.IndexOf(vowels, s[i]); //returns the index of character if it's in vowels array
                        if (index > -1)   //if the character is in vowels array
                        {

                            final_string = final_string;
                        }
                        else
                        {
                            final_string = final_string + s[i]; //if character is not in vowels, concatenate it to final_string
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


            /* Two strings bulls_string11 and bulls_String22 are declared and initialised. Every character in the 
             *  bull_string1 is looped in foreach and appended to bull_string11 and every character in bull_string2
             * is appended to bull_string22. Then both bull_string11 and bull_String22 are compared and if they are
             * same then True is returned, else false is returned.
             */
            private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
            {
                try
                {
                    String bulls_string11 = "";
                    String bulls_string22 = "";

                    foreach (String i in bulls_string1)
                    {
                        bulls_string11 = bulls_string11 + i;
                    }
                    foreach (String j in bulls_string2)
                    {
                        bulls_string22 = bulls_string22 + j;
                    }
                    if (bulls_string11 == bulls_string22)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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


            /* A list add_list is initialised. Count is initialised at the start of for loop, so that every integer
             * which is being looped would be assigned with its own count. Count is increased by 1 if the integer 
             * inside the nested foreach is equal with the integer which is looped on the outer for loop. If the 
             * count is 0, it means that the integer is unique and the integer is appened to add_list and add_list
             * is returned
             */
            private static int SumOfUnique(int[] bull_bucks)
            {
                try
                {
                    int sum = 0;
                    List<int> add_list = new List<int>();
                    foreach (int i in bull_bucks)
                    {
                        int count = 0;
                        foreach (int j in bull_bucks)
                        {
                            if (j == i)
                            {
                                count = count + 1;
                            }
                        }
                        if (count <= 1)
                        {
                            add_list.Add(i);
                        }

                    }
                    foreach (int t in add_list)
                    {
                        sum = sum + t;
                    }
                    return sum;

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


        /* A list of strings bulls_grid3 is initialised. Count is initialised to 0.
         * The 2D array is looped on every element. For the first diagonal, if the element is placed
         * in same indexes are added and the indices are converted to string and added to an empty 
         * array bulls_grid3. For the reverse diagonal, the same thing is done. If the concatenated index is
         * present in the array bulls_grid3, that element is avoided and rest of the element is added to the count
         * and count is returned.
    
         */
        private static int DiagonalSum(int[,] bulls_grid)
            {
                try
                {
                    List<string> bulls_grid3 = new List<string>();
                    int count = 0;
                    int count2 = 0;
                    int count3 = 0;
                    int l = 0;
                    int m = bulls_grid.GetLength(0) - 1;
                    for (int i = 0; i < bulls_grid.GetLength(0); i++)
                    {
                        for (int j = 0; j < bulls_grid.GetLength(0); j++)
                        {
                            if (i == j)
                            {
                                bulls_grid3.Add(i.ToString() + j.ToString());

                                count = count + bulls_grid[i, j];

                            }

                        }

                    }
                    while (l < bulls_grid.GetLength(0) && m >= 0)
                    {
                        if (bulls_grid3.Contains(l.ToString() + m.ToString()) == false)
                        {
                            count2 = count2 + bulls_grid[l, m];
                            m = m - 1;
                            l = l + 1;
                        }
                        else
                        {
                            m = m - 1;
                            l = l + 1;
                            continue;
                        }
                    }
                    count3 = (count + count2);
                    return count3;
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


        /*
         *Empty string bulls_stringg is initialised.  Through while loop, indexes of every integer element
         *present in array is taken. The integer element is taken as index for bulls_string and character 
         * in that index is added to empty string bulls_Stringg
         * 
         */
        private static string RestoreString(string bulls_string, int[] indices)
            {
                
                 try
            {
               int i=0;           
               int ind;
               String bulls_stringg="";
                 while (i< bulls_string.Length)
     {
     
     	    ind=Array.IndexOf(indices,i);
            bulls_stringg=bulls_stringg+bulls_string[ind];
    	    i=i+1;
     }
                return bulls_stringg;
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

        /* Empty string prefix_string is initialized. Number of elements before the first occurence of 
         * ch is obtained via for loop and count. The string is reversed via for loop and concatenated with
         * prefix_string and rest of the string is concatenated to prefix _string via while loop.
         * If the element doesn't exist in given string break the loop.
         * 
         */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                int count = 0;
                String prefix_string = "";
                for (int i = 0; i < bulls_string6.Length; i++)
                {
                    if (bulls_string6[i] != ch)
                    {
                        count = count + 1;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int j = 0; j < count + 1; j++)
                {
                    prefix_string = prefix_string + bulls_string6[count - j];
                }
                int index = count + 1;

                while (index < bulls_string6.Length)
                {
                    prefix_string = prefix_string + bulls_string6[index];
                    index = index + 1;
                }

                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
    }


