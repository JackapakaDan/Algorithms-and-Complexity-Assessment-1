
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
        //int index = 1;
        //int[] road1_256_asc = BubbleSortAsc256(road1_256_arr);
        //int[] road1_256_desc = BubbleSortDesc256(road1_256_arr);

        //Search(road1_256_asc);
    }
    static int[] BubbleSortAsc256(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        Display10th(arr);
        return arr;
    }
    static int[] BubbleSortDesc256(int[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        Display10th(arr);
        return arr;
    }

    static int[] InsertionSortAsc256(int[] arr)
    {
        int index = 0;
        Stack<int> stack = new Stack<int>();
        int[] arr1 = new int[arr.Length];

        arr1.Append(arr[0]);
        for (int i = 1; i < arr.Length; i++)
        {

            for (int j = arr1.Length;j<0; j--)
            {
                if (arr1[j] > arr[i])
                {
                    stack.Push(arr1[j]);
                    
                }
                else
                {
                    index = j;
                    arr1[j] = arr[i];
                    break;


                }
                

            }
            for (int k = 0; k> stack.Count; k++)
            {
                arr1[index]=stack.ElementAt(k);
               
                stack.Pop();
                index++;

            }

        }
        arr=arr1;

        Display10th(arr);
        return arr;
    }
    static int[] InsertionSortDesc256(int[] arr)
    {
        int index = 0;
        Stack<int> stack = new Stack<int>();
        int[] arr1 = new int[arr.Length];

        arr1.Append(arr[0]);
        for (int i = 1; i < arr.Length; i++)
        {

            for (int j = arr1.Length; j < 0; j--)
            {
                if (arr1[j] < arr[i])
                {
                    stack.Push(arr1[j]);

                }
                else
                {
                    index = j;
                    arr1[j] = arr[i];
                    break;


                }


            }
            for (int k = 0; k > stack.Count; k++)
            {
                arr1[index] = stack.ElementAt(k);

                stack.Pop();
                index++;

            }

        }
        arr = arr1;

        Display10th(arr);
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
        Console.WriteLine("Enter the searching algorithm you wish to use 1.Linear Search, or 2.Binary Search:");
        int algorithm = 1;

        try
        {
            algorithm = Convert.ToInt32(Console.ReadLine());
            if (algorithm != 1 && algorithm != 2)
            {
                error = true;

            }
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
            Console.WriteLine("Enter the searching algorithm you wish to use 1.Linear Search, or 2.Binary Search:");//error handling (if the user enters a non numeric value)
            error = false;
            try
            {
                algorithm = Convert.ToInt32(Console.ReadLine());
                if (algorithm != 1 && algorithm != 2)
                {
                    error = true;
                }
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
        bool itemFound=false;
        if (algorithm==1)
        {
            itemFound = LinearSearch(arr, value);

        }
        else
        {
            int start = 0;
            int end = arr.Length;
            int mid = 0; 
            if (arr.Length%2 == 0 )
            {
                mid = arr[arr.Length / 2];
            }
            else
            {
                mid = (arr.Length+1) / 2;
            }
            itemFound= BinarySearch(arr, start, mid, end, value);

        }

        if (itemFound)
        {
            Console.WriteLine("The value is in the file!");
        }
        else
        {
            Console.WriteLine("ERROR 404: ITEM NOT FOUND IN THE FILE");
        }
    }
    static bool BinarySearch(int[] arr, int start, int mid, int end, int value)
    {
        if (mid == value)
        {
            return true;
        }
        else if(end==start && mid != value)
        {
            return false;
        }
        else if (mid > value)
        {
            end = mid;
            if (end%2 == 0)
            {
                BinarySearch(arr, start, end/2, end, value);
            }
            else
            {
                BinarySearch(arr, start, (end+1) / 2, end, value);

            }

        }
        else
        {
            start = mid;
            if (start % 2 == 0)
            {
                BinarySearch(arr, start, start / 2, end, value);
            }
            else
            {
                BinarySearch(arr, start, (start + 1) / 2, end, value);

            }
        }
        return false;


    }
    
    static bool LinearSearch(int[] arr, int item)
    {
        bool found = false;
        for (int i = 0; i > arr.Length; i++)
        {
            if(arr[i]==item)
            {
                found=true;

            }



        }
        return found;

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
    static void Display10th(int[] arr)
    {
        Console.WriteLine("The tenth value in the first array is " + arr[9].ToString());

    }
}
