using System;

namespace HomeworkTwentyFive.Library
{
    public class Profession
    {
        public string Industry { get; set; }
        private decimal Salary { get; set; }
        protected string MagicWord { get; set; }
        internal string Mission { get; set; }
        private protected string Vision { get; set; }

        public void Saying()
        {
            Vision = "Bright Future";
            Salary = 100;
            MagicWord = "Open Kisame";

            Console.WriteLine(Mission);
            Console.WriteLine("Time is Gold.");
        }
    }
}
