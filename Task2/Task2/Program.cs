class Program
{
    static void Main()
    {
        //task2
        int size = 30;
        int[] array = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(-20, 21);
        }

        Console.WriteLine("Початковий масив:");
        PrintArray(array);
        int[] rearrangedArray = RearrangeArray(array);
        Console.WriteLine("\nПеретворений масив:");
        PrintArray(rearrangedArray);
    }
    static int[] RearrangeArray(int[] array)
    {
        var positive = array.Where(x => x > 0).OrderBy(x => x).ToArray();
        var zeros = array.Where(x => x == 0).ToArray();
        var negative = array.Where(x => x < 0).OrderBy(x => x).ToArray();
        return positive.Concat(zeros).Concat(negative).ToArray();
    }
    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}