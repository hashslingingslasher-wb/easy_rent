using System.ComponentModel.DataAnnotations;
namespace EasyRent.Models
{
    public class Products
    //Defines the attributes for each rental product available for rental stored in the database
    /*
    Controller: ProductsController
    DB Context: ProductsContext
    */

    {
        public int Id{ get; set; }
        public string? Name { get; set; }
        public string? Description {get; set;}
        public string? ImageURL {get; set;}
        public bool isRented {get; set;}
        [DataType(DataType.Date)]
        public DateTime LastDateRented {get; set;}

    }
}