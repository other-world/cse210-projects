using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");
        Fraction noinput = new Fraction();
        Console.WriteLine($"No input results, String: {noinput.GetFractionString()} Decimal: {noinput.GetDecimalValue()}");
        Fraction whole = new Fraction(5);
        Console.WriteLine($"Numerator only results, String: {whole.GetFractionString()} Decimal: {whole.GetDecimalValue()}");
        Fraction full1 = new Fraction(3, 4);
        Console.WriteLine($"Clean fraction example, String: {full1.GetFractionString()} Decimal: {full1.GetDecimalValue()}");
        Fraction full2 = new Fraction(1, 3);
        Console.WriteLine($"Ugly fraction example, String: {full2.GetFractionString()} Decimal: {full2.GetDecimalValue()}");

    }
}