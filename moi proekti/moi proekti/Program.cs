using System;

namespace moi_proekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vedite rostoyanie");
            Double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vedite kurs dollara");
            Double kurs = Convert.ToDouble(Console.ReadLine());
            Double prise = r * 1.5 * kurs;
            Console.WriteLine($"pri rostoyanie {r},pri kurse {kurs},stoimost poezdki={prise}");
            Console.ReadKey();


        }
    }
}
