/*%****************************************************************************80
%  Code: 
%   Tempo.cs
%
%  Purpose:
%   Implements sample c# code 
%   Exercise #4 - 'Linguagem de Programação: Entradas e Saídas'
%   'Escreva um programa que pergunte qual o tempo transcorrido em um 
%    cronômetro em horas, minutos e segundos, e transforme (e exiba) 
%    todo este tempos em segundos.'   
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

namespace jdip {

    class Tempo
    {
        static void Main() 
        {    
            // Declaração de Variáveis
            int horas, minutos, segundos;
            int tempoEmSegundos;

            // Entrada de Dados - Tempo em horas
            Console.Write("Horas no cronômetro: ");
            horas = int.Parse(Console.ReadLine());

            // Entrada de Dados - Tempo em minutos
            Console.Write("Minutos no cronômetro: ");
            minutos = int.Parse(Console.ReadLine());

            // Entrada de Dados - Tempo em segundos
            Console.Write("Segugundos no cronômetro: ");
            segundos = int.Parse(Console.ReadLine());
            
            // Processamento -Calculo do tempo total em segundos
            tempoEmSegundos = ((horas * 60 + minutos) * 60) + segundos;
            
            // Saída de Dados - Resultado
            Console.WriteLine("Tempo decorrido em segundos: " + tempoEmSegundos);
        }
    }    
}