/*%****************************************************************************80
%  Code: 
%   list.cs
%
%  Purpose:
%   Example of Date Structure - List<T>
%
%  Modified:
%   Nov 06 2019 10:57 
%
%  Author:
%    Murilo Boratto   <muriloboratto 'at' uneb.br>
%    Leandro Correia  <leandro.correia 'at' gmail.com>
%
%  How to Compile:
%    mcs list.cs -o object
%
%  How to Execute: 
%    mono object
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/

using System;
using System.Collections.Generic;

namespace myApp
{ 
     public class Pessoa
     {  
        
        public string Nome { get; set; } 
        public int Idade { get; set; }

        public Pessoa(int idade, string nome)
        {
            this.Idade = idade;
            this.Nome = nome;
        }
      }/*Pessoa*/


     public class Principal
     {  

       static void Main()
       {
    
            List<Pessoa>  pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa(50, "Macoratti"));
            pessoas.Add(new Pessoa(25, "Jefferson"));
            pessoas.Add(new Pessoa(45, "Miriam"));
            
            foreach (Pessoa p in pessoas)
                Console.WriteLine(p.Nome + " " + p.Idade);
               
       }/*main*/
     }/*Principal*/
}/*Namespace*/