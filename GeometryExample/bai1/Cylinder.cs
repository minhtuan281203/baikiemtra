using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cylinder
{
    public double Radius;
    public double Height;


    public void Result()
    {
        Console.WriteLine("Enter the dimenstion of the cylinder");
        Console.Write("Radius: ");
        double Radius = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double Height = double.Parse(Console.ReadLine());
    }
    public void Process()
    {

        Console.WriteLine("Please Enter Radius and Height again");
        double Radius = double.Parse(Console.ReadLine());
        double Height = double.Parse(Console.ReadLine());
        Console.WriteLine("Cylinder Characteristisc");
        Console.WriteLine("Radius: " + Radius + ", " + "Height: " + Height);
        double BaseArea = Radius * Radius * Math.PI;
        double LateralArea = 2 * Math.PI * Radius * Height;
        double TotalArea = 2 * Math.PI * Radius * (Height + Radius);
        double Volume = Math.PI * Radius * Radius * Height;
        Console.WriteLine("Base: {0:0.00}" + " | Latera: {1:0.00}" + " | Total: {2:0.00}" + " | Volume: {3:0.00}", BaseArea, LateralArea, TotalArea, Volume);

    }


}
