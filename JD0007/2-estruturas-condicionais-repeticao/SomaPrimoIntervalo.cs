/*%****************************************************************************80
%  Code: 
%   SomaPrimoIntervalo.cs
%
%  Purpose:
%   Implements sample loop  c# code  
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

namespace questao1
{ 

  public class SomaPrimosIntervalo
  {  


    static bool ehPrimo(int candidado)
    {
       bool statusPrimo = true; 

       for (int j = 2; j < candidado; j++)
       {
         int resto = candidado % j;
                    
         if (resto == 0)
            statusPrimo = false;
       }
  
       return statusPrimo;
    } 


    static void Main()
    {
        // Declaração de Variáveis
        int i, numero1, numero2, somaPrimo = 0;

        // Leitura de Dados
        Console.Write("Digite o primeiro número: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        numero2 = int.Parse(Console.ReadLine());

        // Testa se o número é primo
        for (i = numero1; i <= numero2; i++)
        {
           if(ehPrimo(i))
              somaPrimo += i;
        } 
        
        //Saída de Dados
        Console.WriteLine("A soma dos números primos entre ({0},{1}) é: {2} ", numero1, numero2, somaPrimo);

    }/*main*/
  
  }/*class SomaPrimosIntervalo*/

}/*namespace*/
