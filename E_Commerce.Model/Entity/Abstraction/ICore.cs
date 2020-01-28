using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Model.Entity.Abstraction
{
    public enum Status
    {
        None = 0,
        Active = 1,
        Passive = 2,
        Update = 3
    }
    public interface ICore
    {
        public int ID { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Status Status { get; set; }
    }
}
