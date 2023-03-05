/*%****************************************************************************80
%  Code: 
%   Gasolina.cs
%
%  Purpose:
%   Implements sample c# code 
%   Exercise #1 - 'Linguagem de Programação: Entradas e Saídas'
%   'Escreva um programa capaz de calcular o preço médio da gasolina considerando três postos de 
%    combustível de Salvador. Solicitando ao usuário que informe o nome e o valor da gasolina em cada
%    um dos três postos.'
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
  class Gasolina
  {
    static void Main()
    {
        float valorPosto1, valorPosto2, valorPosto3, mediaReaisPrecosGasolinas;

        Console.WriteLine ("Entre com o valor da Gasolina do Posto 1:");
        valorPosto1 = float.Parse(Console.ReadLine());  

        Console.WriteLine ("Entre com o valor da Gasolina do Posto 2:");
        valorPosto2 = float.Parse(Console.ReadLine()); 

        Console.WriteLine ("Entre com o valor da Gasolina do Posto 3:");
        valorPosto3 = float.Parse(Console.ReadLine()); 

        mediaReaisPrecosGasolinas = (valorPosto1 + valorPosto2 + valorPosto3)/3;

        Console.WriteLine ("Valor Médio da Gasolina é (R$): {0}",  mediaReaisPrecosGasolinas);     
    }
  }
}
