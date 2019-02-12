using System;


  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("PALINDROM");
      Console.WriteLine("Enter a word/number/sentance: ");
      string userInput = Console.ReadLine();

      bool IsPalindrome(string str)
      {
      int i = 0;
      int j = str.Length - 1;

      while (i<j)
      {
          if (str[i] != str[j])
              return false;
              Console.WriteLine("false");

          i++;
          j--;
      }
      return true;
      Console.WriteLine("true");
      }

      void IsPalindrome(userInput);

    }
  }
