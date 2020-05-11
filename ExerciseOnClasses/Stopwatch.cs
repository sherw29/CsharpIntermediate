using System;

namespace CSharpIntermediate
{
    class Stopwatch
    {
        string input = "";
        string previousInput = "";
        DateTime startTime = new DateTime();
        DateTime stopTime = new DateTime();
        TimeSpan duration = new TimeSpan();
        public void Start()
        {
            this.startTime = DateTime.Now;
        }

        public void Stop()
        {
            this.stopTime = DateTime.Now;

        }

        public TimeSpan Duration()
        {
            duration = stopTime - startTime;
            return duration;
        }

        public void StopwatchExecute()
        {
            while (this.input != "exit")
            {
                this.input = Console.ReadLine();
                if (this.input == "start" & this.previousInput != "start")
                {
                    Start();
                    this.previousInput = this.input;
                    Console.WriteLine( "stopwatch has started ");
                }

                else if (this.input == "start" & previousInput == "start")
                    Console.WriteLine( "stopwatch is already running");
                else if (input == "stop" & previousInput == "start")
                {
                    Stop();
                    Duration();
                    this.previousInput = this.input;
                    Console.WriteLine("duration is :" + Duration().Minutes + " minutes and " + Duration().Seconds + " seconds");

                }
                else if (this.input == "stop" & previousInput == "stop")
                    Console.WriteLine("You need to start the stopwatch before stopping it"); 
                else if (this.input == "exit")
                    Console.WriteLine("ok");
                else
                    Console.WriteLine("invalid command");
            }

        }

    }
}
