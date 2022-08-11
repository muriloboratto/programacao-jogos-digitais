/*%****************************************************************************80
%  Code: 
%   PathfindingExampleSimplex.cs
%
%  Purpose:
%   Search PathFinding Algorithm in C# with Wavypoints
%
%  Modified:
%   Jul 25 2021 16:34 
%
%  Author:
%   Murilo Do Carmo Boratto [muriloboratto@uneb.br] 
%   Vinicius Santos  
%   
%  How to Compile:
%   mcs PathfindingExampleSimplex.cs -o object 
%   
%  How to Execute:
%   mono object
%
%  Comments:
%        - The map variable defines the locations that exist and which locations they are connected to using
%        the dictionary data structure;
%        - The final result is a string representing the path taken to go from start to end;
%  
%******************************************************************************80*/

using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
        var map = new Dictionary<string, HashSet<string>>
        {
            { "Madrid",        new HashSet<string> { "Zaragoza", "Bilbao", "Valladolid", "Jaen", "Murcia", "Zaragoza"}},
            { "Valladolid",    new HashSet<string> { "Madrid", "Bilbao" }},
            { "Bilbao",        new HashSet<string> { "Zaragoza", "Madrid", "Valladolid" }},
            { "Zaragoza",      new HashSet<string> { "Madrid", "Bilbao" }},
            { "Jaen",          new HashSet<string> { "Madrid", "Murcia" }},
            { "Murcia",        new HashSet<string> { "Jaen", "Valencia" }},
            { "Valencia",      new HashSet<string> { "Murcia", "Barcelona" }},
            { "Barcelona",     new HashSet<string> { "Valencia", "Zaragoza" }}
        };

        Pathfinder finder = new Pathfinder(map);

        var entryToExit = finder.PathAsString("Barcelona", "Valladolid");
        Console.WriteLine($"from Barcelona to Valladolid:\n{entryToExit}");

    }
}

public class Pathfinder
{
    readonly Dictionary<string, HashSet<string>> map;

    public Pathfinder(Dictionary<string, HashSet<string>> map)
    {
        this.map = map;
    }

    public string PathAsString(string entrypoint, string exit)
    {
        var pathAsString = string.Empty;
        var path = FindPath(entrypoint, exit);

        if (path != null)
        {
            path.ForEach(t => pathAsString += $"{t} ");
            return pathAsString;
        }
        else
        {
            return "path not possible";
        }
    }

    public List<string> FindPath(string entrypoint, string exit)
    {
        if (!map.ContainsKey(entrypoint) || !map.ContainsKey(exit))
        {
            return null;
        }

        var visited = new HashSet<string>();
        var parents = new Dictionary<string, string>();
        var toVisit = new Queue<string>();

        toVisit.Enqueue(entrypoint);

        while (toVisit.Count > 0)
        {
            var current = toVisit.Dequeue();
            visited.Add(current);

            if (current.Equals(exit))
            {
                break;
            }

            foreach (var neighbor in map[current])
            {
                if (!visited.Contains(neighbor))
                {
                    toVisit.Enqueue(neighbor);
                    parents[neighbor] = current;
                }
            }
        }

        if (!visited.Contains(exit))
        {
            return null;
        }

        var node = exit;
        var path = new List<string>();

        while (!node.Equals(entrypoint))
        {
            path.Add(node);

            node = parents[node];
        }

        path.Add(entrypoint);
        path.Reverse();

        return path;
    }
}