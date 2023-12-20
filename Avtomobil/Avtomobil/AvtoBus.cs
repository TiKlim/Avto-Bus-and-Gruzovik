using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtomobil
{
    internal class AvtoBus : Avto
    {
        protected int ostanovky;
        protected int mesta;
        protected List<Avto> cars = new List<Avto>();
        public AvtoBus() { Menu(cars); }
        public static void Menu4(List<Avto> cars)
        {
            //AvtoBus bus = new AvtoBus();
            //cars.Add(bus);
            //bus.Menu2(cars);
            Console.WriteLine("> Вы выбрали городской-общественный тип автомобиля.");
        }
        protected override void Menu(List<Avto> cars)
        {
            base.Menu(cars);
        }
        protected override void Info(List<Avto> cars)
        {
            base.Info(cars);
            Console.WriteLine("> Вместимость:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            this.mesta = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Данные сохранены.");
            Console.ForegroundColor = ConsoleColor.White;
            Menu2(cars);
        }
        protected override void Menu2(List<Avto> cars)
        {
            base.Menu2(cars);

        }
        protected override void Info2(List<Avto> cars)
        {
            base.Info2(cars);
        }
    }
}
