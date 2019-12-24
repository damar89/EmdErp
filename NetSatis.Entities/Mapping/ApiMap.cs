using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Mapping
{
   public class ApiMap: EntityTypeConfiguration<Api>
    {
           public ApiMap()
        {
            this.HasKey(p => p.Id);
            //this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.ToTable("Api");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Key).HasColumnName("Key");
            this.Property(p => p.ValidKey).HasColumnName("ValidKey");
            this.Property(p => p.IsActivate).HasColumnName("IsActivate");
        }
    }
}
