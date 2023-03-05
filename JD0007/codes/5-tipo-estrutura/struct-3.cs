/****************************************************************************80
*  Code: 
*   struct3.cs
*
*  Purpose:
*   Implements the simple Csharp struct code - example no 3 (List).
*
*  Modified:
*   May 08 2022 17:28 
*
*  Author:
*    Murilo Boratto  < muriloboratto 'at' uneb.br >
*
*  HowtoCompile:
*    mcs struct3.cs -o struct3 
*   
*  HowtoExecute:
*    mono struct3  
*
*******************************************************************************/

using System;
using System.Collections.Generic;

struct Pessoa
{ 
  public string nome;
  public int telefone;
  public Endereco Salvador;
}


struct Endereco
{ 
 public string rua;
 public int numero;
 public string bairro;
 public string estado;
 public int CEP;
}


namespace myApp
{
  class testStructure 
  {
     static void Main() 
     {
        List<Pessoa> listaFuncionarios = new List<Pessoa>();
        
        /*0*/
        listaFuncionarios.Add(new Pessoa()
        {
         nome     = "Marivaldo Silva",
         telefone = 7199173366,
         Salvador = 
         {
          rua    = "Rua Rio Trobogi",
          numero = 588,
          bairro = "Piata",
          estado = "Bahia",
          CEP    = 41650295
         }
        });

        /*1*/
        listaFuncionarios.Add(new Pessoa()
        {
         nome     = "Charleni Santos",
         telefone = 7188179955,
         Salvador = 
         {
          rua    = "Rua das Margaridas",
          numero = 90,
          bairro = "Pituba",
          estado = "Bahia",
          CEP    = 40889977
         }
        });

        foreach(Pessoa p in listaFuncionarios)
          Console.WriteLine(p.nome + "," + p.telefone + "," + p.Salvador.rua + 
                                                        "," + p.Salvador.numero +
                                                        "," + p.Salvador.bairro +
                                                        "," + p.Salvador.estado +
                                                        "," + p.Salvador.CEP + "\n");  
    }  
  }
}
