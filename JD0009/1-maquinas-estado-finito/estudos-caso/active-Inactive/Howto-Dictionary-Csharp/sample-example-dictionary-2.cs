/*%****************************************************************************80
!  Code: 
!   sample-example-dictionary-2.cs
!
!  Purpose:
!   Sample example with Struct 'dictionary' in C#
!
!  Modified:
!   Mar 14 2021 10:57 
!
!  Author:
!   Murilo Boratto <muriloboratto 'at' uneb.br>
!
!  How to Compile:
!   mcs sample-example-dictionary-1.cs -o object
!
!  How to Execute: 
!   mono object
!
!  Comments: 
!                        
!****************************************************************************80*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CShp_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> caixaFrutas = new Dictionary<int, string>()
            {
                                                {1,"Banana"},
                                                {2, "Laranja"},
                                                {3, "Manga"},
                                                {4, "Abacate"},
                                                {5,"Maça"}
            };
            
            Console.WriteLine(caixaFrutas.ContainsKey(1)); // retorna true
            Console.WriteLine(caixaFrutas.ContainsKey(6)); // retorna false
            Console.WriteLine(caixaFrutas.Contains(new KeyValuePair<int, string>(3, "Manga"))); // retorna true    
        }
    }
}
