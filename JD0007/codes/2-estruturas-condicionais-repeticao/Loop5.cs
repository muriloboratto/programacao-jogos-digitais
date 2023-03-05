/*%****************************************************************************80
%  Code: 
%   Loop5.cs
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
  class PA
  {  
    static void Main()
    {
        int i, primeiro, razao, numero, T, S;
 
        Console.Write("Entre com o primeiro elemento da PA: ");
        primeiro = int.Parse(Console.ReadLine());
 
        Console.Write("Entre com a razão: ");
        razao = int.Parse(Console.ReadLine());

        Console.Write("Entre com o número de termos: ");
        numero = int.Parse(Console.ReadLine());
 
        T = primeiro;
        S = 0; 

        for( i=0; i < numero; i++)
        {
          Console.WriteLine("{0}", T);
          S = S + T;   
          T = T + razao;
        }        

        Console.WriteLine("A soma dos elementos é: {0}", S);   
    }
  }
}