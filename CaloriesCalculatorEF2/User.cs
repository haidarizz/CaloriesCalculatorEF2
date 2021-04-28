using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculatorEF2
{
    public class User
    {
        protected string name;
        protected double weight;
        protected double height;
        protected int age;
        protected int sex;
        //1 for male and 2 for female

        public User(string name, double weight, double height, int age, int sex)
        {
            this.name = name;
            this.weight = weight;
            this.height = height;
            this.age = age;
            this.sex = sex;
        }

        public void Greeting(string name)
        {
            Console.WriteLine("Hallo, {0}! Senang bertemu dengan Anda!", name);
        }

        public void ShowUsersData(string name, double weight, double height, int age, int sex)
        {
            Console.WriteLine("Nama\t: {0}", name);
            Console.WriteLine("Berat\t: {0} kg", weight);
            Console.WriteLine("Tinggi\t: {0} m", height);
            Console.WriteLine("Usia\t: {0} tahun", age);
            if (sex == 1)
            {
                Console.WriteLine("Gender\t: Pria");
            }
            else if (sex == 2)
            {
                Console.WriteLine("Gender\t: Wanita");
            }
        }
    }
}
