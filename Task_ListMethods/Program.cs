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
        Console.WriteLine($"Minimum element of list: {minimum}");

        //Max
        int maximum = list.Max();
        Console.WriteLine($"Maximum element of list: {maximum}");

        //LastIndexOf
        int lastindex = list.LastIndexOf(47);
        Console.WriteLine($"LastIndexOf element: {lastindex}");

        //Contains
        bool isExist = list.Contains(33);
        Console.WriteLine($"Is Exist element: {isExist}");

        //Remove Range
        list.RemoveRange(2, 2);

        //CopyTo
        int[] list2 = new int[list.Count];
        list.CopyTo(list2);

        //New List
        Console.WriteLine();
        Console.WriteLine("My new list");
        foreach (var mylist2 in list2)
        {
            Console.WriteLine(mylist2);
        }
        Console.WriteLine("************************");

        //Show list
        Console.WriteLine("My list");
        foreach (var mylist in list)
        {
            Console.WriteLine(mylist);
        }

        Console.ReadLine();
    }
}