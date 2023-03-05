/*%****************************************************************************80
!  Code: 
!   TestOneArraySearch.cs
!
!  Purpose:
!    Linear Table Search
!
!  Modified:
!   Oct 09 2018 10:57 
!
!  Author:
!   Murilo Boratto <muriloboratto 'at' uneb.br>
!
!  How to Compile:
!   mcs TestOneArraySearch.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!   Search a specifical value in the one-dimensional array scores.                    
!     
!****************************************************************************80*/

using System;

namespace CSharpDatastructuresAlgorithms
{ 

  public class TestOneArraySearch
  {  

    public static void Search(int[] array, int value)
    {
     bool isSearch = false;
      
     for(int i = 0; i < array.Length; i++)  
     {
       if(array[i] == value)
       {
        isSearch = true;
        Console.Write("Found value {0} in the position {1}\n", value, i);
        break;
       }  
         
      } 

      if(!isSearch)
        Console.Write("Value {0} not found!\n", value);

    }/*Search*/


    public static void Main()
    {
      int[] scores = {90, 70, 50, 80, 60, 85};

      for(int i = 0; i < scores.Length; i++)
          Console.Write("{0}\t", scores[i]);
       
       Console.Write("\n");

      int value = 100;

      Search(scores, value); 
          
    }/*main*/
  }
}