using System.Collections;

namespace DEPI_C__Session10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Bubble Sort algorithm Optimize 
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //BubbleSort(numbers);
            //foreach (var n in numbers) Console.WriteLine(n);
            #endregion

            #region 3.ArrayList
            //ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5 };

            //ReverseArrayList(numbers);

            //foreach (object number in numbers)
            //{
            //    Console.Write(number + " ");
            //} 
            #endregion

            #region 4.
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            //List<int> evenNumbers = GetEvenNumbers(numbers);

            //foreach (int number in evenNumbers)
            //{
            //    Console.WriteLine(number);
            //} 
            #endregion


            #region 5
            //FixedSizeList<int> numbers = new FixedSizeList<int>(3);

            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);

            //Console.WriteLine(numbers.Get(0));
            //Console.WriteLine(numbers.Get(1));
            //Console.WriteLine(numbers.Get(2));

            //numbers.Add(40); // throw Exception 


            #endregion

            #region 6.
            string text = "swiss";

            int index = FirstNonRepeatedCharacter(text);

            Console.WriteLine(index); 
            #endregion

        }

        //static void BubbleSort(int[] arr)
        //{
        //    int n = arr.Length;

        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        bool swapped = false;

        //        for (int j = 0; j < n - 1 - i; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //            {

        //                int temp = arr[j];
        //                arr[j] = arr[j + 1];
        //                arr[j + 1] = temp;

        //                swapped = true;
        //            }
        //        }


        //        if (!swapped)
        //        {
        //            break;
        //        }
        //    }
        //}


        //static void ReverseArrayList(ArrayList list)
        //{
        //    int left = 0;
        //    int right = list.Count - 1;

        //    while (left < right)
        //    {
        //        // Swap
        //        object temp = list[left];
        //        list[left] = list[right];
        //        list[right] = temp;

        //        left++;
        //        right--;
        //    }
        //}



        //static List<int> GetEvenNumbers(List<int> numbers)
        //{
        //    List<int> evenNumbers = new List<int>();

        //    foreach (int number in numbers)
        //    {
        //        if (number % 2 == 0)
        //        {
        //            evenNumbers.Add(number);
        //        }
        //    }

        //    return evenNumbers;
        //}


        public static int FirstNonRepeatedCharacter(string text)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            
            foreach (char c in text)
            {
                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else
                    frequency[c] = 1;
            }

          
            for (int i = 0; i < text.Length; i++)
            {
                if (frequency[text[i]] == 1)
                    return i;
            }

            return -1;
        }



    }
    
}
