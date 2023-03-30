namespace UnitTest1
{
    internal class HerniPostava
    {
        private string name;

        public HerniPostava(string name)
        {
            this.name = name;
        }

        public object Name { get; internal set; }
    }
}