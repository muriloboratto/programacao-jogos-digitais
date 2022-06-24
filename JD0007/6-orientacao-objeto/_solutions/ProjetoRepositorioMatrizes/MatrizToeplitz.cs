using System;

namespace RepositorioDeMatrizesOOPlus
{
	public class MatrizToeplitz : Matriz
	{
		/* Como o construtor é idêntico ao da superclasse,
		 * basta herdar o código do construtor da superclasse
		 * usando a palavra reservada "base"
		 */
		public MatrizToeplitz (int tamanhoMatriz) : base(tamanhoMatriz)	{}

		/* O termo override indica que o método preencherMatriz 
		 * da superclasse está sendo sobrescrito
		 */
		protected override void preencherMatriz(){
			for(int i = 0; i < this.matriz.GetLength (0); i++) {
				for(int j = 0; j < this.matriz.GetLength (0); j++) {
					if(j == i)  
						matriz[i, j] = 10;
					else {
						for(int z = 1; z <= this.matriz.GetLength (0); z++)	{
							if(j - i == z) 
								matriz[i, j] = 50 + z;
							else if(i - j == z)
								matriz[i, j] = 50 - z;
						}
					}
				}
			}
		}
	}
}

