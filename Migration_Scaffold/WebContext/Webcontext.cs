using Microsoft.EntityFrameworkCore;
using Migration_Scaffold.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration_Scaffold.WebContext
{
    public class Webcontext :DbContext
    {
        private const string connectionString = "Data Source=LAPTOP-7CAHEI3Q\\HATHANHHAO;Initial Catalog=Webdb;Integrated Security=True;Encrypt=True";


        DbSet<Article> articles {  get; set; }
        DbSet<Tag> tags { get; set; }
       DbSet<ArticleTag> articleTags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ArticleTag>(etity => // đánh chỉ mục
            {
                etity.HasIndex(articleTag => new
                {
                    articleTag.ArticleId,
                    articleTag.TagId
                }).IsUnique(); //  thiết lập duy nhấtf
            });
        }
    }
}
