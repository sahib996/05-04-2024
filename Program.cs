namespace Abstarct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parrot b = new Parrot();
            Shark akula = new Shark();
            Eagle eagle = new Eagle();
            Animal[] animals = {b, akula, eagle };
            Bird[] birds = {b, , eagle};
            /*b.Eat();
            akula.Eat();
            eagle.Fly();*/
            foreach(var animal in animals)
            {
                bird.Fly();
            }

        }
    }
}
