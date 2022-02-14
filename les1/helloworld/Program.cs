using System;

namespace helloworld
{
    class Program
    {

        private string greeting;
        private string greetWho;

        static void Main(string[] args)
        {
            Program program = new Program();

            program.SetWhoToGreet("iedereen");
            program.PrepareGreeting();

            string greeting = program.GetGreeing();
            Console.WriteLine(greeting);
        }

        private void SetWhoToGreet(string who)
        {
            greetWho = who;
        }

        private void PrepareGreeting()
        {
            greeting = "goedemorgen " + greetWho + "!";
        }

        private string GetGreeting()
        {
            return greeting;
        }
    }
}
