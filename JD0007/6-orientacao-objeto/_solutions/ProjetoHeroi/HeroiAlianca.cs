/*%****************************************************************************80
%  Code: 
%   HeroiAloianca.cs
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
	public class HeroiAlianca:Heroi
	{
		public HeroiAlianca (String nome, int ptsVida) 
			: base (nome, ptsVida)
		{
		}

		public override void LancarMagia ()
		{
			Console.WriteLine ("Força Rutilante!!!");
		}

		public override void AtacarComArma() {
			Console.WriteLine ("Golpe de espada!!!");
		}

		public override void AumentarVida ()
		{
			base.AumentarVida ();
			this.PtsVida += 0.2f;
		}
	}
}

