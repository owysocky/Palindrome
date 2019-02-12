using System;


  class Program
  {
    public static bool IsPalindrome(string str)
    {
    int i = 0;
    int j = str.Length - 1;

    while (i<j)
    {
        if (str[i] != str[j])
            return false;
        i++;
        j--;
    }
    return true;
    }
    public static void Main()
    {
      Console.WriteLine("PALINDROM");
      Console.WriteLine("Enter a word/number/sentance: ");
      string userInput = Console.ReadLine();

      Console.WriteLine(IsPalindrome(userInput));

    }
  }
