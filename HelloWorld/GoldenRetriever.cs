namespace HelloWorld
{
    internal class GoldenRetriever : Dog
    {
        public override void Sound()
        {
            Console.WriteLine("Ruff!");
        }

        public override string Breed()
        {
            return "Golden Retriever";
        }
    }
}
