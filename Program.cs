using System.Text;

public class baitap21
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int[] arr = { 4, 12, 7, 8, 1, 6, 9 };
        int index = MinValueIndex(arr);
        Console.WriteLine("Vị trí của phần tử nhỏ nhất trong mảng là: " + arr[index]);
    }
    //public static int MinValue(int[] array)
    //{

    //    int min = array[0];
    //    int index = 0;

    //    for (int i = 1; i < array.Length; i++)
    //    {
    //        if (array[i] < min)
    //        {
    //            min = array[i];
    //            index = i;
    //        }
    //    }
    //    return index;
    //}
    public static int MinValueIndex(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("Mảng không được null hoặc rỗng.");
        }
        int min = arr[0];
        int minIndex = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
                minIndex = i;
            }
        }
        return minIndex;
    }
}