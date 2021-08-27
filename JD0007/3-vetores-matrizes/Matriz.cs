/*%****************************************************************************80
%  Code: 
%   Matriz.cs
%
%  Purpose:
%   Implements sample vector c# code  
%
%  Modified:
%   Mar 28 2019 10:57 
%
%  Author:
%    Murilo Boratto   <muriloboratto 'at' uneb.br>
%    Leandro Correia  <leandro.correia 'at' gmail.com>
%
%  How to Compile:
%   mcs code.cs -o object 
%
%  How to Execute: 
%   mono object
%
%****************************************************************************80*/

using System;

namespace CSharpDatastructuresAlgorithms
{ 
  public class TestOneMatrix
  {  
    static void Main()
    {
       int[,] scores = new int[3, 3] { { 1, 2,3 }, { 4, 5, 6 }, { 7, 8, 9 } };
 
       for(int i = 0; i < 3; i++){
         for(int j = 0; j < 3; j++)
            Console.Write("{0}\t", scores[i, j]);
       
        Console.Write("\n");
       
       }

    }
  }
}
