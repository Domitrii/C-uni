public class Task1 : ITask
{
    public void Execute()
    {
        Console.WriteLine("Завдання 1:");
        int[] numbers = { 7, 11, 9 };
        int groupNumber = 6; 
        int upperLimit = 10 + groupNumber;

        Console.WriteLine($"Інтервал: [1, {upperLimit}]");
        Console.WriteLine("Числа, що належать інтервалу:");

        foreach (var number in numbers)
        {
            if (number >= 1 && number <= upperLimit)
            {
                Console.WriteLine(number);
            }
        }
        Console.WriteLine();
    }
}