using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Product :IEntity
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string BrandName { get; set; }

        public string Model { get; set; }

        public string Properties { get; set; }
    }
}
