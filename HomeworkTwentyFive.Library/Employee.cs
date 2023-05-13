using System;

namespace HomeworkTwentyFive.Library
{
    public class Employee : Profession
    {
        protected internal int YearsOfExperience { get; set; }
        public string JobTitle { get; set; }

        public void FavoriteTask()
        {
            YearsOfExperience = 200;
            MagicWord = "Just Do It";
            Mission = "Easy to use software.";
            Vision = "Building the Future.";
            
            Console.WriteLine("Programming");
        }
    }
}
