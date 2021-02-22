using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
  public  class DebitDetailDto: IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Status { get; set; }
        public string ProcessType { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string Description { get; set; }



    }
}
