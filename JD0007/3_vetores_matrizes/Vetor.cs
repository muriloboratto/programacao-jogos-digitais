/*%****************************************************************************80
%  Code: 
%   Vetor.cs
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
  public class TestOneArray
  {  
    static void Main()
    {
       int[] scores = {90, 70, 50, 80, 60, 85};

       for(int i = 0; i < 5; i++)
          Console.Write("{0}\t", scores[i]);
       
       Console.Write("\n");
       
    }
  }
}
