/*%****************************************************************************80
%  Code: 
%   Loop7.cs
%
%  Purpose:
%   Implements sample loop  c# code  
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

namespace IPJD
{ 
  class Fibonacci
  {  
    static void Main()
    {   
        int a, b, c, F;
 
        Console.Write("Digite um número: ");
        F = int.Parse(Console.ReadLine());
 
        a = 1;
        b = 1;
        c = a + b; 

        Console.WriteLine("{0}", a); 
        Console.WriteLine("{0}", b); 

        do{
          Console.WriteLine("{0}", c); 
          a = b;
          b = c;
          c = a + b;
        } while(c < F);
    }
  }
}