using System;

namespace CSharpIntermediate
{
    public class OracleConnect : DbConnection
    {
        public override void Connect()
        {   
            if (IsValid())
                Console.WriteLine("OracleConnect suceeded");
            else
                throw Exception;
        }

        public override void Disconnect()
        {
            Console.WriteLine("disconnected");
        }
    }
}
