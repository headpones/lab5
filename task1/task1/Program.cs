class Program
{
    static void Main()
    {
        // Розмірність матриці згідно з варіантом
        int size = 7; // 7x7

        // 1. Генерація матриці з випадковими елементами
        int[,] matrix = new int[size, size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = random.Next(0, 101); // Елементи у діапазоні 0...100
            }
        }

        // 2. Виведення початкової матриці
        Console.WriteLine("Початкова матриця:");
        PrintMatrix(matrix);

        // 3. Відображення матриці симетрично відносно горизонтальної осі
        SymmetrizeMatrixHorizontally(matrix);

        // 4. Виведення перетвореної матриці
        Console.WriteLine("\nПеретворена матриця:");
        PrintMatrix(matrix);
    }

    // Метод для симетричного відображення матриці відносно горизонтальної осі
    static void SymmetrizeMatrixHorizontally(int[,] matrix)
    {
        int size = matrix.GetLength(0);

        for (int i = 0; i < size / 2; i++)
        {
            for (int j = 0; j < size; j++)
            {
                // Міняємо місцями елементи з верхнього та нижнього секторів
                int temp = matrix[i, j];
                matrix[i, j] = matrix[size - i - 1, j];
                matrix[size - i - 1, j] = temp;
            }
        }
    }

    // Метод для виведення матриці у консоль
    static void PrintMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}