/*%****************************************************************************80
!  Code: 
!   TestOneArrayDelete.cs
!
!  Purpose:
!    Linear Table Delete
!
!  Modified:
!   Oct 09 2018 10:57 
!
!  Author:
!   Murilo Boratto <muriloboratto 'at' uneb.br>
!
!  How to Compile:
!   mcs TestOneArrayDelete.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!   Delete a score of the index = 2 from scores array.                    
!     
!****************************************************************************80*/

using System;

namespace CSharpDatastructuresAlgorithms
{ 

  public class TestOneArrayDelete
  {  

    public static int[] Delete(int[] array, int deleteIndex)
    {
     int[] tempArray = new int[array.Length - 1];

     for(int i = 0; i < array.Length; i++)  
     {
      if(i < deleteIndex)
        tempArray[i] = array[i];
           else
            tempArray[i-1] = array[i];
      } 

      array = tempArray;

      return tempArray;

    }/*Delete*/


    public static void Main()
    {
      int[] scores = {90, 70, 50, 80, 60, 85};

      scores = Delete(scores,  1);

      for(int i = 0; i < scores.Length; i++)
          Console.Write("{0}\t", scores[i]);
       
       Console.Write("\n");

    }/*main*/
  }
}