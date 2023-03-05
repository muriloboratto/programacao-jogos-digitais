/*%****************************************************************************80
!  Code: 
!   TestOneArrayInsert.cs
!
!  Purpose:
!    Linear Table Insert
!
!  Modified:
!   Oct 09 2018 10:57 
!
!  Author:
!   Murilo Boratto <muriloboratto 'at' uneb.br>
!
!  How to Compile:
!   mcs TestOneArrayInsert.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!   Insert a score anywhere in the one-dimensional array scores.                    
!     
!****************************************************************************80*/

using System;

namespace CSharpDatastructuresAlgorithms
{ 

  public class TestOneArrayInsert
  {  

    public static int[] Insert(int[] array, int score, int insertIndex)
    {
     int[] tempArray = new int[array.Length + 1];

     for(int i = 0; i < array.Length; i++)  
     {
      if(i < insertIndex)
        tempArray[i] = array[i];
           else
            tempArray[i+1] = array[i];
      } 

      tempArray[insertIndex] = score;

      return tempArray;

    }/*Insert*/


    public static void Main()
    {
      int[] scores = {90, 70, 50, 80, 60, 85};

      scores = Insert(scores, 100, 3); /*Insert 75 into the position: index = 2*/

      for(int i = 0; i < scores.Length; i++)
          Console.Write("{0}\t", scores[i]);
       
       Console.Write("\n");

    }/*main*/
  }
}