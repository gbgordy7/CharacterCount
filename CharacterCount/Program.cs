using System;
using System.Collections;

//count the number of occurrences of a character in a string

namespace CharacterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a bunch of characters:");
            string characters = Console.ReadLine().ToLower();

            //create an array out of the characters
            char[] chars = characters.ToCharArray();

            Hashtable hash = new Hashtable();

            //cycle through the characters in the string
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];

                //if the hash contains the character increment it's value
                //if it doesn't contain the character then add to the table
                if (hash.ContainsKey(c))
                    hash[c] = (int)hash[c] + 1;
                else
                    hash.Add(c, 1);
            }

            Console.WriteLine();

            //write the hashtable to the console
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }

            Console.WriteLine();
            Console.WriteLine("OR...in alphabetical order...");

            //OR...write in alphabetic order
            char[] alpha = { 'a', 'b', 'c', 'd', 'e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };

            foreach (char c in alpha)
            {
                Console.WriteLine("{0}:{1}", c, hash[c]);
            }

            Console.ReadLine();

        }
    }
}
