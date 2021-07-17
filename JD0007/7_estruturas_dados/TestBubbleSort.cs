/*%****************************************************************************80
!  Code: 
!   TestBubbleSort.cs
!
!  Purpose:
!    Sorting Algorithm
!
!  Modified:
!   Oct 09 2018 10:57 
!
!  Author:
!   Murilo Boratto <muriloboratto 'at' uneb.br>
!
!  How to Compile:
!   mcs TestBubbleSort.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!     Bubble Sorting Algorithm                  
!     
!****************************************************************************80*/

using System;

namespace CSharpDatastructuresAlgorithms{ 

  public class TestBubbleSort{  

    public static void BubbleSort(int[] array){
      
     for(int i = 0; i < array.Length-1; i++){
        for(int j = 0; j < array.Length-i-1; j++){
          if(array[j] > array[j+1]){
            int flag = array[j];
            array[j] = array[j+1];
            array[j+1] = flag;
          }/*if*/
        }/*for*/
     }/*for*/  
       
    }/*BubbleSort*/


    public static void Main(){

      int[] scores = {90, 70, 50, 80, 60, 85};
     
      for(int i = 0; i < scores.Length; i++)
          Console.Write("{0}\t", scores[i]);
       
       Console.Write("\n\nBubbleSort:\n\n");

      Sort(scores); 
     
      for(int i = 0; i < scores.Length; i++)
          Console.Write("{0}\t", scores[i]);

      Console.Write("\n");    
        
    }/*main*/
  } 
}