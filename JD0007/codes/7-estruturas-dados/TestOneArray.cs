/*%****************************************************************************80
!  Code: 
!   TestOneArray.cs
!
!  Purpose:
!   Linear Table Definition
!
!  Modified:
!   Oct 09 2018 10:57 
!
!  Author:
!   Murilo Boratto <muriloboratto 'at' uneb.br>
!
!  How to Compile:
!   mcs TestOneArray.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!  Sequence of Elements, is a one dimensional array.                    
!     
!****************************************************************************80*/

using System;

namespace CSharpDatastructuresAlgorithms
{ 
  public class TestOneArray
  {  
    public static void Main()
    {
       int[] scores = {90, 70, 50, 80, 60, 85};

       for(int i = 0; i < scores.Length; i++)
          Console.Write("{0}\t", scores[i]);
       
      
       Console.Write("\n");

    }/*main*/
  }
}