/*%****************************************************************************80
%  Code: 
%   Loop2.cs
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
  class loop
  {  
    static void Main()
    {
       for(int i=0; i < 5; i++)
         for(int j=0; j < 5; j++)
            Console.WriteLine("Mensagem num. {0} {1}", i, j);
    }
  }
}