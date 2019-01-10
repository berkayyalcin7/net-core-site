using System;

namespace netcore.Domain.Slider
{
    public class BaseEntity
    {
        public virtual int ID {get; set;}
        public virtual int IsActive { get; set; }
        public virtual int IsDeleted { get; set; }
        public virtual DateTime CreatedDate { get; set; }
    }
}