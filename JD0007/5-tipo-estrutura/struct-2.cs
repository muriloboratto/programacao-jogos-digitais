/****************************************************************************80
*  Code: 
*   struct2.cs
*
*  Purpose:
*   Implements the simple Csharp struct code - example no 2 (Vector).
*
*  Modified:
*   May 08 2022 17:28 
*
*  Author:
*    Murilo Boratto  < muriloboratto 'at' uneb.br >
*
*  HowtoCompile:
*    mcs struct2.cs -o struct2 
*   
*  HowtoExecute:
*    mono struct2  
*
*******************************************************************************/

using System;


struct Endereco
{ 
 public string rua;
 public int numero;
 public string bairro;
 public string estado;
 public int CEP;
}

struct Pessoa
{ 
  public string nome;
  public int telefone;
  public Endereco Salvador;
}


namespace myApp
{
  class testStructure 
  {
     static void Main() 
     {

      Pessoa[] FuncionarioUNEB = new Pessoa[4];

      /*0*/           
      FuncionarioUNEB[0].nome            = "Marivaldo Silva";
      FuncionarioUNEB[0].telefone        = 7199173366;
      FuncionarioUNEB[0].Salvador.rua    = "Rua Rio Trobogi";
      FuncionarioUNEB[0].Salvador.numero = 588;
      FuncionarioUNEB[0].Salvador.bairro = "Piata";
      FuncionarioUNEB[0].Salvador.estado = "Bahia";
      FuncionarioUNEB[0].Salvador.CEP    = 41650295;

      Console.WriteLine("\nNome: "     +FuncionarioUNEB[0].nome);
      Console.WriteLine("Telefone: "   +FuncionarioUNEB[0].telefone);
      Console.WriteLine("Rua: "        +FuncionarioUNEB[0].Salvador.rua); 
      Console.WriteLine("Numero: "     +FuncionarioUNEB[0].Salvador.numero); 
      Console.WriteLine("Bairro: "     +FuncionarioUNEB[0].Salvador.bairro);
      Console.WriteLine("Estado: "     +FuncionarioUNEB[0].Salvador.estado);
      Console.WriteLine("CEP:"         +FuncionarioUNEB[0].Salvador.CEP);


      /*1*/
      FuncionarioUNEB[1].nome            = "Charleny Santos";
      FuncionarioUNEB[1].telefone        = 718881799;
      FuncionarioUNEB[1].Salvador.rua    = "Rua das Margaridas";
      FuncionarioUNEB[1].Salvador.numero = 90;
      FuncionarioUNEB[1].Salvador.bairro = "Pituba";
      FuncionarioUNEB[1].Salvador.estado = "Bahia";
      FuncionarioUNEB[1].Salvador.CEP    =  40989077;

      Console.WriteLine("\nNome: "     +FuncionarioUNEB[1].nome);
      Console.WriteLine("Telefone: "   +FuncionarioUNEB[1].telefone);
      Console.WriteLine("Rua: "        +FuncionarioUNEB[1].Salvador.rua); 
      Console.WriteLine("Numero: "     +FuncionarioUNEB[1].Salvador.numero); 
      Console.WriteLine("Bairro: "     +FuncionarioUNEB[1].Salvador.bairro);
      Console.WriteLine("Estado: "     +FuncionarioUNEB[1].Salvador.estado);
      Console.WriteLine("CEP: "        +FuncionarioUNEB[1].Salvador.CEP);

     
     }
  }
}