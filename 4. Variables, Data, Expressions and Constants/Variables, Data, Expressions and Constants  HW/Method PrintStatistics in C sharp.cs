namespace Variables__Data__Expressions_and_Constants__HW
{
    using System;

    class Method_PrintStatistics_in_C_sharp
    {
        public void PrintArrayStatistics(double[] arr)
        { 
            var min = GetMin(arr);
            var max = GetMax(arr);
            var average = GetAverage(arr);

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(average);

        }

        public double GetMin(double[] arr)
        {
            var min = arr[0];
            var lenght = arr.Length;

            for (int i = 0; i < lenght; i++)
            {
                var currentMin = arr[i];
                if (currentMin < min)
                {
                    min = currentMin;
                }
            }


            return min;
        }

        public double GetMax(double[] arr)
        {
            var max = arr[0];
            var lenght = arr.Length;

            for (int i = 0; i < lenght; i++)
            {
                var currentMin = arr[i];
                if (currentMin > max)
                {
                    max = currentMin;
                }
            }


            return max;
        }

        public double GetAverage(double[] arr)
        {
            var sum = arr[0];
            var lenght = arr.Length;

            for (int i = 1; i < lenght; i++)
            {
                sum += arr[i];
            }

            var average = sum / lenght;

            return average;
        }
    }
}
