using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration_Scaffold.Model
{
    public class Tag
    {
        [Key]
        //[StringLength(20)]
        //public string TagId { get; set; }
        public int TagId { get; set; }
        [Column(TypeName ="ntext")]
        public string Context { get; set; }


   
    }
}
