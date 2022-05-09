/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            list array = new list();
            Console.WriteLine("Введите размер массива");
            size = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            array.SetList(size);
            result res=new result();
            res.GetEvenNums(array, size);

        }
        class list
        {
            protected
            int[] arr;
            public
                void SetList(int size)
            {
                Random rnd = new Random();
                int[] tmp_arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    tmp_arr[i]=rnd.Next(100, 999);
                }
                Console.WriteLine("Получившийся массив:");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(Convert.ToString(tmp_arr[i]), " ");
                }
                arr = tmp_arr;
            }
        public
                int[] GetList()
            { return arr; }

        }
        class result
        {
            public
                void GetEvenNums(list array, int size)
            {
                int[] arr = array.GetList();
                int counter = 0;
                for (int i = 0; i < size; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        counter++;
                    }
                
                }
                Console.Write("Колличество чётных: ");
                Console.Write(Convert.ToString(counter));
            }
        }
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            list array = new list();
            Console.WriteLine("Введите размер массива");
            size = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            array.SetList(size);
            result res=new result();
            res.GetNums(array, size);

        }
        class list
        {
            private
            int[] arr;
            public
                void SetList(int size)
            {
                Random rnd = new Random();
                int[] tmp_arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    tmp_arr[i]=rnd.Next(-100, 999);
                }
                Console.WriteLine("Получившийся массив:");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(Convert.ToString(tmp_arr[i]), " ");
                }
                arr = tmp_arr;
            }
        public
                int[] GetList()
            { return arr; }

        }
        class result
        {
            public
                void GetNums(list array, int size)
            {
                int[] arr = array.GetList();
                int counter = 0;
                for (int i = 0; i < size; i++)
                {
                    if (i%2!=0)
                    {
                        counter+=arr[i];
                    }
                
                }
                Console.Write("Сумма элементов стоящих на нечётных позициях: ");
                Console.Write(Convert.ToString(counter));
            }
        }
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            list array = new list();
            Console.WriteLine("Введите размер массива");
            size = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            array.SetList(size);
            result res=new result();
            res.GetSumMaxMinNums(array, size);

        }
        class list
        {
            private
            int[] arr;
            public
                void SetList(int size)
            {
                Random rnd = new Random();
                int[] tmp_arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    tmp_arr[i]=rnd.Next(-100, 999);
                }
                Console.WriteLine("Получившийся массив:");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(Convert.ToString(tmp_arr[i]), " ");
                }
                arr = tmp_arr;
            }
        public
                int[] GetList()
            { return arr; }

        }
        class result
        {
            public
                void GetSumMaxMinNums(list array, int size)
            {
                int[] arr = array.GetList();
                int max = arr[0];
                int min = arr[0];
                for (int i = 0; i < size; i++)
                {
                    if (min>arr[i])
                    {
                        min = arr[i];
                    }
                    if (max < arr[i])
                    {
                        max = arr[i];
                    }
                }
                int sum =min+max;
  
                Console.Write("Сумма максимального и минимального значений стоящих на нечётных позициях: ");
                Console.Write(Convert.ToString(sum));
            }
        }
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nums nums = new Nums();
            Console.WriteLine("Введите A и B");
            Console.Write("A=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B=");
            int b = Convert.ToInt32(Console.ReadLine());
            nums.SetB(b);
            nums.SetA(a);
            nums.SetA1(a);
            result res = new result();
            res.GetSumMaxMinNums(nums);

        }
        class Nums
        {
            protected
                int A1;
            protected
                 int A;
            protected
                int B;

            public
            void SetA(int a)
            { A = a; }
            public
          void SetA1(int a)
            { A1 = a; }
            public
            void SetB(int b)
            { B = b; }
            public
            int GetA()
            { return A; }
            public
            int GetB()
            { return B; }
            public
            int GetA1()
            { return A1; }

        }
        class result
        {
            public
                void GetSumMaxMinNums(Nums nums)
            {
                for (int i = 0; i < nums.GetB()-1 ; i++)
                {
                    nums.SetA(nums.GetA() * nums.GetA1());
                }


                Console.Write("А в степени B: ");
                Console.Write(Convert.ToString(nums.GetA()));
            }
        }
    }
}
*/