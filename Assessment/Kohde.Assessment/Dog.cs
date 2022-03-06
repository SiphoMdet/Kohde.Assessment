namespace Kohde.Assessment
{
    public class Dog
    {
        public string Name;
        public int Age;
        public string Food;

        public Dog(string xName, int xAge, string xFood)
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