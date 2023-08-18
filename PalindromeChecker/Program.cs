namespace PalindromeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool palindrome = false;

            Console.Write("Enter the word: ");
            string word = Console.ReadLine().ToLower();

            string wordReverse = new string(word.Reverse().ToArray());



            palindrome = CheckPalindrome(word, wordReverse);

            ShowResults(word, palindrome);

            Console.ReadKey();
        }
        private static bool CheckPalindrome(string word, string wordReverse)
        {
            bool palindrome;
            if (word == wordReverse)
            {
                palindrome = true;
            }
            else
            {
                palindrome = false;
            }

            return palindrome;
        }
        private static void ShowResults(string word, bool palindrome)
        {
            if (palindrome)
                Console.WriteLine($"{word} is a palindrome");
            else
                Console.WriteLine($"{word} is not a palindrome");
        }
    }
}