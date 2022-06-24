using System;

namespace RepositorioDeMatrizesOOPlus
{
	public class MatrizTriangularInferior : Matriz
	{
		/* Como o construtor é idêntico ao da superclasse,
		 * basta herdar o código do construtor da superclasse
		 * usando a palavra reservada "base"
		 */
		public MatrizTriangularInferior (int tamanhoMatriz) : base(tamanhoMatriz)	{}
	
		/* O termo override indica que o método preencherMatriz 
		 * da superclasse está sendo sobrescrito
		 */
		protected override void preencherMatriz(){
			for(int linha = 0; linha < this.matriz.GetLength (0); linha++) {
				for(int coluna = 0; coluna < this.matriz.GetLength (1); coluna++) {
					if(linha <= coluna)
						matriz[linha,coluna] = linha + coluna + 1;
					else 
						matriz[linha,coluna] = 0;
				}
			}
		}
	}
}

