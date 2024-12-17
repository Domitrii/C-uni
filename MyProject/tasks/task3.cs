public class Task3 : ITask
{
    public void Execute()
    {
        Console.WriteLine("Завдання 3:");
        int[] array = { 20, -4, 13, 25, -8, 7, -15, 10, 30, -3, 12, -6, 18 };
        int groupNumber = 6;
        int arrayLength = 10 + groupNumber;

        if (array.Length != arrayLength)
        {
            Console.WriteLine($"Довжина масиву має бути {arrayLength}, але отримано {array.Length}.");
            return;
        }

        int min = array[0];
        int max = array[0];

        foreach (int number in array)
        {
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine("Масив: " + string.Join(", ", array));
        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");
        Console.WriteLine();
    }
}