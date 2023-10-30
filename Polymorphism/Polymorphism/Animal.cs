using System.Threading.Channels;

namespace Polymorphism;

internal abstract class Animal
{
    public abstract void Eat();
    public virtual void Grow()
    {
        Console.WriteLine("Grew");
    }
    public virtual void Test()
    {
        Console.WriteLine("Salam");
    }
}
internal abstract class Fish : Animal
{
    public void Swim()
    {
        Console.WriteLine("Swam");
    }
}
internal abstract class Bird : Animal
{
    public float WingHeight { get; set; }
}
internal class Parrot : Bird, IFly
{
    public override void Test()
    {
        Console.WriteLine("Aleykum");
    } 
    public override void Eat()
    {
        Console.WriteLine("Ate as parrot");
    }

    public override void Grow()
    {
        Console.WriteLine("3x faster growing");
    }

    public void Talk()
    {
        Console.WriteLine("Talked");
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }
}
internal class Ostrich : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Ate as Ostrich");
    }
    public void Run()
    {
        Console.WriteLine("Mig mig");
    }
}
internal class ClownFish : Fish
{
    public override void Eat()
    {
        Console.WriteLine("Ate as ClownFish");
    }

    public void GetLose()
    {
        Console.WriteLine("Where am i?");
    }
}
internal class Shark : Fish
{
    public override void Eat()
    {
        Console.WriteLine("Ate as Shark");
    }
}