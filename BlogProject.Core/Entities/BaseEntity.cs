using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Guid CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid DeletedBy { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
