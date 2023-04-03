SquareEquation square = new SquareEquation();
Console.WriteLine("Введите коээфициенты a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коээфициенты b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коээфициенты c");
double c = Convert.ToDouble(Console.ReadLine());
square.SetCoefficients(a,b,c);
square.CalculateRoots();

Console.ReadKey(true);







class SquareEquation {
    private double a, b, c, D, x1, x2;
    public  void SetCoefficients( double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public void CalculateRoots()
    {
        this.D = Discriminant(a, b, c);
        Console.WriteLine($"{D}");
        if ( D< 0)
        {
            Console.WriteLine("Корней нет");
        }
        if (D == 0)
        {
            Console.WriteLine($"  Корень уравнения{ (-b)/(2*a) }");
        }
        if (D> 0)
        {
            x1 = (-b+Math.Sqrt(D))/(2*a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine($"x1 = {x1} \n x2 = {x2}");
        }
    }
    private double Discriminant(double a, double b, double c)
    {
        D = b * b - 4 * a * c;
        return D;
    }

}