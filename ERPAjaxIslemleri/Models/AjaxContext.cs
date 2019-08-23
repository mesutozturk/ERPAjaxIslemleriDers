using System.Data.Entity;

namespace ERPAjaxIslemleri.Models
{
    public class AjaxContext : DbContext
    {
        public AjaxContext() :
            base("name=DbCon")
        {
        }

        public virtual DbSet<Kisi> Kisiler { get; set; }
    }
}