namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = GetIntList();
            int capacity = int.Parse(Console.ReadLine());
            string[] command = GetStringArray();
            while (command[0]?.ToLower() != "end")
            {
                switch (command[0]?.ToLower())
                {
                    case "add":
                        //int num = int.Parse(command[1]);
                        //train.Add(num);
                        train.Add(int.Parse(command[1]));
                        break;
                    default:
                        AddNumberToList(train, capacity, command[0]);
                        break;
                }
                command = GetStringArray();
            }
            Console.WriteLine(string.Join(" ", train));

        }
        static List<int> GetIntList()
        {
            return Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
        }
        static string[] GetStringArray ()
        {
            return Console.ReadLine()
                .Split(" ")
                .ToArray();
        }
        static List<int> AddNumberToList(List <int> list, int capacity, string num)
        {
            int convertedNumber = int.Parse(num);
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] + convertedNumber <= capacity)
                {
                    list[i] += convertedNumber;
                    break;
                }
            }
            return list;
        }
    }
}