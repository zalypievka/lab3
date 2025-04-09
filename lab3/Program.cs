class Triangle
{
    public double a, b, c;
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public double Perimeter()
    {
        return a + b + c;
    }
    public double Area()
    {
        double p = Perimeter() / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    public void DisplayAll()
    {
        Console.WriteLine($"Сторони: {a}, {b}, {c}");
        Console.WriteLine($"Периметр: {Perimeter():F2}");
        Console.WriteLine($"Площа: {Area():F2}");
    }
}
class Banknote
{
    public int denomination;
    public int quantity;

    public Banknote(int denomination, int quantity)
    {
        this.denomination = denomination;
        this.quantity = quantity;
    }

    public string GetInfo()
    {
        return $"Купюра номіналом {denomination} грн у кількості {quantity} шт.";
    }

    public int CalculateTotal()
    {
        return denomination * quantity;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Індивідуальне завдання №1 ===");
        Console.Write("Введіть сторону a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть сторону b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введіть сторону c: ");
        double c = double.Parse(Console.ReadLine());
        Triangle triangle = new Triangle(a, b, c);
        triangle.DisplayAll();

        Console.WriteLine("\n=== Індивідуальне завдання №2 ===");
        Console.Write("Введіть номінал купюри (наприклад, 1, 5, 10): ");
        int denom = int.Parse(Console.ReadLine());
        Console.Write("Введіть кількість купюр: ");
        int qty = int.Parse(Console.ReadLine());

        Banknote note = new Banknote(denom, qty);
        Console.WriteLine(note.GetInfo());
        Console.WriteLine($"Загальна сума: {note.CalculateTotal()} грн");
    }
}