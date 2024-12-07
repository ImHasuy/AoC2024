using System.Security.Cryptography.X509Certificates;

namespace AdventOfCode1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DataObj> list = new List<DataObj>();
            string[] lista1 = File.ReadAllLines("input.txt");

            string[] LeftSide = lista1.Select(x => x.Split("   ")[0]).Order().ToArray();
            string[] RightSide = lista1.Select(x => x.Split("   ")[1]).Order().ToArray();

            for (int i = 0; i < lista1.Length; i++)
            {
                list.Add(new DataObj(int.Parse(LeftSide[i]), int.Parse(RightSide[i])));
            }
                

            Console.WriteLine(list.Sum(x=>x.DiffBetTwo));

            Console.WriteLine("Masodik feladat");

            int temp_counter =0;

            for (int i = 0; i < LeftSide.Length; i++)
            {
                temp_counter += int.Parse(LeftSide[i]) * RightSide.Count(m => m == LeftSide[i]);
            }

            Console.WriteLine(temp_counter);
        }
    }
}
