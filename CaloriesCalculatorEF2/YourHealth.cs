using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculatorEF2
{
    public class YourHealth : User
    {
        private double BMI;
        private double BMR;
        private double CaloriesNeeded;
        private int frequency;
        public double bmi { get => BMI; set => BMI = value; }
        public double bmr { get => BMR; set => BMR = value; }
        public double caloriesNeeded { get => CaloriesNeeded; set => CaloriesNeeded = value; }
        public int freq { get => frequency; set => frequency = value; }

        public YourHealth(string name, double weight, double height, int age, int sex) : base(name, weight, height, age, sex)
        {
            this.name = name;
            this.weight = weight;
            this.height = height;
            this.age = age;
            this.sex = sex;
        }

        public double CalculateBMI(double weight, double height)
        {
            double BMI = 0;
            BMI = weight / (height * height);
            return BMI;
        }

        public double CalculateBMR(double weight, double height, int age, int sex)
        {
            double BMR = 0;
            if (sex == 1)
            {
                BMR = 66.5 + (13.7 * weight) + (5 * height) - (6.8 * age);
            }
            else if (sex == 2)
            {
                BMR = 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
            }
            return BMR;
        }

        public double CalculateCaloriesNeeded(double BMR, double frequency)
        {
            double multiplier = (frequency / 10) * 0.7 + 1.2;
            double CaloriesNeeded = multiplier * BMR;
            return CaloriesNeeded;
        }

        public void ShowBMI(double BMI)
        {
            Console.WriteLine("BMI (Body Mass Index) Anda adalah {0}.", BMI);
            if (BMI < 18.5)
            {
                Console.WriteLine("Berat badan Anda berada di dalam kategori di bawah normal.");
                Console.WriteLine("Anda disarankan untuk memperbaiki pola makan dan menambah berat badan melalui program-program yang bisa menambah berat badan.");
                Console.WriteLine("Meskipun Anda termasuk dalam kategori kurang berat badan, Anda tetap disarankan berolahraga untuk menjaga kebugaran.");
            }
            else if (BMI >= 18.5 && BMI < 24.9)
            {
                Console.WriteLine("Berat badan Anda berada di dalam kategori normal.");
                Console.WriteLine("Kerja bagus! Anda disarankan untuk menjaga pola makan, berolahraga, dan beraktivitas agar tetap memiliki badan yang ideal.");
            }
            else if (BMI >= 24.9 && BMI < 29.9)
            {
                Console.WriteLine("Berat badan Anda berada di dalam kategori kelebihan berat badan.");
                Console.WriteLine("Anda disarankan untuk memperbaiki pola makan dan melakukan diet sehat agar terhindar dari penyakit-penyakit akibat kelebihan berat badan seperti kanker, diabetes, dan lain-lain.");
                Console.WriteLine("Selain itu, Anda juga disarankan untuk rutin berolahraga agar dapat membakar kalori dengan baik.");
            }
            else
            {
                Console.WriteLine("Berat badan Anda berada di dalam kategori kelebihan obesitas. :(((");
                Console.WriteLine("Anda disarankan untuk memperbaiki pola makan dan melakukan diet sehat agar terhindar dari penyakit-penyakit akibat kelebihan berat badan seperti kanker, diabetes, dan lain-lain.");
                Console.WriteLine("Selain itu, Anda juga disarankan untuk rutin berolahraga agar dapat membakar kalori dengan baik.");
                Console.WriteLine("Anda harus bekerja keras untuk menurunkan berat badan! Semangattt!!");
            }
        }

        public void ShowBMR(double BMR, double CaloriesNeeded)
        {
            Console.WriteLine("BMR (Basal Metabolic Rate) Anda adalah {0}.", BMR);
            Console.WriteLine("Kalori yang anda butuhkan setiap harinya adalah {0} kalori.", CaloriesNeeded);
            Console.WriteLine("Anda diharapkan memenuhi kebutuhan kalori tersebut agar anda tidak kekurangan energi untuk melakukan aktivitas sehari-hari.");
            Console.WriteLine("Kalori dapat diperoleh dari makanan-makanan yang Anda makan, jangan lupa untuk memakan makanan yang sehat ya!");
            Console.WriteLine("Have a nice day :))");
        }
    }
}
