/*%****************************************************************************80
!  Code: 
!   sample-example-dictionary-3.cs
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

namespace CShp_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando um dicionario ordenado
            SortedDictionary<string, int> dic2 = new SortedDictionary<string, int>();

            // Adicionando strings e chaves do tipo int
            dic2.Add("zebra", 5);
            dic2.Add("cachorro", 2);
            dic2.Add("gato", 9);
            dic2.Add("pardal", 4);
            dic2.Add("C#", 100);

            // Verifica se gato existe no dicionario
            if (dic2.ContainsKey("gato"))
                Console.WriteLine("tem um gato ai...");

            // Verifica se tem zebra 
            if (dic2.ContainsKey("zebra"))
                Console.WriteLine("Deu zebra pois não tem zebra ai...");

            // Verifica se contém C#
            // e se tiver pega o valor
            int v;
            if (dic2.TryGetValue("C#", out v))
                Console.WriteLine(v);

            // Imprime o SortedDictionary em ordem alfabética
            foreach (KeyValuePair<string, int> p in dic2)
                Console.WriteLine("{0} = {1}", p.Key, p.Value);
           
        }
    }
}
