using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int N = 30;
        int[] nums = new int[N];

        // 1. Генерація та виведення початкового масиву
        Console.WriteLine("Початковий масив:");
        for (int i = 0; i < N; i++)
        {
            nums[i] = rand.Next(-20, 21); // Випадкові числа від -20 до 20
            Console.Write(nums[i] + " ");
        }

        // 2. Перетворення масиву
        BubbleSortTransform(nums);

        // 3. Виведення перетвореного масиву
        Console.WriteLine("\nПеретворений масив:");
        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
    }

    // Метод для перетворення масиву з використанням бульбашкового сортування
    static void BubbleSortTransform(int[] nums)
    {
        int n = nums.Length;

        // Спочатку сортуємо масив так, щоб додатні й нульові були попереду
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                // Переміщення від'ємних чисел праворуч
                if (nums[j] < 0 && nums[j + 1] >= 0)
                {
                    Swap(ref nums[j], ref nums[j + 1]);
                }
            }
        }

        // Тепер сортуємо від'ємні числа за зростанням методом бульбашки
        int negStart = 0;

        // Знайдемо початковий індекс першого від'ємного елемента
        for (int i = 0; i < n; i++)
        {
            if (nums[i] < 0)
            {
                negStart = i;
                break;
            }
        }

        // Бульбашкове сортування від'ємних чисел
        for (int i = negStart; i < n - 1; i++)
        {
            for (int j = negStart; j < n - i + negStart - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    Swap(ref nums[j], ref nums[j + 1]);
                }
            }
        }
    }

    // Метод для обміну значень двох елементів
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
