using System;

public abstract class Figura
{
    public abstract double CalcularArea();
}

public class Circulo : Figura
{
    public double Radio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    public static void Main(string[] args)
    {
        Circulo circulo = new Circulo { Radio = 5 };
        double areaCirculo = circulo.CalcularArea();
        Console.WriteLine("Área del círculo: " + areaCirculo);
    }
}

public class Rectangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public override double CalcularArea()
    {
        return Base * Altura;
    }

    public static void Main(string[] args)
    {
        Rectangulo rectangulo = new Rectangulo { Base = 4, Altura = 6 };
        double areaRectangulo = rectangulo.CalcularArea();
        Console.WriteLine("Área del rectángulo: " + areaRectangulo);
    }
}
