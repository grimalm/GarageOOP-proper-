using System;
namespace GarageOOP
{
    public class garage
    {
        //attributes
        protected double NumWheels;

        List<double> Wheels = new List<double> { 2, 3, 4, 6, 8 };

        
        //properties

        protected double _engineSize; //attribute used inside property
        protected double EngineSize //fully implemented property
        {
            get => _engineSize;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"{value} not an acceptable engine size");
                }
                else
                {
                    _engineSize = value;
                }
            }
        }

        public string Brand { get; protected set; } //auto implemented property


        //constructor
        public garage(double enginesize, double numwheels, string brand)
        {
            EngineSize = enginesize;
            NumWheels = numwheels;
            Brand = brand;
        }

        //methods
        //getter
        public double GetNumWheels() { return NumWheels; }

        public bool SetNumWheels(double edit)
        {

            foreach (double num in Wheels)
            {

                if (edit == num)
                {
                    NumWheels = edit;
                    return true;
                }

            }
            return false;

        }

        Keys key = new(10);

        public bool UseKey(Keys CARKEY)
        {
            if (CARKEY.GetCode() == key.GetCode())
            {
                Console.WriteLine("Car Unlocked");
                return true;
            }
            else
            {
                Console.WriteLine("Wrong key");
                return false;
            }
        }
    }

    public class Motorcycle : garage
    {
        public Motorcycle(double enginesize, int numwheels, string brand) : base(enginesize, numwheels, brand)
        {
            EngineSize = 150;
            NumWheels = 2;
            Brand = brand;
        }
        public double CalcMaxPassengers()
        {
            double capacity = (Math.Sqrt(EngineSize)) / (Math.Pow(NumWheels, 2));
            return capacity;
        }

    }
    public class Truck : garage
    {
        public Truck(double enginesize, int numwheels, string brand) : base(enginesize, numwheels, brand)
        {
            EngineSize = 500;
            NumWheels = 6;
            Brand = brand;
        }
        public double CalcMaxLoadWeight()
        {
            double weight = 0;

            double Enginesquared = Math.Pow(EngineSize, 2);

            weight = Enginesquared * GetNumWheels();

            return weight;
        }
    }
    public class Sportscar : garage
    {
        public Sportscar(double enginesize, int numwheels, string brand) : base(enginesize, numwheels, brand)
        {
            EngineSize = 300;
            NumWheels = 4;
            Brand = brand;
        }

        public double CalcTopSpeed()
        {
            double topspeed = 0;

            double weight = 0;

            double Enginesquared = Math.Pow(EngineSize, 2);

            weight = Enginesquared * GetNumWheels();

            topspeed = Math.Pow(EngineSize, 2) - (weight / EngineSize) + EngineSize;

            return topspeed;
        }
    }

    public class Driver
    {
        private string Name;
        private Truck Truck;

        public Driver(string name, string address, Truck truck)
        {
            Name = name;
            Truck = truck;
        }

        public string GetName()
        {
            return Name;
        }

        public void GetTruckInfo()
        {
            Console.WriteLine(Truck.GetNumWheels());
            Console.WriteLine(Truck.CalcMaxLoadWeight());
            Console.WriteLine(Truck.Brand);
        }
        public virtual void OutputName()
        {
            Console.WriteLine(Name);
        }

        public void SetName(string change)
        {
            Name = change;
        }

    }

    public class Keys
    {
        private int CarKey;
        public Keys(int carkey)
        {
            CarKey = carkey;
        }
        public int GetCode()
        {
            return CarKey;
        }
    }

    public class Owner
    {
        private string Name;
        private Sportscar Sporty;

        public Owner(string name, string address, Sportscar sporty)
        {
            Name = name;
            Sporty = sporty;
        }

        public string GetName()
        {
            return Name;
        $}

        public void GetCarBrand()
        {
            Console.WriteLine(Sporty.Brand);
        }
        public virtual void OutputName()
        {
            Console.WriteLine(Name);
        }

        public void SetName(string change)
        {
            Name = change;
        }

    }
}