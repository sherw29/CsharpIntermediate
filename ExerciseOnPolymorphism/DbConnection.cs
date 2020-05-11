using System;

namespace CSharpIntermediate
{
    public abstract class DbConnection
    {
        public string conncetionString { get; set; }
        TimeSpan Timeout = new TimeSpan(0, 0, 15); //15 second timeout
        public Exception Exception = new Exception("connection string missing");
        public abstract void Connect();
        public abstract void Disconnect();

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(conncetionString))
                return false;
            else
                return true;
        }

        

        
    }
}
