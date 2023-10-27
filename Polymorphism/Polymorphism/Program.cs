namespace Polymorphism;

internal class Program
{
    static void Main(string[] args)
    {
        //ClownFish nemo = new ClownFish();
        //Shark sh = ;
        //Ostrich meeg = ;
        //Parrot ro = ;
        //nemo.Eat();
        //Animal nemo = new ClownFish();
        //Animal[] zoopark = { new Shark(), nemo, new Ostrich(), new Parrot() };

        //foreach (var animal in zoopark)
        //{
        //    //cast
        //    if (animal is Ostrich)
        //    {
        //        Ostrich o = (Ostrich) animal;
        //        o.Fly();
        //    }
        //    else if (animal is Parrot p)
        //    {
        //        p.Talk();
        //    }
        //    else if (animal as Shark != null)
        //    {
        //        (animal as Shark).Swim();
        //    }
        //var shCast = (Shark)animal;
        //Console.WriteLine(shCast);
        ////var sh = animal as Shark;
        ////sh.Swim();
        //Console.WriteLine(sh);
        //}


        IStorage storage = new LocalStorage();


        storage.Save("imgs/vuqar.jpg");

    }
}