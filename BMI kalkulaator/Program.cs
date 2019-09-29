using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_kalkulaator
{
	class Program
	{
		static void Main(string[] args)
		{
            

            Console.WriteLine("Mis on Sinu nimi?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Tere, " + Name + "!");

            int Year;
            Console.WriteLine("Kui vana Teie olete?");
            Year = int.Parse(Console.ReadLine());

            if (Year < 20)
            {
                Console.WriteLine("Andke andeks, aga see programm annab õigeid tulemusi ainult vanusevahemikus 20-60 aastat.");
                Console.ReadLine();
            }

            else if (Year > 60)
            {
                Console.WriteLine("Andke andeks, aga see programm annab õigeid tulemusi ainult vanusevahemikus 20-60 aastat.");
                Console.ReadLine();
            }
            
            else
            {
                double height;
                double weight;
                

                Console.WriteLine("Sisestage palun oma pikkus sentimeetrites.");
                height = int.Parse(Console.ReadLine());
                Console.WriteLine("Sisestage palun oma kehakaal kilogrammides.");
                weight = int.Parse(Console.ReadLine());

                double bmi = weight / ((height * height) / 10000);


                Console.WriteLine($"Teie kehamassiindeks on " + Math.Round(bmi, 2));
                 
                if (bmi < 16)
                {
                    Console.WriteLine("Te olete tervisele ohtlikus alakaalus!");
                }

                else if (bmi >= 16 && bmi <= 18.5)
                {
                    Console.WriteLine("Te olete alakaaluline!");
                }

                else if (bmi >= 18.6 && bmi <= 25)
                {
                    Console.WriteLine("Te olete normaalkaalus!");
                }
                
                else if (bmi >= 25.1 && bmi <= 30)
                {
                    Console.WriteLine("Te olete ülekaaluline!");
                }
 
                else if (bmi >= 30.1 && bmi <= 35)
                {
                    Console.WriteLine("Te olete rasvunud!");
                }

                else if (bmi >= 35.1 && bmi <= 40)
                {
                    Console.WriteLine("Te olete tugevalt rasvunud!");
                }

                else
                {
                    Console.WriteLine("Te olete eluohtlikult rasvunud!");
                }




            }

            Console.ReadLine();


		}
	}
}
