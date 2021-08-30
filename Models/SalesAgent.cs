using System.ComponentModel.DataAnnotations;

namespace Product_Sales_Commision_MVC.Models
{ //Sales agent information
    public class SalesAgent
    {
        public int Id { get; set; }
        [Required]
        public string AgentName { get; set; }

        public string ContactNumber { get; set; }
    }
}
