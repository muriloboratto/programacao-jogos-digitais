/*%****************************************************************************80
%  Code: 
%   ParOuImpar.cs
%
%  Purpose:
%   Implements sample c# code 
%   Exercise #2 - 'Estruturas Condicionais'
%
%  'Escrever um programa para ler um número inteiro e identificar se  
%   ele é par ou impar, escrevendo a mensagem correspondente.'
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
	class ParOuImpar
	{
		public static void Main ()
		{
			// Declaração de Variáveis
			int numero;

			// Entrada de Dados
			Console.Write ("Informe um número inteiro: ");
			numero = int.Parse (Console.ReadLine ());

			// Condicional
			if (numero%2 == 0) {
				Console.WriteLine ("O número {0} é PAR.", numero);
			} else {
				Console.WriteLine ("O número {0} é IMPAR.", numero);
			}
		}
	}
}
