using System;
using System.IO;

namespace ArrayLib
{
    public class OneDimArray
    {
        private int sum;
        int[] array;
        private int Max;
        //public int sum;
        public int Sum
        {

            private set
            {
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
            }
            get
            {
                return sum;
            }
        }
        public int MaxCount
        {
            private set
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > Max)
                        Max = array[i];
                }
            }
            get
            {
                return Max;
            }
        }
        public OneDimArray(int n)
        {
            array = new int[n];
        }
        public OneDimArray(int n, int step, int first)
        {
            array = new int[n];
            array[0] = first;
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = array[i - 1] + step;
            }
            Sum = sum;
            MaxCount = Max;
        }
        public void InitArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10000);
            }
            Sum = sum;
            MaxCount = Max;
        }
        public OneDimArray(string filename)
        {
            try
            {
                StreamReader sr = new StreamReader(filename);


                int N = int.Parse(sr.ReadLine());
                array = new int[N];
                for (int i = 0; i < N; i++)
                {
                    array[i] = int.Parse(sr.ReadLine());
                }
                sr.Close();
                Sum = sum;
                MaxCount = Max;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }

        static int ThreeDivis(int nom)
        {
            return (nom % 3 == 0) ? 0 : 1;
        }
        public int CountOfThreeDenomPars()
        {
            int i = 0, j = 0;
            for (; i < array.Length - 1; i++)
            {
                if (ThreeDivis(array[i]) == 0 || ThreeDivis(array[i + 1]) == 0)
                {
                    //Console.WriteLine($"{array[i]},{array[i+1]}");
                    j++;
                }
            }
            return j;
        }
        public void Output()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }
        public OneDimArray Invers()
        {
            OneDimArray new_array = new OneDimArray(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                new_array.array[i] = -array[i];
            }
            return new_array;
        }
        public void Multi(int num)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= num;
            }
        }

    }

}
