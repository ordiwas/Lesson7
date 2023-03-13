namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> score = new List<int> { 50, 54, 68, 55 };
            int[] scoreArr = new int[] { 60, 56, 86 };
            score.AddRange(scoreArr);
            score.Sort();
            Console.WriteLine("-------Ascending--------");
            foreach (int m in score)
                Console.WriteLine(m);
            score.Remove(score[0]);

            score.Reverse();
            Console.WriteLine("-------Descending--------");
            foreach (int m in score)
                Console.WriteLine(m);

            Console.Read();
            
        }
    }
}