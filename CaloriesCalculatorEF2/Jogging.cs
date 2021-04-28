using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculatorEF2
{
    public class Jogging : Sport, IShow
    {
        private double distance;
        private double velocity;
        private double CaloriesBurned;
        public double velo { get => velocity; set => velocity = value; }
        public double caloriesBurned { get => CaloriesBurned; set => CaloriesBurned = value; }

        public Jogging(string when, double time, double distance) : base(when, time)
        {
            this.when = when;
            this.time = time;
            this.distance = distance;
            //this.speed = speed;
        }

        public double CalculateVelocity(double distance, double time)
        {
            double velocity = 0;
            velocity = distance / (time / 60);
            return velocity;
        }

        public override double CalculateCaloriesBurned(double BMI, double distance, double velocity = 8)
        {
            double multiplier = 0;
            if (BMI < 18.5)
            {
                multiplier = 0.95;
            }
            else if (BMI >= 18.5 && BMI < 24.9)
            {
                multiplier = 1;
            }
            else if (BMI >= 24.9 && BMI < 29.9)
            {
                multiplier = 1.2;
            }
            else
            {
                multiplier = 1.4;
            }
            double CaloriesBurned = 0;
            CaloriesBurned = (velocity / 8) * multiplier * distance * 60;
            return CaloriesBurned;
        }

        public void ShowActivity(string name)
        {
            Console.WriteLine("{0}, Anda telah melakukan jogging selama {1} menit pada {2} hari dengan jarak {3} kilometer dengan kecepatan rata-rata {4} km/jam.", name, time, when, distance, velocity);
        }

        public void ShowRecommendation(double CaloriesBurned)
        {
            if (CaloriesBurned < 150)
            {
                Console.WriteLine("Anda hanya membakar {0} kalori setelah melakukan jogging.", CaloriesBurned);
                Console.WriteLine("Kami menyarankan anda untuk menambah waktu Anda dalam melakukan jogging agar dapat membakar kalori lebih banyak.");
                Console.WriteLine("Jangan lupa untuk melakukan aktivitas jogging ini secara rutin yaa:). Have a nice day!");
            }
            else if (CaloriesBurned >= 150 && CaloriesBurned < 900)
            {
                Console.WriteLine("Anda telah membakar {0} kalori setelah melakukan jogging.", CaloriesBurned);
                Console.WriteLine("Anda telah melakukan pembakaran kalori yang cukup! Kerja bagus! :)");
                Console.WriteLine("Jangan lupa untuk melakukan aktivitas jogging ini secara rutin yaa :). Have a nice day!");
            }
            else
            {
                Console.WriteLine("Anda telah membakar {0} kalori setelah melakukan jogging.", CaloriesBurned);
                Console.WriteLine("Anda telah melakukan pembakaran kalori yang sangat besar! Pasti melelahkan, kami menyarankan untuk beristirahat ya friend :) Kerja bagus!");
                Console.WriteLine("Jangan lupa untuk melakukan aktivitas jogging ini secara rutin yaa :). Have a nice day!");
            }
        }
    }
}
