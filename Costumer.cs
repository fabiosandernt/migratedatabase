using System.ComponentModel.DataAnnotations.Schema;

namespace MigrateDatabase
{
    public class Costumer
    {
        public int? Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Guid CustomerGuid { get; set; }
        public bool IsTaxExempt { get; set; } 
        public Int32 AffiliateId { get; set; }        
        public void ClearId() 
        {
            Id = null;
        }
    }
}