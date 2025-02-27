using System;

public interface ICalc2
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

public class Array : ICalc2
{
    private int[] numbers;
    public Array(int[] numbers)
    {
        this.numbers = numbers;
    }


    public int CountDistinct()
    {
        return new HashSet<int>(numbers).Count;
    }

    public int EqualToValue(int valueToCompare)
    {
        int count = 0;
        foreach (int num in numbers)
        {
            if (num == valueToCompare)
            {
                count++;
            }
        }
        return count;
    }

}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2,2,2,2, 3, 4, 5, 6, 7, 8, 9,9,9, 10 };
        Array array = new Array(numbers);

        Console.WriteLine(array.CountDistinct());
        Console.WriteLine(array.EqualToValue(3));
    }
}