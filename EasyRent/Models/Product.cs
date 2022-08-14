using System.ComponentModel.DataAnnotations;

namespace EasyRent.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description {get; set; }
        public bool IsRented {get; set; }
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
        public decimal Price { get; set; }
        public string? Notes{get; set;}

        public int findId {get{return Id;}}
    }
}