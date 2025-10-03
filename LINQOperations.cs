using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class LINQOperations
    {
        public static void LINQExamples()
        {
            // This is data source
            int[] scores = [97, 92, 81, 60];

            // Defining the query expression below
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query
            foreach (int item in scoreQuery)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine(scoreQuery);
        }

        public static List<int> GetScoresGreaterThan50(int[] scoresArray)
        {
            List<int> result = new List<int>();
            // query expression / query syntax
            IEnumerable<int> scoreQuery =
                from score in scoresArray
                where score > 50
                select score;

            // query method syntax of LINQ
            //var scoreQuery2 = scoresArray.Where(score => score > 50).OrderByDescending(score => score);
            //result = scoreQuery2.ToList();

            // query execution
            foreach (int item in scoreQuery)
            {
                result.Add(item);
            }
            return result;
        }

    }
}
