namespace HelloWorld
{
    public abstract class Dog
    {
        private int _legs { get; set; }
        public abstract void Sound();

        public virtual string Breed()
        {
            return "Dog";
        }

        public int Legs
        {
            get { return _legs; }
            set { _legs = value; }
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
