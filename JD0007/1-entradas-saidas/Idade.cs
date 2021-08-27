/*%****************************************************************************80
%  Code: 
%   Idade.cs
%
%  Purpose:
%   Implements sample c# code 
%   Exercise #2 - 'Linguagem de Programação: Entradas e Saídas'
%   'Escreva um programa que pergunte o nome e a idade de um individuo 
%    e imprima (aproximadamente) quantos dias de vida ele possui.'
%
%  Modified:
%   Mar 28 2019 10:57 
%
%  Author:
%    Murilo Boratto <muriloboratto 'at' uneb.br>
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

namespace myApp
{ 
  class Idade
  {  
    static void Main()
    {
        string nome;
        int idade, numeroDiasTerra;
 
        Console.Write("Digite o nome: ");
        nome = Console.ReadLine();
 
        Console.Write("Digite a idade: ");
        idade = int.Parse(Console.ReadLine());
 
        numeroDiasTerra = idade * 365;  
  
        Console.WriteLine("{0}  você tem  {1} dias de vida na terra", nome, numeroDiasTerra);      
    }
  }
}
