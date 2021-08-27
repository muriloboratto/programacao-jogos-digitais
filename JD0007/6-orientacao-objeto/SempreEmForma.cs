/*%****************************************************************************80
%  Code: 
%   SempreEmForma.cs
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

namespace ppjlab01
{
    public class Pessoa
	{
		private short peso;
		private float altura;
		private String nome;

		public Pessoa (short peso, float altura, String nome)
		{
			this.peso = peso;
			this.altura = altura;
			this.nome = nome;
		}

		public float calcularIMC()
		{
			return this.peso / (this.altura * this.altura);
		}

		public float calcularIMC(short peso, float altura) 
		{
			this.peso = peso;
			this.altura = altura;
			return this.peso / (this.altura * this.altura);
		}

		public String avaliarIMC() 
		{
			if (this.calcularIMC() < 18.5f) 
			{
			  return "BAIXO";
			} else if ((this.calcularIMC() >= 18.5f)&&(this.calcularIMC() < 25f)) 
			   {
				 return "NORMAL";
			   } else {
				   return "ALTO"; 
			}
		}

		public void emagrecerParaMeta(int meta) 
		{
			Console.WriteLine ("Emagrecendo...");

			while (this.peso > meta) 
				this.peso--;

			Console.WriteLine ("Meta alcançada.");
		}

		public void engordarParaMeta (int meta) 
		{

			Console.WriteLine ("Engordando...");

			while (this.peso < meta) 
				this.peso++;
		
			Console.WriteLine ("Meta alcançada.");
		}

		public short getPeso() 
		{
			return this.peso;
		}

		public void setPeso(short peso) 
		{
			this.peso = peso;
		}

		public float getAltura() 
		{
			return this.altura;
		}

		public void setAltura(float altura) 
		{
			this.altura = altura;
		}

		public String getNome() 
		{
			return this.nome;
		}

		public void setNome(String nome) 
		{
			this.nome = nome;
		}

	}/*Pessoa*/
   

	public class SempreEmForma
	{

		public static void Main()
		{
		
			Console.WriteLine ();
			Console.WriteLine ("---------------------");
			Console.WriteLine ("SEMPRE EM FORMA - 1.0");
			Console.WriteLine ("---------------------");
			Console.WriteLine ();

			String nome = "";
			short peso = 0;
			float altura = 0f;

			Console.Write ("Qual seu nome? ");
			nome = Console.ReadLine ();
			 
			Console.Write ("Qual seu peso? ");
			peso =	Int16.Parse(Console.ReadLine ());
			
			Console.Write ("Qual sua altura? ");
			altura = float.Parse(Console.ReadLine ());
			
			Pessoa p = new Pessoa (peso, altura, nome);

			Console.WriteLine ("Nome: " + p.getNome ());
			Console.WriteLine ("Peso: " + p.getPeso());
			Console.WriteLine ("Altura: " + p.getAltura());
			Console.WriteLine ("IMC: " + p.calcularIMC());
			Console.WriteLine ("Avaliação IMC: " + p.avaliarIMC ());
			Console.WriteLine ("-----------------------------------");
			p.emagrecerParaMeta (30);
			Console.WriteLine ("Novo peso: " + p.getPeso());
			p.engordarParaMeta (80);
			Console.WriteLine ("Novo peso: " + p.getPeso());

			Console.WriteLine ("Seu peso ou sua altura mudaram?");
			Console.WriteLine ("Informe seu novo peso:");
			peso = Int16.Parse(Console.ReadLine ());
			Console.WriteLine ("Informe sua nova altura:");
			altura = float.Parse(Console.ReadLine ());
			Console.WriteLine ("Seu novo IMC é "+p.calcularIMC(peso,altura));
		 
		}
	}
}

