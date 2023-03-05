/*%****************************************************************************80
%  Code: 
%   Graph.cs
%
%  Purpose:
%   Direction graph.
%
%  Modified:
%   Mar 28 2019 10:57 
%
%  Author:
%    Murilo Boratto <muriloboratto 'at' uneb.br>
%    Leandro Correia  <leandro.correia 'at' gmail.com>
%
%  How to Compile:
%   mcs Graph.cs -o object 
%
%  How to Execute: 
%   mono object
%
%  Classes:
%
%  public class Graph
%  {
%    - private int maxVertexSize;
%    - private int size;
%    - private Vertex[] vertexs;
%    - private int[,] adjacencyMatrix;
%    - private Stack <Int32> stack;
%
%    + public Graph(int maxVertexSize);
%    + public void AddVertex(string data);
%    + public void addEdge(int from, int to);
%    + public void DepthFirstSearch();
%    + public int FindAdjacencyUnVisitedVertex(int row);
%    + public void Clear();
%    + public int[,] GetAdjacencyMatrix();
%    + public Vertex[] GetVertexs()
%    
%  } 
%
%  public class Vertex
%  {  
%    - public string data;
%    - public bool visited; 
%
%    + public Vertex(string data, bool visited);  
%  }
%
%  public class TestGraph
%  {
%    + public static void PrintGraph(Graph graph);
%    + public static void Main();
%  }
%
%****************************************************************************80*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharpDatastructuresAlgorithms
{ 

  public class Graph
  {
    private int maxVertexSize;
    private int size;
    private Vertex[] vertexs;
    private int[,] adjacencyMatrix;

    private Stack <Int32> stack;

    public Graph(int maxVertexSize)
    {
     this.maxVertexSize = maxVertexSize;
     vertexs = new Vertex[maxVertexSize];

     adjacencyMatrix = new int[maxVertexSize,maxVertexSize];

     stack = new Stack<Int32>(); 
    
    }

    public void AddVertex(string data)
    {
     Vertex vertex = new Vertex(data, false);
     vertexs[size] = vertex;
     size++;
    } 

    public void addEdge(int from, int to)
    {
      adjacencyMatrix[from,to] = 1;
    }

    public void DepthFirstSearch()
    {
      Vertex firstVertex = vertexs[0];
      firstVertex.visited = true;
      Console.Write(firstVertex.data); 
      stack.Push(0);

      while(stack.Count > 0)
      {
        int row = stack.Peek();
        int col = FindAdjacencyUnVisitedVertex(row);

        if(col == -1)
          stack.Pop();
            else
            {
              vertexs[col].visited = true;
              Console.Write(" -> " + vertexs[col].data); 
              stack.Push(col);
            }
      
      }/*while*/

      Console.Write("\n\n"); 

      Clear();

    }/*DepthFirstSearch*/

    public int FindAdjacencyUnVisitedVertex(int row)
    {
      for(int col = 0; col < size; col++)
      {
       if(adjacencyMatrix[row, col] == 1 && !vertexs[col].visited)
         return col;

      }/*for*/

      return -1;

    }/*FindAdjacencyUnVisitedVertex*/

    public void Clear()
    {
     for(int i = 0; i < size; i++)
       vertexs[i].visited = false;
    }

    public int[,] GetAdjacencyMatrix()
    {
     return adjacencyMatrix;
    } 

    public Vertex[] GetVertexs()
    {
     return vertexs;
    }

  }/*class Graph*/ 


  public class Vertex
  {  
    public string data;
    public bool visited; 

    public Vertex(string data, bool visited)
    {
     this.data = data;
     this.visited = visited;
    }

  }/*class Vertex*/


/*********************************************************/

   public class TestGraph
   {

     public static void PrintGraph(Graph graph)
     {
      
       Console.Write("\n");

       for(int i = 0; i < graph.GetVertexs().Length;i++)
       {
        if(i == 0)
         Console.Write("  " + graph.GetVertexs()[i].data + " ");
          else
             Console.Write(graph.GetVertexs()[i].data + " ");
       }

       Console.Write("\n");

       for(int i = 0; i < graph.GetAdjacencyMatrix().GetLength(0); i++){
         Console.Write(graph.GetVertexs()[i].data + " ");
            for(int j = 0; j < graph.GetAdjacencyMatrix().GetLength(0);j++){
               Console.Write(graph.GetAdjacencyMatrix()[i,j] + " ");
             }
         Console.Write("\n");    
       }/*for*/

     }/*PrintGraph*/


     public static void Main()
     {
       Graph graph = new Graph(5);

       graph.AddVertex("A");
       graph.AddVertex("B");
       graph.AddVertex("C");
       graph.AddVertex("D");
       graph.AddVertex("E");
       
       graph.addEdge(0,1);
       graph.addEdge(0,2);
       graph.addEdge(0,3);
       graph.addEdge(1,2);
       graph.addEdge(1,3);
       graph.addEdge(2,3);
       graph.addEdge(3,4);

       PrintGraph(graph);

       Console.Write("\n"); 

       graph.DepthFirstSearch();

     }/*main*/


   }/*class TestGraph*/

/*********************************************************/


}/*namespace*/
