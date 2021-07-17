/*%****************************************************************************80
%  Code: 
%   Bicicleta.cs
%
%  Purpose:
%   Implements sample c# code OO with heritage.
%
%  Modified:
%   Mar 28 2019 10:57 
%
%  Author:
%    Murilo Boratto <muriloboratto 'at' uneb.br>
%    Leandro Correia  <leandro.correia 'at' gmail.com>
%
%  How to Compile:
%   mcs Bicicleta.cs Veiculo.cs -o object 
%
%  How to Execute: 
%   mono object
%
%  Classes:
%
%   public class Bicicleta: Veiculo
%   {
%     - private double velocidade;
%     - private int cor;
%
%     + Bicicleta(int cor, double velocidade);
%     + public int getCor();
%     + public double getVelocidade();
%     + public void setCor(int cor);
%     + public void setVelocidade(double velocidade);   
%     + public void acelera();
%     + ~Bicicleta();
%     + public static void Main();
%   }  
% 
%   public abstract class Veiculo{
%   {
%     + public double calculaDistancia(double inicio, double fim);
%   }
%
%****************************************************************************80*/

using System;

namespace ProjetoDeslocamento
{ 

 public class Bicicleta: Veiculo
 {
   private double velocidade;
   private int cor;

   //Construtor
   Bicicleta(int cor, double velocidade)
   {
     this.cor        = cor;
     this.velocidade = velocidade;
   } 

   //Métodos GET
   public int getCor()
   {
      return(cor);     
   }

   public double getVelocidade()
   {
      return(velocidade);     
   }

   //Métodos SET
   public void setCor(int cor)
   {
     this.cor = cor;    
   }

   public void setVelocidade(double velocidade)
   {
     this.velocidade = velocidade;    
   }
     
   //Métodos Geral
   public void acelera()
   {
     velocidade += 10; 
   } 
 
   //Destructor
   ~Bicicleta()
   {
     
   } 

   public static void Main()
   {
      Bicicleta Caloi = new Bicicleta(2, 23);
    
      Console.WriteLine("A 'Velocidade' da Caloi no instante t1 era de {0} km/h ", Caloi.getVelocidade()); 
      Console.WriteLine("A 'Cor' da Caloi é {0}\n", Caloi.getCor()); 

          Console.WriteLine("\t:: Acelerando a Caloi ++++ ::\n");
          Caloi.acelera();

      Console.WriteLine("A 'Velocidade' da Caloi no instante t2 era {0} km/h ", Caloi.getVelocidade()); 
      Console.WriteLine("A 'Distância' percorrida pela Caloi foi de {0} km \n", Caloi.calculaDistancia(2, 10)); 
    
   }/*main*/

 }/*Bicicleta*/

}/*namespace*/
