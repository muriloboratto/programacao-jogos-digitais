/*%****************************************************************************80
%  Code: 
%   Principal.cs
%
%  Purpose:
%   Matrix Repository
%
%  Modified:
%   Sep 12 2019 10:57 
%
%  Author:
%    Murilo Boratto   <muriloboratto 'at' uneb.br>
%    Leandro Correia  <leandro.correia 'at' gmail.com>
%
%  How to Compile:
%    mcs Principal.cs Matriz.cs MatrizAleatoria.cs  MatrizDiagonal.cs MatrizToeplitz.cs MatrizTriangularInferior.cs  MatrizTriangularSuperior.cs -o object
%
%  How to Execute: 
%    mono object
%
%  Classes:
%   
%  public class Principal
%  {
%    + public static void Menu();
%    + public static void Main();
%  }
%
%  public abstract class Matriz
%  {
%   - protected int[,] matriz; 
%
%   + public Matriz (int tamanhoMatriz);
%   + public int getTamanhoMatriz();
%   + public void imprimirMatriz();
%   + protected abstract void preencherMatriz();    
%  }
%
%  public class MatrizAleatoria : Matriz
%  {
%   + public MatrizAleatoria (int tamanhoMatriz) : base(tamanhoMatriz);
%   + protected override void preencherMatriz();   
%  }
%
%  public class MatrizDiagonal : Matriz
%  {
%   + public MatrizDiagonal (int tamanhoMatriz) : base(tamanhoMatriz);
%   + protected override void preencherMatriz();  
%  }
%
%  public class MatrizToeplitz : Matriz
%  {
%   + public MatrizToeplitz (int tamanhoMatriz) : base(tamanhoMatriz);
%   + protected override void preencherMatriz();  
%  }
%
%  public class MatrizTriangularInferior : Matriz
%  {
%   + public MatrizTriangularInferior (int tamanhoMatriz) : base(tamanhoMatriz);
%   + protected override void preencherMatriz();  
%  }
%
%  public class MatrizTriangularSuperior : Matriz
%  {
%   + public MatrizTriangularSuperior (int tamanhoMatriz) : base(tamanhoMatriz);
%   + protected override void preencherMatriz();  
%  }
%
%****************************************************************************80*/

using System;

namespace RepositorioDeMatrizesOOPlus
{ 
  
  public class Principal
  {  
   public static void Menu()
   {
      int opcao;
      
      Console.Clear();
      Console.WriteLine("------------------------");
      Console.WriteLine("REPOSITORIO DE MATRIZES");
      Console.WriteLine("-----------------------");
    
      do{      
          Console.WriteLine ("Digite o tipo de matriz:");
          Console.WriteLine("1: ALEATÓRIA PURA");
          Console.WriteLine("2: TOEPLITZ");
          Console.WriteLine("3: DIAGONAL");
          Console.WriteLine("4: TRIDIAGONAL SUPERIOR");
          Console.WriteLine("5: TRIDIAGONAL INFERIOR");
          Console.WriteLine("6: Sair");

          opcao         = int.Parse(Console.ReadLine());

          switch (opcao) 
          {
            case 1:
                        Console.Clear();
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.WriteLine("-----------------");
						            Console.WriteLine(" ALEATÓRIA PURA");
						            Console.WriteLine("-----------------");
                        
                        /* Mudanca de uma abordagem com parametros para
                         * uma abordagem com polimorfismo.
                         * 
                         * Perceba que a variavel objetoAleatoriaPura é do
                         * tipo da superclasse Matriz, mas o o objeto criado
                         * é do tipo da subclasse MatrizAleatoria
                         * 
                         * O parametro "opcao" e aquele switch la na subclasse nao
                         * sao mais necessários
                         */
						            Matriz objetoAleatoriaPura = new MatrizAleatoria(16);
                        objetoAleatoriaPura.imprimirMatriz();
                        break;

            case 2:
                        Console.Clear();
                        Console.ForegroundColor=ConsoleColor.Blue;
                        Console.WriteLine("-----------------");
                        Console.WriteLine("    TOEPLITZ     ");
                        Console.WriteLine("-----------------");

                        Matriz objetoToeplitz = new MatrizToeplitz(16);
                        objetoToeplitz.imprimirMatriz();             
                        break;            
            
            case 3:
                        Console.Clear();
                        Console.ForegroundColor=ConsoleColor.Yellow;
                        Console.WriteLine("-----------------");
                        Console.WriteLine("    DIAGONAL     ");
                        Console.WriteLine("-----------------");

                        Matriz objetoDiagonal = new MatrizDiagonal(16);
						            objetoDiagonal.imprimirMatriz();             
                        break;

            case 4:
                        Console.Clear();
                        Console.ForegroundColor=ConsoleColor.Cyan;
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("    TRIANGULAR SUPERIOR     ");
                        Console.WriteLine("-----------------------------");

                        Matriz objetoTriangularSuperior = new MatrizTriangularSuperior(16);
						            objetoTriangularSuperior.imprimirMatriz();             
                        break;


            case 5:
                        Console.Clear();
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("    TRIANGULAR INFERIOR     ");
                        Console.WriteLine("-----------------------------");

						            Matriz objetoTriangularInferior = new MatrizTriangularInferior(16);
						            objetoTriangularInferior.imprimirMatriz();             
                        break;                        
                        
            }/*switch*/
                 
       }while(opcao != 6);

   }/*Menu*/

    public static void Main()
    {    
       Menu();
    }

  } /*Principal*/

}/*ProjetoRecipienteDeMatrizes*/
