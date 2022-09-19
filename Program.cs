using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.WriteLine("Write your secret message:");
      string secretMessage=Console.ReadLine();
      secretMessage= secretMessage.ToLower();
      char[] encryptedMessage= new char[secretMessage.Length];
      for (int i=0; i < secretMessage.Length; i++){
        if (Char.IsLetter(secretMessage[i])){
          char ltr=secretMessage[i];
          int position= Array.IndexOf(alphabet, ltr);
          int newPosition= position +3;
          if(newPosition > 25){
            newPosition= newPosition-26;
          }
          encryptedMessage[i]= alphabet[newPosition];
        }
        else{
          encryptedMessage[i]= secretMessage[i];
        }
      }
      Console.WriteLine("Your encrypted message is:");
      Console.WriteLine(encryptedMessage);
    }
  }
}