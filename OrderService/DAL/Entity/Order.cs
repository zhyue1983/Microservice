using System;
using System.Collections.Generic;

#nullable disable

namespace OrderService.DAL.Entity
{
    public partial class Order : BaseEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public byte Status { get; set; }
    }
}
