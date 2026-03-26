using System;

class MyArray
{
    private int[] arr;
    public int Length;

    public MyArray(int size)
    {
        arr = new int[size];
        Length = size;
    }

    public int this[int index]
    {
        get
        {
            return arr[index];
        }
        set
        {
            arr[index] = value;
        }
    }

    public int this[double index]
    {
        get
        {
            return arr[(int)Math.Round(index)];
        }
        set
        {
            arr[(int)Math.Round(index)] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        MyArray arr = new MyArray(101);

        arr[4.51] = 10;
        arr[9.49] = 20;
        arr[99.9] = 30;

        Console.WriteLine("Значения после округления индексов:");
        Console.WriteLine("arr[5] = " + arr[5]);
        Console.WriteLine("arr[9] = " + arr[9]);
        Console.WriteLine("arr[100] = " + arr[100]);

        Console.WriteLine();
        Console.WriteLine("Проверка через дробные индексы:");
        Console.WriteLine("arr[4.51] = " + arr[4.51]);
        Console.WriteLine("arr[9.49] = " + arr[9.49]);
        Console.WriteLine("arr[99.9] = " + arr[99.9]);
    }
}