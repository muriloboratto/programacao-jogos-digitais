/*%****************************************************************************80
%  Code: 
%   Veiculo.cs
%
%  Purpose:
%   Implements sample c# code OO.
%
%  Modified:
%   Mar 28 2019 10:57 
%
%  Author:
%    Murilo Boratto <muriloboratto 'at' uneb.br>
%    Leandro Correia  <leandro.correia 'at' gmail.com>
%
%  How to Compile:
%   mcs code.cs  -o object 
%
%  How to Execute: 
%   mono object
%
%****************************************************************************80*/

using System;

namespace ProjetoDeslocamento
{ 

 public abstract class Veiculo
 {
   public double calculaDistancia(double inicio, double fim)
   {
     return(fim - inicio); 
   }

 }/*Veiculo*/

}/*namespace*/
