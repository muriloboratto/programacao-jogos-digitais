/*%****************************************************************************80
!  Code: 
!   Recursive.cs
!
!  Purpose:
!    Recursive Algorithm
!
!  Modified:
!   Oct 09 2018 10:57 
!
!  Author:
!   Murilo Boratto <muriloboratto 'at' uneb.br>
!
!  How to Compile:
!   mcs Recursive.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!     The program function itself calls its own layer to progress until it
!     reaches a certain condition and step by step returns to the end.               
!     
!****************************************************************************80*/

using System;  

namespace CSharpDatastructuresAlgorithms
{
    class TestFactorial
    {    
        public static int factorial(int n) 
        {
      
          if(n==1)
            return 1;
               else
                 return factorial(n-1)*n;
            
        } /*factorial*/


        public static void Main() 
        {
            int n = 5;
            int f = factorial(n);
     
            Console.Write("Factorial({0}) = {1}\n", n, f);
       
        } /*main*/   
    }    
} 
