using System;

namespace Store.Application.DTOs
{
    public class OrderDTO
    {
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public int Mount { get; set; }
    }
}
