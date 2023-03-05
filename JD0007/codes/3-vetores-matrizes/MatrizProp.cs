/*%****************************************************************************80
%  Code: 
%   MatrizProp.cs
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
  public class TestMatrix
  {  
    static void Main()
    {
      int[,] matrix = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
      int linha, coluna, DIAGPRINC=0, SUB=0, SUPER=0;

      Console.Write("\n"); 

      /* Print matrix */
      for(linha = 0; linha < 4;linha++){
        for(coluna = 0; coluna < 4; coluna++){     
          Console.Write("{0}\t", matrix[linha,coluna]);   
        }
      Console.Write("\n"); 
      }

      /* Calculate add matrix */
      for(linha = 0; linha < 4;linha++){
        for(coluna = 0; coluna < 4; coluna++){ 
          
          if (linha == coluna)
               DIAGPRINC = DIAGPRINC + matrix[linha, coluna];
  
          if (linha == coluna - 1)
              SUB = SUB + matrix[linha, coluna];
  
          if (linha == coluna + 1)
              SUPER = SUPER + matrix[linha, coluna];     
    
        }  
      }    
    
      Console.Write("\n"); 

      /* Print Results */
      Console.WriteLine ("A soma da DIAGONAL PRINCIPAL é {0}", DIAGPRINC);   
      Console.WriteLine ("A soma da SUBDIAGONAL é {0}", SUB);   
      Console.WriteLine ("A soma da SUPERDIAGONAL é {0}", SUPER);   

    }
  }
}
