/*%****************************************************************************80
%  Code: 
%   latastinta.cs
%
%  Purpose:
%   Implements sample c# code 
%   Exercise #3 - 'Linguagem de Programação: Entradas e Saídas'
%
%    'Faça um programa que calcule a quantidade necessária de latas de tinta para 
%     pintar uma parede. O programa pergunta a medida de largura e altura da parede 
%     em metros e imprima o resultado (em latas de tintas). Considere que o consumo 
%     de tinta é de 300 ml por metro quadrado e a quantidade de tinta por lata e 
%     de 2 litros.'
%
%  Modified:
%   Mar 28 2019 10:57 
%
%  Author:
%    Murilo Boratto <muriloboratto 'at' uneb.br>
%    Leandro Correia <leandrocorreia 'at' gmail.com>
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
  class LatasTinta
  {
    
    static void Main()
    {
/*
 *  ---------------------------------------------------------------------
 *   VARIAVEIS
 *  ---------------------------------------------------------------------
 */
     double altura, largura, areaParede, litrosTinta, numeroLatasTinta;
     
/*
 *  ---------------------------------------------------------------------
 *   ENTRADA DE DADOS
 *  ---------------------------------------------------------------------
 */     

     Console.WriteLine ("Digite a Altura da Parede:");
     altura = double.Parse(Console.ReadLine());
   
     Console.WriteLine ("Digite a Largura da Parede:");
     largura = double.Parse(Console.ReadLine());
     
/*
 *  ---------------------------------------------------------------------
 *   PROCESSAMENTO
 *  ---------------------------------------------------------------------
 */     
    
     areaParede        = altura * largura;    
     litrosTinta       = areaParede * 0.3;    
     numeroLatasTinta  = litrosTinta / 2;
                                                 
/*
 *  ---------------------------------------------------------------------
 *   SAIDA DE DADOS
 *  ---------------------------------------------------------------------
 */     
      
     Console.WriteLine ("Número de Latas de Tinta: {0} ", numeroLatasTinta );
       
        
    }
  }
}
