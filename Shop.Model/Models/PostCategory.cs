using Shop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("PostCategories")]
    public abstract class PostCategory: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(256)]
        public string Alias { get; set; }
        public int? ParentID { get; set; }
        [MaxLength(256)]
        public string Image { get; set; }
        public int? DisplayOrder { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        public bool? HotFlag { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
        
    }
}
