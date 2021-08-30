using System.ComponentModel.DataAnnotations;

namespace Product_Sales_Commision_MVC.Models
{ //Manufacturer information 
    public class Manufacturer
    {
        public int Id { get; set; }
        [Required]
        public string BusinessName { get; set; }

        public string Email { get; set; }

    }
}
