/*%****************************************************************************80
%  Code: 
%   Heroi.cs
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
	public abstract class Heroi
	{
		protected string Nome;
		protected float PtsVida;

		public Heroi (String nome, float ptsVida)
		{
			this.Nome = nome;
			this.PtsVida = ptsVida;
		}

		public abstract void LancarMagia ();
		public abstract void AtacarComArma ();

		public virtual void ReduzirVida() {
			this.PtsVida--;
		}

		public virtual void AumentarVida() {
			this.PtsVida++;
		}

		public String GetNome() {
			return this.Nome;
		}

		public float GetPtsVida() {
			return this.PtsVida;
		}
	}
}

