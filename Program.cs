using System;


namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {   
            //exercise on classes #1
            Console.WriteLine("exercise on classes #1");
            Console.WriteLine("Enter Start to start the stopwatch");
            Console.WriteLine("Enter stop to stop the stopwatch");
            Console.WriteLine("Enter exit to exit the program");
            var stopwatch = new Stopwatch();
            stopwatch.StopwatchExecute();
            Console.Clear();   

            //exercise on classes #2
            
            Console.WriteLine("exercise on classes #2");
            var newPost = new Post();
            newPost.PostExecute();
            Console.WriteLine();

            //exercise on Polymorphism #1 database connection
            
            var sqlConnection = new SqlConnect();
            sqlConnection.conncetionString = "www.sqldatabase.com";
            sqlConnection.Connect();
            Console.WriteLine();
            var oracleConnection = new OracleConnect();
            oracleConnection.conncetionString = "www.oracledatabase.com";
            oracleConnection.Connect();
            Console.WriteLine();

            //  #2 database commands

            var command = new DbCommand();
            command.DbConnectionPresent = new SqlConnect();
            command.DbConnectionPresent.conncetionString = "www.sqldatabase.com";
            command.DbInstruction = "scan database";
            command.ExecuteDb();
            Console.WriteLine();

            // exercise on inheritance #1 stack
            var myStack = new Stack();
            
            myStack.Push("hi");
            myStack.Push("Sherwin");
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            Console.WriteLine();
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine();
            Console.WriteLine("final stack is");
            myStack.Display_Stack();
            


        }
    }
}
