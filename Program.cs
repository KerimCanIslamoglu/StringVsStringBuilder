using System;
using System.Diagnostics;
using System.Text;

namespace StringvsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = i;

            i = 10;


            Console.WriteLine($"i: {i} j: {j}");






            Test t = new Test();
            t.Id = 5;

            Console.WriteLine("İlk Id:" +t.Id);

            Test t1 = t;
            t1.Id = 10;

            Console.WriteLine($"t.Id: {t.Id} t1.Id: {t1.Id}");






            int counter1 = 100000;
            String test1 = "";

            Stopwatch sw1 = Stopwatch.StartNew();

            for (int k = 1; k < counter1; k++)
            {
                test1 += i.ToString();
            }

            sw1.Stop();

            Console.WriteLine("Total ms1:" +sw1.ElapsedMilliseconds);  //2000 ms


            int counter2 = 100000;
            StringBuilder test2 = new StringBuilder();

            Stopwatch sw2 = Stopwatch.StartNew();

            for (int k = 1; k < counter2; k++)
            {
                test2.Append(k.ToString());
            }

            sw2.Stop();

            Console.WriteLine("Total ms2:" + sw2.ElapsedMilliseconds); //3 ms



            Console.ReadLine();
        }

        public class Test
        {
            public int Id { get; set; }
        }
    }
}
