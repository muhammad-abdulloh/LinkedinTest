using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.Domain.Entities.BaseModels
{
    public class BaseModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsDeleted { get; set; } = false;

        public DateTimeOffset CreateDate { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset DeletedDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
