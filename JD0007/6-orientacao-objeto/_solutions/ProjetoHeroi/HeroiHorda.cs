/*%****************************************************************************80
%  Code: 
%   HeroiHorda.cs
%
%  Purpose:
%   Implements sample c# code OO.
%
%  Modified:
%   Mar 28 2019 10:57 
%
%  Author:
%    Murilo Boratto <muriloboratto 'at' uneb.br>
%    Leandro Correia  <leandro.correia 'at' gmail.com>
%
%  How to Compile:
%   mcs code.cs  -o object 
%
%  How to Execute: 
%   mono object
%
%****************************************************************************80*/

using System;

namespace ppjlab02
{
	public class HeroiHorda:Heroi
	{
		public HeroiHorda (String nome, int ptsVida)
			:base(nome,ptsVida)
		{
		}
	
		public override void LancarMagia ()
		{
			Console.WriteLine ("Caminho de chamas!!!");
		}

		public override void AtacarComArma() {
			Console.WriteLine ("Golpe de machado!!!");
		}

		public override void ReduzirVida ()
		{
			this.PtsVida-=0.8f;
		}
	
	}
}

