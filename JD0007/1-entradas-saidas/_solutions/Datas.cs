/*%****************************************************************************80
%  Code: 
%   datas.cs
%
%  Purpose:
%   Implements sample c# code 
%   Exercise #6 - 'Linguagem de Programação: Entradas e Saídas'
%       'Considerando um calendário hipotético onde os 12 meses do ano possuem 
%		exatamente 30 dias cada um. Escreva um programa que solicite duas datas 
%		onde: o dia da segunda seja maior ou igual que a primeira, o mês da segunda 
%		seja maior ou igual à primeira, o ano da segunda seja maior ou igual à primeira; 
%		e imprima:
%	
%		a) A diferença total de anos entre as duas datas.
%		b) A diferença total de meses entre as duas datas.
%		c) A diferença total de dias entre as duas datas.'
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

	namespace jdip 
	{
	    class Data 
	    { 
	        static void Main()
	        {
				// Declaração de Variáveis
	            int dia1, mes1, ano1;
	            int dia2, mes2, ano2;
	            int difDia, difMes, difAno;

	            // Leitura de Dados - Data 1
	            Console.WriteLine("Digite a primeira data:");
	            Console.Write("Dia: ");
	            dia1 = int.Parse(Console.ReadLine());
	
	            Console.Write("Mês: ");
	            mes1 = int.Parse(Console.ReadLine());
	
	            Console.Write("Ano: ");
	            ano1 = int.Parse(Console.ReadLine());
	
	            Console.WriteLine("Data 1 = " + dia1 + "/" + mes1 + "/" + ano1);
	            Console.WriteLine("< Pressione <ENTER> para continuar >");
	            Console.ReadLine();
	
	            // Leitura de Dados - Data 1
	            Console.WriteLine("Digite a segunda data:");
	            Console.Write("Dia: ");
	            dia2 = int.Parse(Console.ReadLine());
	
	            Console.Write("Mês: ");
	            mes2 = int.Parse(Console.ReadLine());
	
	            Console.Write("Ano: ");
	            ano2 = int.Parse(Console.ReadLine());
	
	            Console.WriteLine("Data 2 = " + dia2 + "/" + mes2 + "/" + ano2);
	            Console.WriteLine("< Pressione <ENTER> para continuar >");
	            Console.ReadLine();

	            // Processamento dos Dados
	            difDia = (((ano2 * 12) + mes2) * 30 + dia2) - (((ano1 * 12) + mes1)* 30 + dia1);
	            difMes = difDia / 30;
	            difAno = difMes / 12;
	
	            // Saída dos Dados
	            Console.WriteLine("Data 1 = {0}/{1}/{2}", dia1, mes1, ano1);
	            Console.WriteLine("Data 2 = {0}/{1}/{2}", dia2, mes2, ano2);
	            Console.WriteLine("Anos de diferença: {0}", difAno);
	            Console.WriteLine("Meses de diferença: {0}", difMes);
	            Console.WriteLine("Dias de diferença: {0}", difDia);
	
	        }
	    }    
	}