namespace Task_002
{
    public class Buyer
    {
        public string Name { get; set; }

        public Buyer(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}