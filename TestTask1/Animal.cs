
namespace TestTask1;

public abstract class Animal
{
    public string Color { get; set; }
    public double Weight { get; set; }
    public int Growth { get; set; }

    public Animal(string color, double weight, int growth)
    {
        Color = color;
        Weight = weight;
        Growth = growth;
    }

    public abstract void Move();

    public abstract void SoundProduction();
    public void OffSpring()
    {
        Console.WriteLine("Я размножаюсь");
    }
}

public class Birds : Animal
{
    public double Wingspan { get; set; }
    public Birds(string color, double weight, int growth, double wingspan) : base(color, weight, growth)
    {
        Wingspan = wingspan;
    }

    public override void Move()
    {
        Console.WriteLine("Я летаю");
    }

    public override void SoundProduction()
    { }
}

public class Mammals : Animal
{
    public Mammals(string color, double weight, int growth) : base(color, weight, growth)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Я бегаю");
    }

    public override void SoundProduction()
    {
    }
}

public class Fish : Animal
{
    public Fish(string color, double weight, int growth) : base(color, weight, growth)
    {
    }

    public override void SoundProduction()
    {
        Console.WriteLine("Я издаю звуки, но очень тихо");
    }

    public override void Move()
    {
        Console.WriteLine("Я плаваю");
    }
}

public class Insects : Animal
{
    public int NumberOfPairsOfWings { get; set; }

    public Insects(string color, double weight, int growth, int numberOfPairsOfWings) : base(color, weight, growth)
    {
        NumberOfPairsOfWings = numberOfPairsOfWings;
    }

    public override void Move(){ }
    public override void SoundProduction(){ }
}

public sealed class Mosquito : Insects
{
    public Mosquito(string color, double weight, int growth, int numberOfPairsOfWings) : base(color, weight, growth, numberOfPairsOfWings)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Я летаю");
    }

    public override void SoundProduction()
    {
        Console.WriteLine("Я жужжу");
    }
}

public sealed class Butterfly : Insects
{
    public Butterfly(string color, double weight, int growth, int numberOfPairsOfWings) : base(color, weight, growth, numberOfPairsOfWings)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Я летаю");
    }

    public override void SoundProduction()
    {
        Console.WriteLine("Я не издаю звуков");
    }
}

public sealed class Dog : Mammals
{
    public Dog(string color, double weight, int growth) : base(color, weight, growth)
    {
    }

    public override void SoundProduction()
    {
        Console.WriteLine("Я лаю");
    }
}

public sealed class Cat : Mammals
{
    public Cat(string color, double weight, int growth) : base(color, weight, growth)
    {
    }

    public override void SoundProduction()
    {
        Console.WriteLine("Я мяукаю");
    }
}

public sealed class Duck : Birds
{
    public Duck(string color, double weight, int growth, double wingspan) : base(color, weight, growth, wingspan)
    {
    }

    public override void SoundProduction()
    {
        Console.WriteLine("Я крякаю");
    }
}

public sealed class Chicken : Birds
{
    public Chicken(string color, double weight, int growth, double wingspan) : base(color, weight, growth, wingspan)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Я хожу, а не летаю");
    }

    public override void SoundProduction()
    {
        Console.WriteLine("Кудах");
    }
}

