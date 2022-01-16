/*%****************************************************************************80
%  Code: 
%   PathfindingExampleComplex.cs
%
%  Purpose:
%   A* Search PathFinding Algorithm in C#
%
%  Modified:
%   Jul 25 2021 16:34 
%
%  Author:
%   Murilo Do Carmo Boratto [muriloboratto@uneb.br]  
%   
%  How to Compile:
%   mcs PathfindingExampleComplex.cs -o object 
%   
%  How to Execute:
%   mono object
%
%  Comments:
%   A* Search Pathfinding example from : https://dotnetcoretutorials.com/2020/07/25/a-search-pathfinding-algorithm-in-c/ 
%  
%******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;

namespace PathfindingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
         List<string> map = new List<string>
         {         
         " -------------------------------------------------- ",    
         "| A                                     |         |",    
         "|    .-----------------------------.    |         |",    
         "|    |                             |    |    |    |",    
         "|    |    .-------------------.    |    |    |    |",    
         "|    |    |                   |    |    |    |    |",    
         "|    |     ----      ----     |    |    |    |    |",    
         "|    |                             |    |    |    |",    
         "|    |    .-------------------.    |    .----.    |", 
         "|    |    |                   |    |              |",    
         "|              .---------.    |    .---------.    |",    
         "|              |         |    |              |    |",    
         "|    |    |    |         |    |     ---------.    |",    
         "|    |    |    |    |    |    |                   |",    
         "|----.    |    |    |    |    |    .--------------|",    
         "|         |    |    |    |    |    |              |",    
         "|    |    |    .----.    |    |    |     ----.    |",    
         "|    |                   |    |    |         |    |",    
         "|    .-------------                .---------.    |",    
         "|                                               B |",    
         " -------------------------------------------------'"
         };

            var start = new Tile();
            start.Y = map.FindIndex(x => x.Contains("A"));
            start.X = map[start.Y].IndexOf("A");


            var finish = new Tile();
            finish.Y = map.FindIndex(x => x.Contains("B"));
            finish.X = map[finish.Y].IndexOf("B");

            start.SetDistance(finish.X, finish.Y);

            var activeTiles = new List<Tile>();
            activeTiles.Add(start);
            var visitedTiles = new List<Tile>();

            while(activeTiles.Any())
            {
                var checkTile = activeTiles.OrderBy(x => x.CostDistance).First();

                if(checkTile.X == finish.X && checkTile.Y == finish.Y)
                {
                    //We found the destination and we can be sure (Because the the OrderBy above)
                    //That it's the most low cost option. 
                    var tile = checkTile;
                    Console.WriteLine("Retracing steps backwards...");
                    while(true)
                    {
                        Console.WriteLine($"{tile.X} : {tile.Y}");
                        if(map[tile.Y][tile.X] == ' ')
                        {
                            var newMapRow = map[tile.Y].ToCharArray();
                            newMapRow[tile.X] = '*';
                            map[tile.Y] = new string(newMapRow);
                        }
                        tile = tile.Parent;
                        if(tile == null)
                        {
                            Console.WriteLine("Map looks like :");
                            map.ForEach(x => Console.WriteLine(x));
                            Console.WriteLine("Done!");
                            return;
                        }
                    }
                }

                visitedTiles.Add(checkTile);
                activeTiles.Remove(checkTile);

                var walkableTiles = GetWalkableTiles(map, checkTile, finish);

                foreach(var walkableTile in walkableTiles)
                {
                    //We have already visited this tile so we don't need to do so again!
                    if (visitedTiles.Any(x => x.X == walkableTile.X && x.Y == walkableTile.Y))
                        continue;

                    //It's already in the active list, but that's OK, maybe this new tile has a better value (e.g. We might zigzag earlier but this is now straighter). 
                    if(activeTiles.Any(x => x.X == walkableTile.X && x.Y == walkableTile.Y))
                    {
                        var existingTile = activeTiles.First(x => x.X == walkableTile.X && x.Y == walkableTile.Y);
                        if(existingTile.CostDistance > checkTile.CostDistance)
                        {
                            activeTiles.Remove(existingTile);
                            activeTiles.Add(walkableTile);
                        }
                    }else
                    {
                        //We've never seen this tile before so add it to the list. 
                        activeTiles.Add(walkableTile);
                    }
                }
            }

            Console.WriteLine("No Path Found!");
        }

        private static List<Tile> GetWalkableTiles(List<string> map, Tile currentTile, Tile targetTile)
        {
            var possibleTiles = new List<Tile>()
            {
                new Tile { X = currentTile.X, Y = currentTile.Y - 1, Parent = currentTile, Cost = currentTile.Cost + 1 },
                new Tile { X = currentTile.X, Y = currentTile.Y + 1, Parent = currentTile, Cost = currentTile.Cost + 1},
                new Tile { X = currentTile.X - 1, Y = currentTile.Y, Parent = currentTile, Cost = currentTile.Cost + 1 },
                new Tile { X = currentTile.X + 1, Y = currentTile.Y, Parent = currentTile, Cost = currentTile.Cost + 1 },
            };

            possibleTiles.ForEach(tile => tile.SetDistance(targetTile.X, targetTile.Y));

            var maxX = map.First().Length - 1;
            var maxY = map.Count - 1;

            return possibleTiles
                    .Where(tile => tile.X >= 0 && tile.X <= maxX)
                    .Where(tile => tile.Y >= 0 && tile.Y <= maxY)
                    .Where(tile => map[tile.Y][tile.X] == ' ' || map[tile.Y][tile.X] == 'B')
                    .ToList();
        }
    }

    class Tile
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Cost { get; set; }
        public int Distance { get; set; }
        public int CostDistance => Cost + Distance;
        public Tile Parent { get; set; }

        //The distance is essentially the estimated distance, ignoring walls to our target. 
        //So how many tiles left and right, up and down, ignoring walls, to get there. 
        public void SetDistance(int targetX, int targetY)
        {
            this.Distance = Math.Abs(targetX - X) + Math.Abs(targetY - Y);
        }
    }
}