using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Debit:IEntity
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int PersonalId { get; set; }

        public string Status { get; set; }

        public string ProcessType { get; set; }

        public DateTime? ProcessDate { get; set; }

        public string Description { get; set; }
    }
}
