/*%****************************************************************************80
%  Code: 
%   Loop4.cs
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
       int i = 0;

        do{
          Console.WriteLine("Contador= {0}", i);
          i++;
        } while(i < 10);
    }
  }
}