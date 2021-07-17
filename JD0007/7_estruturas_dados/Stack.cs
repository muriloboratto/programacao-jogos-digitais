/*%****************************************************************************80
%  Code: 
%   Stack.cs
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
%   mcs Stack.cs -o object 
%
%  How to Execute: 
%   mono object
%
%  Classes
%
%  public class Node
%  {
%    - public  string data;
%    - public  Node next;
%
%    + public Node(string data);
%  }
%
%  public class Stack
%  {
%    - private Node top;
%    - private int size;
%   
%    + public void Push(string element);
%    + public Node Pop();
%    + public int Size(); 
%   }
%
%   public class TestStack
%   {
%    + public static void print(Stack stack);
%    + public static void Main();
%   } 
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
    public  Node next;

    public Node(string data)
    {
     this.data = data;
    }

  }/*class Node*/

/*********************************************************/

   public class Stack
   {
    private Node top;
    private int size;
   
    public void Push(string element)
    {
       if(top == null)
        top = new Node(element);
          else
          {
           Node newNode = new Node(element);
           newNode.next = top;
           top = newNode;
          }
          size++;
    }/*Push*/

    public Node Pop()
    {
      if(top == null)
       return null;
  
      Node p = top;
      top = top.next;

      p.next = null;
      size--;

      return p;

    }/*Pop*/

    public int Size()
    {
      return size;
    } 

   }/*class Stack*/

/*********************************************************/

   public class TestStack
   {
     
     public static void print(Stack stack)
     {
       Console.Write("Top ");
       Node node = null;

       while((node = stack.Pop()) != null)
          Console.Write(node.data + " --> ");

       Console.Write(" End\n");

     }/*print*/

     public static void Main()
     {
       Stack stack = new Stack();

       stack.Push("A");
       stack.Push("B");
       stack.Push("C");
       stack.Push("D");
       
       print(stack);

     }/*main*/
   }/*class TestQueue*/
}/*namespace*/
