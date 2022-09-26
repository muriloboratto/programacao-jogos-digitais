/*%****************************************************************************80
%  Code: 
%   Tabuada.cs
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

namespace questao2
{ 

  public class sample
  {  

    static void tabuada(int numero, int operador)
    {
    
     for (int x = 0; x <= 10; x++)
     {
       switch (operador)
       {
        case 1:  Console.WriteLine(numero + " * " + x + " = " + numero * x); break;
       
        
       }
      }
    
    }

    static void Main()
    {
        int numero, operador;
        string simbolo;

        Console.Write("Digite o número: ");
        numero = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o operador: ");
        simbolo = Console.ReadLine();

        if(simbolo == "*")
           tabuada(numero, 1);

    
    }/*main*/
  
  }/*class SomaPrimosIntervalo*/

}/*namespace*/
