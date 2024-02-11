using BlogProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entity.Entities
{
    public class Image: BaseEntity
    {
        public string FileType { get; set; }
        public string FileName { get; set; }
        public ICollection<Article> Articles { get; set; }    
    }
}
