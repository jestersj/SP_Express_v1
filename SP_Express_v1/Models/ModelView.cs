using System.ComponentModel.DataAnnotations;

namespace SP_Express_v1.Models
{
    public class Address
    {
        [Required]
        [Display(Name = "Адрес")]
        public string Adress { get; set; }

        [Display(Name = "ISO  код страны")]
        public string CountryISOCode { get; set; }

        [Display(Name = "Страна")]
        public string Country { get; set; }
        
        [Display(Name = "ISO  код региона")]
        public string RegionISOCode { get; set; }
        
        [Display(Name = "Регион")]
        public string Region { get; set; }
        
        [Display(Name = "Регион с типом")]
        public string RegionWithType { get; set; }
        
        [Display(Name = "Город")]
        public string City { get; set; }
        
        [Display(Name = "Город с типом")]
        public string CitoWithType { get; set; }
        
        [Display(Name = "Маркер столицы")]
        public int CapitalMarker { get; set; }
        
        [Display(Name = "Улица")]
        public string Streat { get; set; }
        
        [Display(Name = "Улица с типом")]
        public string StreatWithType { get; set; }
        
        [Display(Name = "Дом")]
        public string House { get; set; }
        
        [Display(Name = "Корпус")]
        public string  Block { get; set; }
        
        [Display(Name = "Широта")]
        public string Lat { get; set; }
        
        [Display(Name = "Долгота")]
        public string Lon { get; set; }
        
        [Display(Name = "Почтовый индекс")]
        public string PostalCode { get; set; }
    }
    
}
