/*%****************************************************************************80
%  Code: 
%   TipoEstrutura.cs
%
%  Purpose:
%   Implements sample struct c# code  
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

struct Endereco
{ 
 public string rua;
 public int numero;
 public string bairro;
 public string cidade;
 public string estado;
 public int CEP;
};

struct Pessoa
{ 
  string nome;
  int telefone;
  struct Endereco end;
};

namespace myApp
{
  class testStructure 
  {
     static void Main() 
     {

      Pessoa FuncionarioUNEB;   
         
      FuncionarioUNEB.nome       = "Murilo Boratto";
      FuncionarioUNEB.telefone   = 99173360;
      FuncionarioUNEB.end.rua    = "Rua Rio Trobogi";
      FuncionarioUNEB.end.numero = 10;
      FuncionarioUNEB.end.bairro = "Piatan";
      FuncionarioUNEB.end.cidade = "Salvador";
      FuncionarioUNEB.end.estado = "Bahia";
      FuncionarioUNEB.end.CEP    =  41650295;

     }
  }
}