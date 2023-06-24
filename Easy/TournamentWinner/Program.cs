using System;
using System.Collections.Generic;
using System.Linq;

namespace TournamentWinner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> competitions = new List<List<string>>
            {   new List<string>{"HTML","C#" },
                new List<string>{"C#","Python" },
                new List<string>{"Python","HTML" }}; //[homeTeam, awayTeam]

            List<int> results = new List<int> { 0, 0, 1 }; // 0 => awayTeam won, 1=> homeTeam won 

            Console.WriteLine($"the winner is : {TournamentWinner(competitions, results)}");
        }

        public static string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            Dictionary<string, int> resultsDic = new Dictionary<string, int>();
            for (int i = 0; i < competitions.Count; i++)
            {
                var match = competitions[i];
                var result = results[i];
                string winner = (result == 0) ? match[1] : match[0];
                if (!resultsDic.ContainsKey(winner))
                {
                    resultsDic.Add(winner, 0);
                }
                resultsDic[winner] += 3;
            }
            return resultsDic.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        }
    }
}
