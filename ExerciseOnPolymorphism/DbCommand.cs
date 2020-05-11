using System;

namespace CSharpIntermediate
{
    public class DbCommand
    {
      public DbConnection DbConnectionPresent { get; set; }
      public string DbInstruction;

     public bool ConnectionIsValid()
     {
        if (DbConnectionPresent==null)
            return false;
        else
            return true;
     }
     public bool InstructionIsValid()
     {
            if (string.IsNullOrEmpty(DbInstruction))
                return false;
            else
                return true;
     }
        public void ExecuteDb()
        { 
          if(ConnectionIsValid())
            DbConnectionPresent.Connect();

          if(InstructionIsValid())  
            Console.WriteLine("executing database instruction: " + DbInstruction);
            
            DbConnectionPresent.Disconnect();
        }
    }
}
