using System.ComponentModel.DataAnnotations;

namespace SP_Express_v1.Models
{
    public class AdrNew
    {
        [Required]
        [Display(Name = "Адрес")]
        public string AdrName { get; set; }

        [Display(Name = "Почтовый индекс")]
        public string PostIndex { get; set; }

        [Required]
        [Display(Name = "Страна")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Заполните поле")]
        [Display(Name = "Город")]
        public string Town { get; set; }

        [Required(ErrorMessage = "Заполните поле")]
        [Display(Name = "Улица")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Заполните поле")]
        [Display(Name = "Дом, Сторение, Корпус")]
        public string House { get; set; }

        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Gc { get; set; }
        public string Region { get; set; }

        [Display(Name = "Квартира/Офис")]
        public string Flat { get; set; }

        [Display(Name = "Как найти")]
        public string Descrit { get; set; }

        [Display(Name = "Телефон")]
        public string Telefon { get; set; }

        public string RegionFull { get; set; }
    }
    
}
