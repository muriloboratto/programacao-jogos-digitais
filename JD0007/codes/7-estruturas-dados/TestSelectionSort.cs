/*%****************************************************************************80
!  Code: 
!   TestSelectSort.cs
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
!   mcs TestSelectSort.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!     Select Sorting Algorithm                  
!     
!****************************************************************************80*/

using System;

namespace CSharpDatastructuresAlgorithms{ 

  public class TestSelectSort{  

    public static void SelectSort(int[] array){
      
     int len = array.Length-1;
     int minIndex; 

     for(int i = 0; i < len; i++){
       
          minIndex = i;

          int minValue = array[minIndex];

          for(int j = i; j < len; j++){
            
            if(minValue > array[j+1]){
             minValue = array[j+1];
             minIndex = j + 1;
            }/*if*/

          }/*for*/

          if(i != minIndex){
            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
          }/*if*/

      }/*for*/

    }/*SelectSort*/


    public static void Main(){

      int[] scores = {90, 70, 50, 80, 60, 85};
     
      for(int i = 0; i < scores.Length; i++)
          Console.Write("{0}\t", scores[i]);
       
      Console.Write("\n\nSelectionSort:\n\n");

      SelectSort(scores); 
     
      for(int i = 0; i < scores.Length; i++)
          Console.Write("{0}\t", scores[i]);

      Console.Write("\n");    
        
    }/*main*/
  }
}