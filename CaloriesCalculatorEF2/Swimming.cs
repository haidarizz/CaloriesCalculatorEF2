using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculatorEF2
{
    public class Swimming : Sport, IShow
    {
        private double CaloriesBurned;
        public double caloriesBurned { get => CaloriesBurned; set => CaloriesBurned = value; }
        public Swimming(string when, double time) : base(when, time)
        {
            this.when = when;
            this.time = time;
        }

        public override double CalculateCaloriesBurned(double BMI, double time, double velocity = 1)
        {
            double CaloriesBurned = 0;
            CaloriesBurned = (365 + ((BMI) / 10.2) * 113) * (time / 60);
            return CaloriesBurned;
        }

        public void ShowActivity(string name)
        {
            Console.WriteLine("{0}, Anda telah melakukan renang selama {1} menit pada {2} hari.", name, time, when);
        }

        public void ShowRecommendation(double CaloriesBurned)
        {
            if (CaloriesBurned < 150)
            {
                Console.WriteLine("Anda hanya membakar {0} kalori setelah melakukan renang.", CaloriesBurned);
                Console.WriteLine("Kami menyarankan anda untuk menambah waktu Anda dalam melakukan renang agar dapat membakar kalori lebih banyak.");
                Console.WriteLine("Jangan lupa untuk melakukan aktivitas renang ini secara rutin yaa:). Have a nice day!");
            }
            else if (CaloriesBurned >= 150 && CaloriesBurned < 900)
            {
                Console.WriteLine("Anda telah membakar {0} kalori setelah melakukan renang.", CaloriesBurned);
                Console.WriteLine("Anda telah melakukan pembakaran kalori yang cukup! Kerja bagus! :)");
                Console.WriteLine("Jangan lupa untuk melakukan aktivitas jogging ini secara rutin yaa :). Have a nice day!");
            }
            else
            {
                Console.WriteLine("Anda telah membakar {0} kalori setelah melakukan renang.", CaloriesBurned);
                Console.WriteLine("Anda telah melakukan pembakaran kalori yang sangat besar! Pasti melelahkan, kami menyarankan untuk beristirahat ya friend :) Kerja bagus!");
                Console.WriteLine("Jangan lupa untuk melakukan aktivitas renang ini secara rutin yaa :). Have a nice day!");
            }
        }
    }
}
