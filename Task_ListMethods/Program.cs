internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = new();
        list.Add(12);
        list.Add(2);
        list.Add(33);
        list.Add(47);
        list.Add(26);
        list.Add(22);

        //Min
        int minimum = list.Min();
        Console.WriteLine(minimum);

        //Max
        int maximum = list.Max();
        Console.WriteLine(maximum);

        //LastIndexOf
        int lastindex = list.LastIndexOf(47);
        Console.WriteLine(lastindex);

        //Contains
        bool isExist = list.Contains(33);
        Console.WriteLine(isExist);

        //Remove Range
        list.RemoveRange(2, 2);

        //CopyTo
        int[] list2 = new int[list.Count];
        list.CopyTo(list2);
        foreach (var mylist2 in list2)
        {
            Console.WriteLine(mylist2);
        }
        Console.WriteLine("************************");

        //Show list
        foreach (var mylist in list)
        {
            Console.WriteLine(mylist);
        }

        Console.ReadLine();
    }
}