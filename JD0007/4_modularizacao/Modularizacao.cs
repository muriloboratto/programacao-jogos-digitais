/*%****************************************************************************80
%  Code: 
%   Modularizacao.cs
%
%  Purpose:
%   Implements sample vector c# code  
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

namespace CSharpDatastructuresAlgorithms
{ 
  public class RepositorioMatrizes
  {  

    static void MatrizAleatoria(int[,] matriz, int n)
    {
      for(int linha = 0; linha < n; linha++)
        for(int coluna = 0; coluna < n; coluna++)    
           matriz[linha,coluna] =  linha + coluna;   
    
    }

    static void ImprimirMatriz(int[,] matriz, int n)
    {
       for(int linha = 0; linha < n; linha++){
          for(int coluna = 0; coluna < n; coluna++){    
            Console.Write("{0}\t", matriz[linha,coluna]);   
          }
          Console.Write("\n");   
        }
  
       Console.Write("\n"); 

    }

    static void Main()
    {
      int[,] matriz = new int[4, 4];
      int n = 4;

      Console.WriteLine ("Matriz Aleatória");  
      MatrizAleatoria(matriz, n);
      ImprimirMatriz(matriz, n);

    }
  }
}

