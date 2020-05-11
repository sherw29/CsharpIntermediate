using System;

namespace CSharpIntermediate
{
    public class SqlConnect : DbConnection
    {
        public override void Connect()
        {
            if (IsValid())
                Console.WriteLine("sqlConnect suceeded ");
            else
                throw Exception;
        }

        public override void Disconnect()
        {
            Console.WriteLine("disconnected");
        }
    }
}
