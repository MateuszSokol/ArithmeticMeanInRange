using System;

namespace ArithmeticMeanInRange
{
   public class Calculation
    {
        static void Main(string[] args)
        {


            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            int r = 2;
            int[] arr = { 1, 2, 3, 4, 5 };
            Calculation.SearchValueInArr(arr,2);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


        }

      
        public static int[] SearchValueInArr(int[] arr, int range)
        {
            int sum, counter;
            int divideCounter = 0;
            int [] returnValueArr = new int [arr.Length];

           
            for (int i = 0; i < arr.Length; i++)              
            {
                counter = 0;
                sum = 0;


                
                if (i-range < 0)
                {
                    for (int h = 0; h < range; h++)
                    {



                        sum += arr[h];
                        counter++;
                    }
                }
                else {

                    for (int c = (i-range)+1; c < i; c++)
                    {
                        sum += arr[c];
                        counter++;
                    }
                }

                if (i + range < arr.Length)
                {
                    for (int g = range; g < range+i; g++)
                    {
                        sum += arr[g];
                        counter++;
                    }
                }
                else
                {
                    for (int k = i; k < arr.Length; k++)
                    {
                        sum += arr[k];
                        counter++;
                    }
                }
                    
                returnValueArr[i] = sum/counter;
                


               
            }
            return returnValueArr;
        
        }
    }
 
}
