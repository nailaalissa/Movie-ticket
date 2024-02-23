using E_ticket.Data.Cart;
using E_ticket.Models;
using System.ComponentModel.DataAnnotations;

namespace E_ticket.Data.ViewModeles
{
    public class ShoppingCartVM
    {
        public ShoppingCart ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
    }
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
