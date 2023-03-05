/*%****************************************************************************80
!  Code: 
!   TesQuickSort.cs
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
!   mcs TesQuickSort.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!     QuickSort Algorithm                  
!     
!****************************************************************************80*/

using System;  

namespace CSharpDatastructuresAlgorithms    
{    
    class QuickSortAlgoritm    
    {    
        public static void QuickSort(int[] array, int low, int high)    
        {  
           if(low > high)
             return;
             
           int i         = low;
           int j         = high;
           int threshold = array[low];
           
           while(i < j)
           {
             while(i < j && array[j] > threshold)
              j--;   

             if(i < j) 
              array[i++] = array[j];

             while( i < j && array[i] <= threshold)
              i++;
           
             if(i < j)
              array[j--] = array[i];
          
           }/*while*/    
          
           array[i] = threshold;

           QuickSort(array, low, i-1);

           QuickSort(array, i+1, high);


        }/*QuickSort*/
  

        public static void QuickSort(int[] array)    
        {  
           if(array.Length > 0)
             QuickSort(array, 0, array.Length-1);

        }/*QuickSort*/


        static void Main(string[] args) {

            int[] scores = {90, 70, 50, 80, 60, 85};
     
            for(int i = 0; i < scores.Length; i++)
              Console.Write("{0}\t", scores[i]);
       
            Console.Write("\n\nQuickSort:\n\n");

            QuickSort(scores);     
     
            for(int i = 0; i < scores.Length; i++)
              Console.Write("{0}\t", scores[i]);

            Console.Write("\n");    
           
        } /*main*/   
    }    
} 