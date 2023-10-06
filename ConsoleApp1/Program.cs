using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static string  EnterInNum()
        {
            string number1 =(Console.ReadLine());
            return number1;
        }

        static bool NumOrNotNum(string number1, out int value)
        {


            return int.TryParse(number1, out value);


        }

        static int Sum(ref int num1, ref int num2)
        {


            return num1 + num2;




        }

        static void Main(string[] args) {

            Console.WriteLine(" consola eded daxil edin: ");
            string a = EnterInNum();


            int num1, num2;
            if (NumOrNotNum(a, out int newnum))
            {
                Console.WriteLine("ikinci ededi daxil edin: ");
                string b = EnterInNum();

                if (NumOrNotNum(b, out int new2num))
                {
                    int sum = Sum(ref newnum, ref new2num);
                    Console.WriteLine(sum);
                }
                else Console.WriteLine("2 ci eded int e donusdurulmur");

            }
            else Console.WriteLine("1 ci eded int e donusdurulmur");
        
    

















            //////////////////second task////////////////
            //int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Metod(ref arr, 35);


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}



            //static void Metod(ref int[] numbers, int value)
            //{
            //    int[] newArray = new int[numbers.Length + 1];

            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        newArray[i] = numbers[i];
            //    }
            //    newArray[^1] = value;

            //    numbers = newArray;
            //}



        }   
    
    }
}