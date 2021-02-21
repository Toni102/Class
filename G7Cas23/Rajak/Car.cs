using System;
using System.Collections.Generic;

namespace Rajak
{
    class Car
    {

        private string _color;

        public string Color {
            get
            {
                return this._color;
            }

            set
            {
                if (value.ToLower() != "black")
                {
                    this._color = value.ToUpper();
                }
            }
        }

        private string _manufacturer;
        public string Manufacturer
        {
            get
            {
                return this._manufacturer;
            }
        }

        private string _model;
        public string Model
        {
            get
            {
                return this._model;
            }
        }

        public CarEngine Engine { get; }

        public Car(string Manufacturer, string Model)
        {
            this._manufacturer = Manufacturer;
            this._model = Model;
            this.Engine = new CarEngine("CX625", 66);
        }

        public void Drive()
        {
            Console.WriteLine("Drive!");
        }

        public void Stop()
        {
            Console.WriteLine("Stop!");
        }
    }
}
