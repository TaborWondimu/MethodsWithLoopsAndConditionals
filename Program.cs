
using System;
namespace MethodsWithLoopsAndConditionals
{
    public class program
    {
        public static void PrintThousand(int num)
        {
            for (num = 0; num <= 1000; num++)
            {
               
             Console.WriteLine($"postive {num} negative {-num}");
             
            }
        }
        public static void PrintByThrees(int num)
        {
            for ( num = 0; num < 1000; num+=3)
            {
             Console.WriteLine($"increments by 3 {num}");
            }
        }
        public static void EqualChecker(int num1 ,int num2)
        {
            
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }
            else
            {
                Console.WriteLine("They are not equal");
            }
            
        }
        public static void OddEvenChecker(int num1)
        {
            
            if (num1 % 2 != 0)
            {
                Console.WriteLine($"{num1} is odd");

            }
      
            else
            {
                Console.WriteLine($"{num1} is even");
            }
        }
        public static void PosNegChecker(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else 
            {
                Console.WriteLine($"{num} is negative");
            }
        }
        public static void VoterAgeChecker(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("you cannot vote");
            }
        }
        public static void CheckInteger(int  num)
        {
          if (Enumerable.Range(-10,10).Contains(num))   
            {
                Console.WriteLine("number is in range");
            }
          else
            {
                Console.WriteLine("number is not in range");
            }
         }
        public static void MultiplicationTable(int num1, int num2)
        {
            for (num1 = 1; num1 <= 12; num1++)
            {
                for (num2 = 1; num2 <= 12; num2++)
                {
                    Console.WriteLine("{0}*{1} = {2}", num1, num2, (num1 * num2));
                }
                Console.WriteLine("===============");
            }
          
        }
        public static void Main(string[] args)
        {
            // this is for the PrintThousand method
            int num1 = 0;
            PrintThousand(num1);
            
            // this is for the PrintByThree method
            int num2 = 0;
            PrintByThrees(num2);

            // this is for the EqualChecker method
             Console.WriteLine("Please Enter the number to check");
            int num3 = int.Parse(Console.ReadLine());

             Console.WriteLine("Please Enter the other to check");
            int num4 = int.Parse(Console.ReadLine());
            EqualChecker(num3, num4);

            // this is for the OddEven method
            Console.WriteLine("Please Enter Number");
            int num5 = int.Parse(Console.ReadLine());
            OddEvenChecker(num5);

            // this is for thePosNegChecker method
            Console.WriteLine("Please Enter the number to check if positive or negative");
            int num6 = int.Parse(Console.ReadLine());  
            PosNegChecker(num6);

            // this is for the VoterAgeChecker method
            Console.WriteLine("Hello, please enter your age");

            int age = int.Parse(Console.ReadLine());
            VoterAgeChecker(age);

            // This is for the CheckInteger method 
            Console.WriteLine("Please Enter Integer");

            int integ = int.Parse(Console.ReadLine());  
            CheckInteger(integ);

            // This is for the MultiplicationTable
            int product1 = 0;
            int product2  = 0;
            MultiplicationTable(product1, product2);


           
        

        }
     
    
           
        
    }
}
