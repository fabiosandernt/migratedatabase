namespace MigrateDatabase
{
    public class Program
    {
        static void Main(string[] args){
            var dataRead = ReadDataContext.Initiate();

            var customers = dataRead.Costumers.ToList();

            customers = customers.Select(x => {
                x.ClearId();
                return x;
            }).ToList();
            
            var dataWrite = WriteDataContext.Initiate();
            dataWrite.AddRange(customers);
            dataWrite.SaveChanges();
        }
    }
}