/*%****************************************************************************80
%  Code: 
%   HeroiCase.cs
%
%  Purpose:
%   Implements sample condicional c# code  
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
	class HeroiCase {
		static void Main() {

			// Declaração de Variáveis
			double mana = 500;
			double forca = 500;
			string classeHeroi = "X"; // Valor inicial aleatório e diferente de G, M ou D

			Console.Clear();

			// Escolha da classe do herói
			Console.WriteLine("Seja bem vindo, nobre herói das terras distantes de Kalindor!\n");
			Console.WriteLine("É chegado o momento da escolha que definirá seu destino em Azeroth:");
			Console.WriteLine("- Se deseja se tornar um GUERREIRO, pressione G");
			Console.WriteLine("- Se deseja se tornar um MAGO, pressione M");
			Console.WriteLine("- Se deseja se tornar um DRUIDA, pressione D");
			classeHeroi = Console.ReadLine();

			// Ajustes dos atributos de força e mana
			if (classeHeroi == "G" || classeHeroi == "g") {
				forca*=1.3;	// +30% de força
				mana*=0.8;  // -20% de mana

				Console.WriteLine("Você agora é um GUERREIRO!");
				Console.WriteLine("Pontos de força: {0} | Pontos de Mana: {1}", forca, mana);
			} else if (classeHeroi == "M" || classeHeroi == "m") {
				forca*=0.6;	// -40% de força
				mana*=1.5;  // +50% de mana

				Console.WriteLine("Você agora é um MAGO!");
				Console.WriteLine("Pontos de força: {0} | Pontos de Mana: {1}", forca, mana);
			} else if (classeHeroi == "D" || classeHeroi == "d") {
				forca*=0.8;	// -20% de força
				mana*=1.3;  // +30% de mana

				Console.WriteLine("Você agora é um DRUIDA!");
				Console.WriteLine("Pontos de força: {0} | Pontos de Mana: {1}", forca, mana);
			} else {
				Console.WriteLine("Opção inválida! Pressione G, M ou D somente.");
			}

		}
	}
}