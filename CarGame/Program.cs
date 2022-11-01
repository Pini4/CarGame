using CarGame;

internal class Program
{
    private static void Main(string[] args)
    {
        Vector3 vector = new Vector3(1, 2, 3);
        Car audi = new Car("Audi", vector);
        audi.KeyIn();
        audi.Start();

        audi.Move(new Vector3(0, 6, 5));
        Console.WriteLine(audi.GetInfo());
        audi.Move(new Vector3(0, 6, 5));
        Console.WriteLine(audi.GetInfo());
        audi.Move(new Vector3(0, 6, 5));
        Console.WriteLine(audi.GetInfo());
        audi.KeyOut();
        audi.Off();




    }
}