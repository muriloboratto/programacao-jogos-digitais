/*%****************************************************************************80
%  Code: 
%   Loop6.cs
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
  class Primo
  {  
    static void Main()
    {  
        int n, divisores, d, numero;
 
        Console.Write("Digite um número: ");
        numero = int.Parse(Console.ReadLine());
 
        
        for( n = 1; n < numero; n++)
        {
          divisores = 0;
           
          for( d = 2; d < (n-1); d++)
          {
             if( (n%d) == 0 )
               divisores = divisores + 1;

          }

          if( divisores == 0 )
            Console.WriteLine("{0}", n); 
        }        
    }
  }
}