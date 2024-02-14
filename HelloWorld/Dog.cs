namespace HelloWorld
{
    public abstract class Dog
    {
        public abstract void Sound();

        public virtual string Breed()
        {
            return "Dog";
        }

        public int NumberOfLegs()
        {
            return 4;
        }

        public int NumberOfEyes()
        {
            return 2;
        }

        public bool HasTail()
        {
            return true;
        }
    }
}
