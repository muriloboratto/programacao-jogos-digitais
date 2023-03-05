/*%****************************************************************************80
!  Code: 
!   TestOneArrayAppend.cs
!
!  Purpose:
!    Linear Table Append
!
!  Modified:
!   Oct 09 2018 10:57 
!
!  Author:
!   Murilo Boratto <muriloboratto 'at' uneb.br>
!
!  How to Compile:
!   mcs TestOneArrayAppend.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!   Add a score 75 to the end of the one-dimensional array scores.                    
!     
!****************************************************************************80*/

using System;

namespace CSharpDatastructuresAlgorithms
{ 
  public class TestOneArrayAppend
  {  
    public static void Main()
    {
      int[] scores = {90, 70, 50, 80, 60, 85};

      /* Create a new array, Length = scores.Length + 1 */
      int[] tempArray = new int[scores.Length + 1];

      for(int i = 0; i < scores.Length; i++)
          tempArray[i] = scores[i];

      tempArray[scores.Length] = 75;
      scores = tempArray;

      for(int i = 0; i < scores.Length; i++)
          Console.Write("{0}\t", scores[i]);
       
       Console.Write("\n");

    }/*main*/
  }
}