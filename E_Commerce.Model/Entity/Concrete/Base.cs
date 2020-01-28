using E_Commerce.Model.Entity.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_Commerce.Model.Entity.Concrete
{
    public class Base : ICore
    {
        [Key]
        public int ID { get ; set ; }
        private DateTime _addedDate = DateTime.Now;
        public DateTime AddedDate { get { return _addedDate; } set { _addedDate = value; } }
        public DateTime? DeletedDate { get ; set ; }
        public DateTime? UpdatedDate { get ; set ; }
        private Status _status = Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }
    }
}
