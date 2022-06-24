/*%****************************************************************************80
%  Code: 
%   MaiorDeTodos.cs
%
%  Purpose:
%   Implements sample c# code 
%   Exercise #3 - 'Estruturas Condicionais'
%
%   'Escrever um programa para ler um número inteiro e identificar se 
%     ele é par ou impar, escrevendo a mensagem correspondente. '
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

namespace jdip
{
	class MaiorDeTodos
	{
		public static void Main ()
		{
			// Declaração de Variáveis
			int numero1;
			int numero2;
			int numero3;

			// Entrada de Dados
			Console.Write ("Informe o primeiro número (inteiro): ");
			numero1 = int.Parse (Console.ReadLine ());

			Console.Write ("Informe o segundo número (inteiro): ");
			numero2 = int.Parse (Console.ReadLine ());

			Console.Write ("Informe o terceiro número (inteiro): ");
			numero3 = int.Parse (Console.ReadLine ());

			// Estrutura Condicional
			if (numero1 > numero2) {
				if (numero1 > numero3) {
					Console.WriteLine ("O número {0} é o maior de todos!", numero1);
				} else {
					Console.WriteLine ("O número {0} é o maior de todos!", numero3);
				}
			} else if (numero2 > numero3 ) {
				Console.WriteLine ("O número {0} é o maior de todos!", numero2);
			} else {
				Console.WriteLine ("O número {0} é o maior de todos!", numero3);
			}
		}
	}
}
