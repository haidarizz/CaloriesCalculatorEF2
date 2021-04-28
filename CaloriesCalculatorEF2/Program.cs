using System;
using System.Collections.Generic;
using CaloriesCalculatorEF2.Entities;

namespace CaloriesCalculatorEF2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Siapakah nama Anda? ");
            string name = Console.ReadLine();

            Console.Write("Berapakah berat badan Anda? (dalam kilogram): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Berapakah tinggi badan Anda? (dalam centimeter): ");
            double height = (Convert.ToDouble(Console.ReadLine())) / 100;

            Console.Write("Berapakah usia Anda saat ini? ");
            int age = (Convert.ToInt32(Console.ReadLine()));

            Console.Write("Apa jenis kelamin Anda?\n1. Laki-laki\n2.Perempuan\nPilih 1 atau 2: ");
            int sex = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\n");

            using(var context = new Entities.AppContext())
            {
                var UserGeneral = new General
                {
                    Name = name,
                    Age = age,
                    Sex = sex
                };

                var UserGeneral2 = new General
                {
                    Name = "Pablo",
                    Age = 17,
                    Sex = 1
                };

                context.Generals.Add(UserGeneral);
                context.Generals.Add(UserGeneral2);
                context.SaveChanges();
            }

            User YourData = new User(name, weight, height, age, sex);
            YourData.Greeting(name);
            Console.WriteLine("Kita akan menampilkan data diri Anda!");
            YourData.ShowUsersData(name, weight, height, age, sex);

            Console.WriteLine("\nApa yang ingin anda lakukan?");
            Console.WriteLine("1. Menampilkan kebugaran dan rekomendasi kesehatan untuk Anda (kebutuhan kalori, kondisi berat badan).");
            Console.WriteLine("2. Menghitung kalori Anda yang terbakar setelah jogging.");
            Console.WriteLine("3. Menghitung kalori Anda yang terbakar setelah berenang.");
            Console.Write("Masukkan pilihan Anda (1, 2, atau 3): ");
            int choice = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\n");

            YourHealth YourCondition = new YourHealth(name, weight, height, age, sex);
            YourCondition.bmi = YourCondition.CalculateBMI(weight, height);

            if (choice == 1)
            {
                Console.Write("Seberapa sering Anda berolahraga dari 0-10 (0 untuk tidak pernah dan 10 untuk sering sekali)? ");
                YourCondition.freq = (Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("\n");

                YourCondition.bmr = YourCondition.CalculateBMR(weight, height, age, sex);
                YourCondition.caloriesNeeded = YourCondition.CalculateCaloriesNeeded(YourCondition.bmr, YourCondition.freq);
                YourCondition.ShowBMI(YourCondition.bmi);
                Console.WriteLine("\n");
                YourCondition.ShowBMR(YourCondition.bmr, YourCondition.caloriesNeeded);
            }

            else if (choice == 2 || choice == 3)
            {
                Console.Write("Kapan Anda melakukan aktivitas ini (pagi, siang, sore, malam)?");
                string when = Console.ReadLine();
                Console.Write("\nBerapa lama Anda melakukan aktivitas ini (dalam menit)? ");
                double time = (Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("\n");

                if (choice == 2)
                {
                    Console.Write("Berapa jarak anda melakukan jogging (dalam meter)? ");
                    double distance = (Convert.ToDouble(Console.ReadLine())) / 1000;
                    Console.WriteLine("\n");
                    Jogging YourJogging = new Jogging(when, time, distance);

                    YourJogging.velo = YourJogging.CalculateVelocity(distance, time);
                    YourJogging.caloriesBurned = YourJogging.CalculateCaloriesBurned(YourCondition.bmi, distance, YourJogging.velo);
                    YourJogging.ShowActivity(name);
                    YourJogging.ShowRecommendation(YourJogging.caloriesBurned);
                }

                if (choice == 3)
                {
                    Swimming YourSwimming = new Swimming(when, time);
                    YourSwimming.caloriesBurned = YourSwimming.CalculateCaloriesBurned(YourCondition.bmi, time);
                    YourSwimming.ShowActivity(name);
                    YourSwimming.ShowRecommendation(YourSwimming.caloriesBurned);
                }
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
