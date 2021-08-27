using System;

namespace RepositorioDeMatrizesOOPlus
{
	/* Classe abstrata que representa qualquer matriz.
	 * Serve de base (superclasse) para os tipos específicos.
	 * 
	 * As operacoes comuns a todas as matrizes sao implementadas aqui
	 * 
	 */

	public abstract class Matriz
	{

		//Atributos
		//Passam a ser protected para que as subclasses possam acessa-los 
		protected int[,] matriz; 

		//Construtor
		public Matriz (int tamanhoMatriz){
			matriz = new int[tamanhoMatriz, tamanhoMatriz];
			this.preencherMatriz ();
		}

		//Getters
		public int getTamanhoMatriz(){
			/*	Retorna o tamanho da dimensao 0 da matriz

				Como se trata de uma matriz quadrada, qualquer 
				dimensao pode ser usada para determinar o tamanho.

				Esta abordagem também descarta a necessidade de um
				atributo para o tamanho da matriz.
			*/
			return this.matriz.GetLength (0);
		} 

		/* Removi o setTamanhoMatriz, porque depois de criada, a matriz 
		   nao vai ter seu tamanho alterado */
		
		//Métodos
		public void imprimirMatriz()
		{
			for(int linha = 0; linha < this.matriz.GetLength (0); linha++){
				for(int coluna = 0; coluna < this.matriz.GetLength (1); coluna++){    
					Console.Write("{0}\t", matriz[linha,coluna]);   
				}
				Console.Write("\n");   
			}

			Console.Write("\n"); 

		}/*imprimirMatriz*/

		/*  A cláusula abstract obriga a implementacao 
		    do metodo na subclasse.
		   
			Cada tipo especifico de matriz vai implementar 
			o seu proprio "preencherMatriz()" 
		*/
		protected abstract void preencherMatriz ();
		
	}
}

