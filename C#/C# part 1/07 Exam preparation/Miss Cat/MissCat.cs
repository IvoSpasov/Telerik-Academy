using System;

class MissCat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] cats = new int[11];

        for (int i = 0; i < n; i++)
        {
            int vote = int.Parse(Console.ReadLine());
            cats[vote]++;
        }

        int winnerCat = 0;
        int biggestVote = 0;

        for (int i = 1; i < cats.Length; i++)
        {
            if (cats[i] > biggestVote)
            {
                winnerCat = i;
                biggestVote = cats[i];
            }
        }
        Console.WriteLine(winnerCat);
    }
}
// Score 100/100
