using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Would you like to encrypt or decrypt a message?");
      
      bool checkInput = true;
      while (checkInput == true)
      {
        string input = Console.ReadLine().ToLower();

        if (input == "encrypt")
        {
          checkInput = false;
          string encryptedMessage = String.Join("", cipherFunctionality(input));
          Console.WriteLine(encryptedMessage);
        }
        else if (input == "decrypt")
        {
          checkInput = false;
          string decryptedMessage = String.Join("", cipherFunctionality(input));
          Console.WriteLine(decryptedMessage);
        }
        else
        {
          Console.WriteLine("Please enter either 'encrypt' or 'decrypt'.");
        }
      }
    }

    static char[] cipherFunctionality(string x)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      char[] symbols = new char[] {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')'};
      
      if (x == "encrypt")
      {
        Console.WriteLine("Enter the message you'd like to encrypt: ");
      } else if (x == "decrypt")
      {
        Console.WriteLine("Enter the message you'd like to decrypt: ");
      }
      string userMessage = Console.ReadLine().ToLower();
      
      char[] userMessageArray = userMessage.ToCharArray();
      char[] convertedMessage = new char[8];

      for (int i = 0; i < userMessageArray.Length; i++)
      {
        char messageChar = userMessageArray[i];
        for (int j = 0; j < symbols.Length; j++)
        {
          if (messageChar == symbols[j])
          {
            break;
          }
          else
          {
            int charPosition = Array.IndexOf(alphabet, messageChar);
            int newPosition = 0;
            if (x == "encrypt")
            {
              newPosition = (charPosition + 3) % alphabet.Length;
            }
            else if (x == "decrypt")
            {
              newPosition = (charPosition - 3 + alphabet.Length) % alphabet.Length;
            }
            char convertedChar = alphabet[newPosition];
            convertedMessage[i] = convertedChar;
          }
        }
      }
      return convertedMessage;
    }
  }
}