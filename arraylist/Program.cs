using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList numbers = new ArrayList();

        for (int i = 1; i <= 10; i++)
        {
            numbers.Add(i);
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
