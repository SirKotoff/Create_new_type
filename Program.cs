using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_create_new_type
{
    class Program
    {
        static void Main(string[] args)
        {

            Pentagon p = new Pentagon();


 
                Console.WriteLine("Введите: Сторону A для рассчёта S,R,r");
                p.A = Convert.ToDouble(Console.ReadLine());
              
                    p.S();
                    Console.WriteLine($"Радиус описанной окружности (R)= [{p.R}]");
                    Console.WriteLine($"Радиус вписанной окружности (r)= [{p.r}]");
                    Console.WriteLine($"Площадь пятиугольника = [{p.Ss}]");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Периметр пятиугольника (P)=[{p.P()}] ");






            Console.ReadKey();
            
            
              



            






          
        }
    }
}
