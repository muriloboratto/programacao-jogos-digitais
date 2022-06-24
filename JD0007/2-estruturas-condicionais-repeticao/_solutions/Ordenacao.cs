/*%****************************************************************************80
%  Code: 
%   Ordenacao.cs
%
%  Purpose:
%   Implements sample c# code 
%   Exercise #1 - 'Estruturas Condicionais'
%
%  'Escrever um programa para ler 2 números e imprimi-los em ordem ascendente.'
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
	class Ordenacao
	{
		public static void Main ()
		{
			// Declaração de Variáveis
			int numero1;
			int numero2;

			// Entrada de Dados
			Console.Write ("Informe o primeiro número: ");
			numero1 = int.Parse (Console.ReadLine ());

			Console.Write ("Informe o segundo número: ");
			numero2 = int.Parse (Console.ReadLine ());

			// Estrutura Condicional
			if (numero1 <= numero2) {
				Console.WriteLine ("{0} {1}", numero1, numero2);
			} else {
				Console.WriteLine ("{0} {1}", numero2, numero1);
			}
		}

	}
}
