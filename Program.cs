using System;

public interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

public class Array : ICalc
{
    private int[] numbers;
    public Array(int[] numbers)
    {
        this.numbers = numbers;
    }


    public int Less(int valueToCompare)
    {
        int count = 0;
        foreach(int i in numbers)
        {
            if (i< valueToCompare)
            {
                count++;
            }
        }
        return count;
    }

    public int Greater(int valueToCompare)
    {
        int count = 0;
        foreach (int i in numbers)
        {
            if (i > valueToCompare)
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
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Array array = new Array(numbers);
 
        Console.WriteLine($"Less 6: {array.Less(6)}");
        Console.WriteLine($"Greater 8: {array.Greater(8)}");
    }
}