﻿using System.ComponentModel.DataAnnotations;

namespace WebBook.Models
{
    public class Order : Common
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quantity { get; set; }
        public bool PaymentMethod { get; set; }
        public bool IsPay { get; set; } = false;
        public int Status { get; set; }
        //public string OrderType { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
