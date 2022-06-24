/*%****************************************************************************80
%  Code: 
%   Trinta25.cs
%
%  Purpose:
%   Implements sample c# code 
%   Exercise #23 - 'Estruturas Condicionais'
%
%   'O número 3025 tem uma propriedade interessante: 30 + 25 = 55  e  (55)**2  = 3025. 
%    Escreva um programa que lê um número inteiro e determinar se ele possui ou não 
%    essa propriedade.'
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
	class Trinta25
	{
		public static void Main ()
		{
			// Declaração de Variáveis
			int numero;
			int parte1;
			int parte2;

			// Entrada de Dados
			Console.WriteLine ("Informe um número inteiro de 4 dígitos: ");
			numero = int.Parse (Console.ReadLine ());

			// Separação dos dígitos
			parte1 = numero / 100;
			parte2 = numero - (parte1 * 100);

			Console.WriteLine ("Primeira parte do número: " + parte1);
			Console.WriteLine ("Segunda parte do número: " + parte2);

			// Condicional
			if (Math.Pow (parte1 + parte2, 2) == numero) {
				Console.WriteLine ("O número {0} possui a propriedade.", numero);
			} else {
				Console.WriteLine ("O número {0} não possui a propriedade.", numero);
			}
	
		}

	}
}