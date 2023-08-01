namespace HomeWork3.InterfaceHW
{
    internal class Array : IOutput, IMath, ISort
    {
        private int[] array;         

        public Array(int[] values)
        {
            array = values;
        }

        public void Show()
        {
            //Sorting(array)
            Console.Write("Массив: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            //Sorting(array);
            //Console.Write("Массив: ");
            Console.Write($"\nInfo: {info}: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            //Console.Write("\nInfo: " + info);

        }

        // Bubble Sort изначально сортировка проходила так
        //public static void Sorting(int[] array)
        //{
        //    for (int i = 0; i < array.Length - 1; i++)
        //    {
        //        for (int j = 0; j < array.Length - i - 1; j++)
        //        {
        //            if (array[j] > array[j + 1])
        //            {
        //                // Обмен элементов
        //                int temp = array[j];
        //                array[j] = array[j + 1];
        //                array[j + 1] = temp;
        //            }
        //        }
        //    }
        //}

        public int Max()
        {
            int max = array[0];
            foreach(int i in array)
            {
                if(i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        public int Min()
        {
            int min = array[0];
            foreach (int i in array)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return (float)sum / array.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int i in array)
            {
                if (i == valueToSearch)
                    return true;
            }
            return false;
        }

        //используем метод Sort для сортировки
        public void SortAsc()
        {
            System.Array.Sort(array);
        }

        public void SortDesc()
        {
            System.Array.Sort(array);
            System.Array.Reverse(array);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }
}
