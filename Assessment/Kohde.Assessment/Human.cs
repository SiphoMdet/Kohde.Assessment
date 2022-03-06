namespace Kohde.Assessment
{
    public class Human
    {
        public string Name;
        public int Age;
        public string Gender;

        public Human(string xName, int xAge, string xGender)
        {
            this.Name = xName;
            this.Age = xAge;
            this.Gender = xGender;
        }
        public string GetDetails()
        {
            return "Name: " + Name + " Age:" + Age + " Gender:" + Gender;
        }



    }
}