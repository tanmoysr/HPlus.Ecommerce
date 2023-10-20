using System.Collections.Generic;

namespace HPlus.Ecommerce.Data.Entities
{
    public partial class Cart
    {
        public Cart()
        {
            CartProducts = new HashSet<CartProduct>();
        }

        public int CartId { get; set; }

        public int? CustomerId { get; set; }

        public virtual ICollection<CartProduct> CartProducts { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
