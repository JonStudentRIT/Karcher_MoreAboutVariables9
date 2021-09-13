using System;

namespace MoreAboutVariables9
{
    /* Author: Jonathan Karcher
     * Purpose: Edit the users input
     * Restrictions: None
     */
    class Program
    {
        /* Method: Main
         * Purpose: add quotation marks to each word of the users input
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            string input = "";
            // get input from the user
            input = Console.ReadLine();
            // split the input in to an array of strings based on space
            String[] split = input.Split(' ');
            // add quotes to the beginning and end of each string in split
            for(int i = 0; i < split.Length; i++)
            { 
                split[i] = "\"" + split[i] + "\"";
            }
            // rejoin split and display
            Console.WriteLine(string.Join(" ", split));
        }
    }
}
