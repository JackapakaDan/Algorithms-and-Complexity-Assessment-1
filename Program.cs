
using System.Text;

public static class Program
{
    static void Main()
    {
        int[] road1_256_arr = new int[256];
        int[] road2_256_arr = new int[256];
        int[] road3_256_arr = new int[256];
        var road1_256 = File.ReadAllLines("Road_1_256.txt");
        var road2_256 = File.ReadAllLines("Road_2_256.txt");
        var road3_256 = File.ReadAllLines("Road_3_256.txt");
        foreach(var road1 in road1_256)
        {
            road1_256_arr.Append(int.Parse(road1.ToString()));
        }
        foreach (var road2 in road2_256)
        {
            road2_256_arr.Append(int.Parse(road2.ToString()));
        }
        foreach (var road3 in road3_256)
        {
            road3_256_arr.Append(int.Parse(road3.ToString()));
        }
        int index = 1;
        int[] road1_256_asc = SortAsc256(road1_256_arr, index);
        int[] road1_256_desc = SortDesc256(road1_256_arr, index);

        Search(road1_256_asc);

    }
    static int[] SortAsc256(int[] arr, int index)
    {
        int count = 0;
        while (count < 255)
        {

        }

        Display10th(arr, index);
        return arr;
    }
    static int[] SortDesc256(int[] arr, int index)
    {
        Display10th(arr, index);
        return arr;
    }
    static void Search(int[] arr)
    {
        Console.WriteLine("Enter the value that you're searching for:");
        int value = 0;
        bool error = false;
        try
        {
            value = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("ERROR...You should have entered a number!");//error handling (if the user enters a non numeric value)
            error = true;//error handling (if the user enters a non numeric value)
        }
        catch (Exception exception)
        {
            error = true;
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
        }
        while (error)
        {
            Console.WriteLine("Enter the value that you're searching for:");//error handling (if the user enters a non numeric value)
            error = false;
            try
            {
                value = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR...You should have entered a number!");
                error = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  {exception.Message}");//error handling (if the user enters a non numeric value)
            }
        }
        /*
        int place = 0;
        if (arr.Length % 2 == 0)
        {
            place = arr.Length / 2;

        }
        else
        {
            place = (arr.Length + 1) / 2;
        }
        while (true)
        {
            if (arr.Length % 2 == 0)
            {
                if (arr[arr.Length / 2] == value)
                {
                    Console.WriteLine("The number " + value.ToString() + " was found at position " + place);
                }
                else if (arr[arr.Length / 2] > value)
                {
                    int[] half_arr = new int[arr.Length / 2];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] > value)
                        {

                        }
                    }
                    Array.Resize(ref arr, arr.Length / 2);
                }

            }
        }
        */
    }
    static int[] Merge256(int[] arr1, int[]arr3)
    {
        int[] merged_arr = new int[512];
        return merged_arr;
    }
    static int[] Merge2048(int[] arr1, int[] arr3)
    {
        int[] merged_arr = new int[4096];
        return merged_arr;
    }
    static void Display10th(int[] arr, int index)
    {
        if (index == 1)
        {
            Console.WriteLine("The tenth value in the first array is " + arr[9].ToString());

        }
        if (index == 2)
        {
            Console.WriteLine("The tenth value in the first array is " + arr[9].ToString());

        }
        if (index == 3)
        {
            Console.WriteLine("The tenth value in the first array is " + arr[9].ToString());

        }
    }
}
