using HomeworkTwentyFive.Library;

namespace HomeworkTwentyFive.ConsoleUI
{
    public class Person : Employee
    {
        public string Name { get; set; }

        public void CriteriaOne()
        {
            YearsOfExperience = 100;
        }
    }
}
