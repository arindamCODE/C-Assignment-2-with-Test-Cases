using System;

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
           int ctr = 1; 
           Console.WriteLine("Please enter the sie of the array:");
           int size = int.Parse(Console.ReadLine());
           int[] arr = new int[size];
           for(int i =0; i<size; i++)
           {
               arr[i] = ctr;
               Console.WriteLine(arr[i]);
               if(i == 10)
               {
                   Console.WriteLine("Reached 10");
               }
               ctr++; 
           }            
        }
    }
}
