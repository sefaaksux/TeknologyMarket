using System.ComponentModel.DataAnnotations;

namespace FormApp.Models
{
    public class Product
    {
        [Display(Name="Id")]
        public int ProductId { get; set; }
         [Display(Name="Resim")]
        public string? Image { get; set; }
         [Display(Name="İsim")]
        public string? Name { get; set; }
         [Display(Name="Fiyat")]
        public decimal Price { get; set; }
         [Display(Name="Mevcutluk")]
        public bool IsActive { get; set; }
         
        public int CategoryId { get; set; }

    }
    
}