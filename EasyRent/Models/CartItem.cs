using System.ComponentModel.DataAnnotations;

namespace EasyRent.Models
{
    public class CartItem
    /*
    Schema for each product a user adds to their shopping cart
    */
    {
        [Key]
        public string ItemId { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public Products Product { get; set; }

    }
}