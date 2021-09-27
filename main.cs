using System;

class Program {
  public static void Main (string[] args) {
   
//Get a number as input
//Find if it is a prime number
//Display if prime or not
int n=0;
int c=0;

Console.WriteLine("Enter a number: ");
n = Convert.ToInt32(Console.ReadLine());

  for ( int i=1; i<=n; i++ )
    {
    if( n % i == 0 )
      {
      c++;
      }
    }

  if (c==2)
   {
    Console.WriteLine("The number "+n+ " is prime.");
   }
  else
   {
  Console.WriteLine("The number "+n+" is not prime.");
   }
  }
}
