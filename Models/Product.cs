using System.ComponentModel.DataAnnotations;

namespace FormApp.Models
{
    public class Product
    {
        [Display(Name="Id")]
        public int ProductId { get; set; }


         [Display(Name="İsim")]
         [Required(ErrorMessage ="Bir isim giriniz")]
        public string? Name { get; set; }

        
         [Display(Name="Fiyat")]
         [Required(ErrorMessage ="Fiyat Bilgisi Giriniz..")]
         [Range(0,150000)]
        public decimal? Price { get; set; }

        [Required(ErrorMessage ="Bir resim yükleyiniz..")]
        [Display(Name="Resim")]
        public string? Image { get; set; }

        
        [Display(Name="Mevcutluk")]
        public bool IsActive { get; set; }
         
         [Required(ErrorMessage ="Bir kategori seçiniz..")]

        public int? CategoryId { get; set; }

    }
    
}