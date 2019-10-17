using System;

namespace Cohort3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word:");
            //reads user input and converts to lower case
            string word = Console.ReadLine().ToLower();
            int wordlength = word.Length;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            //finds position of last letter in word
            int LastLetter = (wordlength - 1);
            //returns value of 0 if word begins with vowel
            int StartVloc = word.IndexOfAny(vowels);
            //returns value of true if last letter of word is a vowel
            bool EndVloc = word.EndsWith('a') || word.EndsWith('e') || word.EndsWith('i') || word.EndsWith('o') || word.EndsWith('u');
            //returns value of -1 if no vowels in word
            int AnyVow = word.IndexOfAny(vowels, 0, LastLetter);

            //determines if word begins and ends with vowel and adds "yay" to end of word if true
            if ((StartVloc == 0) && (EndVloc == true))
            {
                Console.WriteLine(word + "yay");

            }
            //determines if word begins with vowell and ends with consonant and adds "ay" to end of word if true
            else if ((StartVloc == 0) && (EndVloc == false))
            {
                Console.WriteLine(word + "ay");
            }
            //determines if word has no vowels and adds "ay" to end of word if true
            else if ((AnyVow == -1))
            {
                Console.WriteLine(word + "ay");
            }
            //if word has a vowel and starts with a consonant, move all the letters before the initial vowel to the end, then add "ay"
            else if ((AnyVow > -1) && (StartVloc >0))
            {

            }
            
            






            
        }
    }
}
