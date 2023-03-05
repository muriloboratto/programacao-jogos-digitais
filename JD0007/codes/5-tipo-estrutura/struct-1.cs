/****************************************************************************80
*  Code: 
*   struct1.cs
*
*  Purpose:
*   Implements the simple Csharp struct code - example no 1 (Variable).
*
*  Modified:
*   May 08 2022 17:28 
*
*  Author:
*    Murilo Boratto  < muriloboratto 'at' uneb.br >
*
*  HowtoCompile:
*    mcs struct1.cs -o struct1 
*   
*  HowtoExecute:
*    mono struct1  
*
*******************************************************************************/

using System;


struct Pessoa
{ 
  public string   nome;
  public int      telefone;
  public Endereco Salvador;
}

struct Endereco
{ 
 public string  rua;
 public int     numero;
 public string  bairro;
 public string  estado;
 public int     CEP;
}


namespace myApp
{
  class testStructure 
  {
     static void Main() 
     {

      Pessoa FuncionarioUNEB;   
          
      FuncionarioUNEB.nome            = "Marivaldo Silva";
      FuncionarioUNEB.telefone        = 7199173366;
      FuncionarioUNEB.Salvador.rua    = "Rua Rio Trobogi";
      FuncionarioUNEB.Salvador.numero = 588;
      FuncionarioUNEB.Salvador.bairro = "Piata";
      FuncionarioUNEB.Salvador.estado = "Bahia";
      FuncionarioUNEB.Salvador.CEP    =  41650295;

      Console.WriteLine("Nome: "     +FuncionarioUNEB.nome);
      Console.WriteLine("Telefone: " +FuncionarioUNEB.telefone);
      Console.WriteLine("Rua: "      +FuncionarioUNEB.Salvador.rua); 
      Console.WriteLine("Numero: "   +FuncionarioUNEB.Salvador.numero); 
      Console.WriteLine("Bairro: "   +FuncionarioUNEB.Salvador.bairro);
      Console.WriteLine("Estado: "   +FuncionarioUNEB.Salvador.estado);
      Console.WriteLine("CEP: "      +FuncionarioUNEB.Salvador.CEP);
        
     }
  }
}