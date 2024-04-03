using System;

class Program
{
    static int[] EnteringBox1(string[] input1)
    {
        int[] box1 = new int[3];

        for (int i = 0; i < 3; i++)
        {
            box1[i] = int.Parse(input1[i]);
        }
        return box1;
    }
    static int[] EnteringBox2(string[] input2)
    {
        int[] box2 = new int[3];

        for (int i = 0; i < 3; i++)
        {
            box2[i] = int.Parse(input2[i]);
        }
        return box2;
    }
    static void Main()
    {
        string[] input1 = Console.ReadLine().Split();
        int[] box1 = new int[3];
        box1 = EnteringBox1(input1);

        string[] input2 = Console.ReadLine().Split();
        int[] box2 = new int[3];
        box2 = EnteringBox2(input2);

        ManualSort(box1);
        ManualSort(box2);
        Solution(box1, box2);  
        
    }
    static void Solution(int[] box1, int[] box2)
    {
        if (box1[0] == box2[0] && box1[1] == box2[1] && box1[2] == box2[2])
        {
            Console.WriteLine("жодна з коробок не помiщається в iншу");
        }
        else if (box1[0] >= box2[0] && box1[1] >= box2[1] && box1[2] >= box2[2])
        {
            Console.WriteLine("друга коробка помiщається у першу");
        }
        else if (box2[0] >= box1[0] && box2[1] >= box1[1] && box2[2] >= box1[2])
        {
            Console.WriteLine("перша коробка помiщається у другу");
        }
        else
        {
            Console.WriteLine("жодна з коробок не помiщається в iншу");
        }

    }

        static void ManualSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                   
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}