/*%****************************************************************************80
%  Code: 
%   tijolo.cs
%
%  Purpose:
%   Implements sample c# code 
%
%   Exercise - 'Entradas e Saídas'
%    'Escreva um programa que calcule a quantidade aproximada de tijolos 
%     que vão ser usados para a construção de uma sala. Solicite a altura e a 
%     largura do tijolo, solicite a altura, largura da sala, solicite as dimensões 
%     da janela e da porta. Considere que a sala é retangular, que possui apenas uma 
%     porta e uma janela.'   
%
%  Modified:
%   Jul 16 2021 10:57
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

    class Tijolo 
    {
        static void Main() 
        {
           // Declaração de Variáveis
           float a_tijolo, l_tijolo, a_parede, l_parede, a_porta, l_porta, a_janela, l_janela; 
           float area_tijolo, area_parede, area_porta, area_janela, tijolos, area_da_sala;

            // Entrada de Dados
            // Tijolo
            Console.WriteLine ("Digite altura do tijolo:");
            a_tijolo = float.Parse(Console.ReadLine()); 
 
            Console.WriteLine ("Digite largura do tijolo:");
            l_tijolo = float.Parse(Console.ReadLine());

            // Parede
            Console.WriteLine ("Digite altura da parede:");
            a_parede = float.Parse(Console.ReadLine());

            Console.WriteLine ("Digite largura da parede:");
            l_parede = float.Parse(Console.ReadLine());

            // Porta
            Console.WriteLine ("Digite largura da porta:");
            l_porta = float.Parse(Console.ReadLine());

            Console.WriteLine ("Digite altura da porta:");
            a_porta = float.Parse(Console.ReadLine());

            // Janela
            Console.WriteLine ("Digite altura da janela:");
            a_janela = float.Parse(Console.ReadLine());

            Console.WriteLine ("Digite largura da janela:");
            l_janela = float.Parse(Console.ReadLine());

            // Processamento de Dados
            area_tijolo = a_tijolo * l_tijolo;
            area_parede = a_parede * l_parede;
            area_porta = a_porta * l_porta;
            area_janela = a_janela * l_janela;

            area_da_sala = (area_parede * 4) - (area_janela + area_porta);
            tijolos = area_da_sala / area_tijolo;

            //Saída de Dados
            Console.WriteLine ("O números de tijolo necessários para a construção são aproximadamente {0} tijolos.", tijolos); 
           
        }
    }    
}