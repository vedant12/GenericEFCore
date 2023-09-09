using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
    public class BaseModel
    {
        public BaseModel()
        {
            CreatedOn = DateTimeOffset.UtcNow;
        }

        private DateTimeOffset createdOn { get; set; }
        public DateTimeOffset CreatedOn
        {
            get
            {
                return this.createdOn;
            }
            set
            {
                this.createdOn = value;
                this.ModifiedOn = value;
            }
        }

        public string CreatedBy { get; set; }

        public DateTimeOffset ModifiedOn { get; set; }

        public string ModifiedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}
