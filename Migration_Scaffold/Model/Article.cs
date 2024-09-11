using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration_Scaffold.Model
{
    [Table("Article")]
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        public int MyProperty { get; set; }
    }
}
