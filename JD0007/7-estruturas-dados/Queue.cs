/*%****************************************************************************80
%  Code: 
%   Queue.cs
%
%  Purpose:
%   FILO (First In Last Out) algorithm.
%
%  Modified:
%   Mar 28 2019 10:57 
%
%  Author:
%    Murilo Boratto <muriloboratto 'at' uneb.br>
%    Leandro Correia  <leandro.correia 'at' gmail.com>
%
%  How to Compile:
%   mcs Queue.cs -o object 
%
%  How to Execute: 
%   mono object
%
%  Classes
%
%   public class Node
%   {
%    - public  string data;
%    - public  Node prev;
%    - public  Node next;
%
%    + public Node(string data); 
%    + public string getData(); 
%   }
%
%   public class Queue
%   {
%    - private Node head;
%    - private Node tail;
%    - private int size;
%   
%    + public void Offer(string element);
%    + public Node Poll();
%    + public int Size();
%   }
%
%   public class TestQueue
%   {
%    + public static void print(Queue queue);
%    + public static void Main();
%   }
%
%****************************************************************************80*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharpDatastructuresAlgorithms
{ 

  public class Node
  {
    public  string data;
    public  Node prev;
    public  Node next;

    public Node(string data)
    {
     this.data = data;
    }

   public string getData()
   {
    return(data);     
   }

  }/*class Node*/

/*********************************************************/

   public class Queue
   {
    private Node head;
    private Node tail;
    private int size;
   
    public void Offer(string element)
    {
       if(head == null)
       {   
         head = new Node(element);
         tail = head; 
       }
       else
       {
         Node newNode = new Node(element);
         newNode.next = tail;
         tail.prev = newNode;
         tail = newNode;
       }
       size++;
   
    }/*Offer*/

    public Node Poll()
    {
      Node p = head;

      if(p == null)
       return null;
  
      head = head.prev; 

      p.next = null;
      p.prev = null;

      size--;

      return p;

    }/*Node*/

    public int Size()
    {
      return size;
    } 

   }/*class Queue*/

/*********************************************************/

   public class TestQueue
   {
     
     public static void print(Queue queue)
     {
       Console.Write("Head ");
       Node node = null;

       while((node = queue.Poll()) != null)
          Console.Write(node.getData() + " <-- ");

       Console.Write(" Tail \n");

     }/*print*/

     public static void Main()
     {
       Queue queue = new Queue();

       queue.Offer("A");
       queue.Offer("B");
       queue.Offer("C");
       queue.Offer("D");
       
       print(queue);

     }/*main*/
   }/*class TestQueue*/
}/*namespace*/
