using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Train
{
    class Train
    {
        private int number;
        private string name;
        private string type;
        private int cars;

        public Train(int number, string name, string type, int cars)
        {
            this.number = number;
            this.name = name;
            this.type = type;
            this.cars = cars;
        }

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
            }
        }
        public int Cars
        {
            get { return cars; }
            set
            {
                cars = value;
            }
        }

        public override string ToString()
        {
            // 14545 Varna P 4
            return $"{this.Number} {this.Name} {this.Type} {this.Cars}";
        }
    }
}
