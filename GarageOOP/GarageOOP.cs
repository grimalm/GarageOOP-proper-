using System;

public class garage
{
    //attributes
    private double NumWheels;

    List<double> Wheels = new List<double> { 2, 3, 4, 6, 8 };

    ,,
    //properties

    private double _engineSize; //attribute used inside property
    public double EngineSize //fully implemented property
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

    public string Brand { get; private set; } //auto implemented property


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

    public double CalcWeight()
    {
        double weight = 0;

        double Enginesquared = Math.Pow(EngineSize, 2);

        weight = Enginesquared * GetNumWheels();

        return weight;
    }
}