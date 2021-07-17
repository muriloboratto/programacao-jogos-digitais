/*%****************************************************************************80
!  Code: 
!   TesMergeSort.cs
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
!   mcs TesMergeSort.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!     MergeSort Algorithm                  
!     
!****************************************************************************80*/

using System;  

namespace CSharpDatastructuresAlgorithms    
{    
    class MergeSortAlgoritm    
    {    
        static public void MergeSort(int[] numbers, int left, int mid, int right)    
        {    
            int[] temp = new int[25];    
            int i, eol, num, pos;  

            eol = (mid - 1);    
            pos = left;   
            num = (right - left + 1);     
  
            while ((left <= eol) && (mid <= right)){    
                if (numbers[left] <= numbers[mid])    
                    temp[pos++] = numbers[left++];    
                else    
                    temp[pos++] = numbers[mid++];    
            }    
            while (left <= eol)    
                temp[pos++] = numbers[left++];    
            while (mid <= right)    
                temp[pos++] = numbers[mid++];   
            for (i = 0; i < num; i++)    
            {    
                numbers[right] = temp[right];    
                right--;    
            }    
        }   
  
        static public void Sort(int[] numbers, int left, int right)    
        {    
            int mid; 

            if (right > left){    
                mid = (right + left) / 2;    
                Sort(numbers, left, mid);    
                Sort(numbers, (mid + 1), right);    
                MergeSort(numbers, left, (mid + 1), right);    
            }    
        }     
  
        static void Main(string[] args) {

            int[] scores = {90, 70, 50, 80, 60, 85};
     
            for(int i = 0; i < scores.Length; i++)
              Console.Write("{0}\t", scores[i]);
       
            Console.Write("\n\nMergeSort:\n\n");

            Sort(scores, 0, 5);  //Sort(array, a, b - 1)    
     
            for(int i = 0; i < scores.Length; i++)
              Console.Write("{0}\t", scores[i]);

            Console.Write("\n");    
           
        }    
    }    
} 