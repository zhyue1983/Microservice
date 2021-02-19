using System;
using System.Collections.Generic;

#nullable disable

namespace UserService.DAL.Entity
{
    public partial class User : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public byte Status { get; set; }
    }
}
