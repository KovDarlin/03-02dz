using System;

public interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}

public class Array : IOutput2
{
    private int[] numbers;
    public Array(int[] numbers)
    {
        this.numbers = numbers;
    }


    public void ShowEven()
    {
        Console.WriteLine("Even: ");
        foreach (int i in numbers)
        {
            if (i %2 ==0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        Console.WriteLine("Odd: ");
        foreach (int i in numbers)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine();
    }

}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Array array = new Array(numbers);

        array.ShowEven();
        array.ShowOdd();
        
    }
}