using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {

            Car[] car = new Car[6];

            car[0] = new Car("Mitsubishi", "Lancer Evolution", 170000, true);
            car[1] = null;
            car[2] = new Car("Audi", "A7", 40000, true);
            car[3] = car[2];
            car[4] = car[2];
            car[5] = new Car("Seniorita", "Blondanita with Nemashimos", 0, true);

            PrintCar(car);



        }
        static void PrintCar(Car[] car)
        {
            for (int i = 0; i < car.Length; i++)
            {
                if (car[i] != null)
                {
                    car[i].Details();

                }

            }
        }



        class Car
        {

            public string manufacturer;
            public string model;
            public int km;
            public bool abs;
            public Car(string manufacturer, string model, int km, bool abs)
            {
                this.manufacturer = manufacturer;
                this.model = model;
                this.km = km;
                this.abs = abs;
            }
            public void Details()
            {
                string Details = manufacturer + " " + model + " " + km.ToString() + " " + abs.ToString();
                Console.WriteLine(Details);
            }

        }







    }
}







