namespace Kohde.Assessment
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Food { get; set; }

        public Cat(string xName, int xAge, string xFood)
        {
            this.Name = xName;
            this.Age = xAge;
            this.Food = xFood;
        }
        public string GetDetails()
        {
            return "Name: " + Name + " Age:" + Age + " Food:" + Food;
        }
    }
}