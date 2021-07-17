/*%****************************************************************************80
!  Code: 
!   TestInsertSort.cs
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
!   mcs TestInsertSort.cs -o object
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

  public class TestInsertSort{  

    public static void InsertSort(int[] array){
      
      for(int i = 0; i < array.Length; i++){
          
          int insertElement = array[i];
          int insertPosition = i;

          for(int j = insertPosition - 1; j >=0; j--){
          
            if(insertElement < array[j]){
              array[j+1] = array[j];
              insertPosition--;
            }/*if*/

          }/*for*/       

          array[insertPosition] = insertElement;
       
      }/*for*/
      
    }/*InsertSort*/


    public static void Main(){

      int[] scores = {90, 70, 50, 80, 60, 85};
     
      for(int i = 0; i < scores.Length; i++)
          Console.Write("{0}\t", scores[i]);
       
      Console.Write("\n\nInsertSort:\n\n");

      InsertSort(scores); 
     
      for(int i = 0; i < scores.Length; i++)
          Console.Write("{0}\t", scores[i]);

      Console.Write("\n");    
        
    }/*main*/
  }
}