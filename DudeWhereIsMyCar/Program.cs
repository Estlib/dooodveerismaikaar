using System;

namespace DudeWhereIsMyCar
{
    class Program
    {
        class Car
        {
            public string maker;
            public string model;
            public string license;
            public string colour;
            public int odometer = 0;
            public int fuelamount = 60;
                       
            public Car(string _maker, string _model, string _license, string _colour, int _odometer, int _fuelamount)
            {
                if (_license.Length > 6 || _license.Length < 5)
                {
                    throw new ArgumentException("Auto registrinumber on vale pikkusega.\nSisestatud sobivad pikkused on 6 märki eesti autol või 5 märki USA autol.");
                }
                maker = _maker;
                model = _model;
                license = _license;
                colour = _colour;
                odometer = _odometer;
                fuelamount = _fuelamount;
            }
            public void CarData()
            {
                Console.WriteLine($"Auto hetkeseis:\nTootja ja mudel: {maker} {model}\nnumbrimärk: {license}\nVärvus: {colour}\nKütust liitrites: {fuelamount}\nLäbitud teekond kilomeetrites: {odometer}");
            }
            public void DriveOneLap()
            {
                if (fuelamount > 0)
                {
                    odometer += 100;
                    fuelamount -= 5;
                    Console.WriteLine("auto sõitis terve ringi");
                }
                else
                {
                    Console.WriteLine($"Paak on tühi. Auto jäi seisma.");
                }
            }
            public int FuelLeft()
            {
                return fuelamount;
            }
            public void CheckTank()
            {
                if (fuelamount == 0)
                {
                    Console.WriteLine($"Paak on tühi. Auto jäi seisma.");
                }
                else
                {
                    Console.WriteLine($"Kütust on järgi {fuelamount}");
                }
            }
        }
        static void Main(string[] args)
        {
            Car car = new Car("WolksVagen", "Beetle", "4AE6TRtuif", "kollane", 0, 60);
            car.CarData();
            LineSplit();
            car.DriveOneLap();
            car.CarData();
            LineSplit();
            do
            {
                car.DriveOneLap();
                car.CarData();
                car.CheckTank();
                LineSplit();
                
            } while (car.FuelLeft() != 0);
        }
        private static void LineSplit()
        {

            Console.WriteLine($"\n===========================\n");
        }
    }
}
