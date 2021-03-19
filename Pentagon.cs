using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_create_new_type
{
    public class Pentagon
    {

        public double A { get; set; }
        public double R { get; set; }
        public double r { get; set; }
        public double Ss { get; set; }
        public double p { get; set; }



        public void S()
        {
            //         S = a² / 4 * √ 25 + 10 * √5 
            //        re = a / 10 * √ 50 + 10 * √5
            //        ri = a / 10 * √ 25 + 10 * √5     




            if (A > 0)
            {
                Ss = Math.Pow(A, 2) / 4 * Math.Sqrt(25 + 10 * Math.Sqrt(5));
                R = A / 10 * Math.Sqrt(50 + 10 * Math.Sqrt(5));
                r = A / 10 * Math.Sqrt(25 + 10 * Math.Sqrt(5));

            }
            else
            {

            }





        }

        public double P()
        {
            // формула рассчёта периметра пятиугольника равна a*5 где a-длина стороны, 5-количество углов 
           p = A*5;
            return p;
        }

    }
}