namespace HPlus.Ecommerce.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        public Customer()
        {
            Carts = new HashSet<Cart>();
            Users = new HashSet<User>();
        }

        public int CustomerID { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(100)]
        public string Address1 { get; set; }

        [Required]
        [StringLength(100)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [StringLength(5)]
        public string ZIPCode { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
