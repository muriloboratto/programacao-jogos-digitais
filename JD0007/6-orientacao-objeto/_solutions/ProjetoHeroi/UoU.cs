/*%****************************************************************************80
%  Code: 
%   UoU.cs
%
%  Purpose:
%   Implements sample c# code OO with heritage.
%   Uorcrefiti Game

%  Modified:
%   Mar 28 2019 10:57 
%
%  Author:
%    Murilo Boratto <muriloboratto 'at' uneb.br>
%    Leandro Correia  <leandro.correia 'at' gmail.com>
%
%  How to Compile:
%   mcs UoU.cs Heroi.cs  HeroiAlianca.cs HeroiHorda.cs -o object 
%
%  How to Execute: 
%   mono object
%
%  Classes:
%
%  public class UoU
%  {
%   + public static void Main();
%  }
%
%  public abstract class Heroi
%  {
%   - protected string Nome;
%   - protected float PtsVida;
%
%   + public Heroi (String nome, float ptsVida);
%   + public abstract void LancarMagia();
%   + public abstract void AtacarComArma();
%   + public virtual void ReduzirVida();
%   + public virtual void AumentarVida();
%   + public String GetNome(); 
%   + public float GetPtsVida();
%  } 
%
%  public class HeroiAlianca:Heroi
%  {
%   + public HeroiAlianca (String nome, int ptsVida): base (nome, ptsVida);
%   + public override void LancarMagia();
%   + public override void AtacarComArma(); 
%   + public override void AumentarVida();
%  }
%
%  public class HeroiHorda:Heroi
%  {
%   + public HeroiHorda (String nome, int ptsVida): base(nome, ptsVida);
%   + public override void LancarMagia();
%   + public override void AtacarComArma(); 
%   + public override void ReduzirVida();
%  }
%
%****************************************************************************80*/

using System;

namespace ppjlab02
{
	public class UoU
	{
		public static void Main ()
		{
			Console.Clear ();
			Console.ForegroundColor = ConsoleColor.Gray;

			//Heroi da Alianca
			Console.ForegroundColor = ConsoleColor.Yellow;

			Heroi a = new HeroiAlianca ("Zadur", 100);
			Console.WriteLine (a.GetNome () + " " + a.GetPtsVida ());

			Console.WriteLine ("Reduzindo vida de " + a.GetNome () + "...");
			a.ReduzirVida ();
			Console.WriteLine (a.GetNome () + " " + a.GetPtsVida ());

			Console.WriteLine ("Aumentando vida de " + a.GetNome () + "...");
			a.AumentarVida ();
			Console.WriteLine (a.GetNome () + " " + a.GetPtsVida ());

			//Heroi da Horda

			Console.ForegroundColor = ConsoleColor.Red;

			Heroi o = new HeroiHorda ("Zodar", 100);
			Console.WriteLine (o.GetNome () + " " + o.GetPtsVida ());

			Console.WriteLine ("Reduzindo vida de " + o.GetNome () + "...");
			o.ReduzirVida ();
			Console.WriteLine (o.GetNome () + " " + o.GetPtsVida ());

			Console.WriteLine ("Aumentando vida de " + o.GetNome () + "...");
			o.AumentarVida ();
			Console.WriteLine (o.GetNome () + " " + o.GetPtsVida ());

			Console.ForegroundColor = ConsoleColor.Gray;

			//Demonstrando polimorfismo
			a.AtacarComArma ();
			o.AtacarComArma ();

			a.LancarMagia ();
			o.LancarMagia ();

		}
	}
}

