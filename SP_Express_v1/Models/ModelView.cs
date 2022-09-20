using System.ComponentModel.DataAnnotations;


namespace SP_Express_v1.Models
{
    public class Agreement
    {
        [Display(Name = "Информация о компании")]
        public CompanyInfo CompanyInfo { get; set; }

        [Display(Name = "Адреса")] public Addresses Addresses { get; set; }

        [Display(Name = "Реквизиты")] public Requisites Requisites { get; set; }
    }

    public class Addresses
    {
        [Display(Name = "Фактический")] public Address FactAdr { get; set; }

        [Display(Name = "Юридический")] public Address LegalAdr { get; set; }

        [Display(Name = "Дост. счета")] public string BillDelibAdr { get; set; }

        [Display(Name = "Почтовый")] public string PostAdr { get; set; }
    }

    public class CompanyInfo
    {
        [Display(Name = "Наша компания")] public string OurCompName { get; set; }

        [Display(Name = "Номер договора")] public string AgreementNumber { get; set; }

        [Display(Name = "Имя компании")] public string CompName { get; set; }

        [Display(Name = "Официальное название")]
        public string OfficialCompName { get; set; }

        [Display(Name = "Телефон")] public string Tel { get; set; }
    }

    public class Requisites
    {
        [Display(Name = "ИНН")] public string INN { get; set; }

        [Display(Name = "КПП")] public string KPP { get; set; }

        [Display(Name = "ОКВЭД")] public string OKVED { get; set; }

        [Display(Name = "ОКАТО")] public string OKATO { get; set; }

        [Display(Name = "ОКПО")] public string OKPO { get; set; }

        [Display(Name = "ОГРН")] public string OGRN { get; set; }

        [Display(Name = "БАНК")] public string Bank { get; set; }

        [Display(Name = "БИК")] public string BIK { get; set; }

        [Display(Name = "Р/С")] public string RS { get; set; }

        [Display(Name = "К/С")] public string KS { get; set; }

        [Display(Name = "НА ОСНОВАНИИ")] public string BasedOn { get; set; }

        [Display(Name = "Номер доверенности")] public string ProxyNumber { get; set; }

        [Display(Name = "Дата от")] public string ProxyDate { get; set; }

        [Display(Name = "ГЕН. ДИРЕКТОР")] public string CEO { get; set; }

        [Display(Name = "БУХГАЛТЕР")] public string Accountant { get; set; }
    }

    public class Consignment
    {
        public Address Adr1 { get; set; }

        public Address Adr2 { get; set; }

        public ConsignmentInfo Info { get; set; }
    }

    public class ConsignmentInfo
    {
        [Display(Name = "ФИО 1")] public string FIO1 { get; set; }

        [Display(Name = "ФИО 2")] public string FIO2 { get; set; }

        [Display(Name = "Телефон 1")] public string Tel1 { get; set; }

        [Display(Name = "Телефон 2")] public string Tel2 { get; set; }

        [Display(Name = "Офис 1")] public string Office1 { get; set; }

        [Display(Name = "Офис 2")] public string Office2 { get; set; }

        [Display(Name = "Название компании 1")]
        public string CompName1 { get; set; }

        [Display(Name = "Название компании 2")]
        public string CompName2 { get; set; }

        [Display(Name = "Примечание")] public string Note { get; set; }

        [Display(Name = "Доп. информация по доставке")]
        public string DeliveryExtraInfo { get; set; }

        [Display(Name = "Описание")] public string Description { get; set; }

        [Display(Name = "Только документы")] public bool DocsOnly { get; set; }

        [Display(Name = "Места")] public int Places { get; set; }

        [Display(Name = "Вес")] public float Weight { get; set; }

        [Display(Name = "Услуга")] public string Service { get; set; }

        [Display(Name = "Время доставки с")] public int FromTime { get; set; }

        [Display(Name = "Время доставки до")] public int ToTime { get; set; }

        [Display(Name = "Объявленная стоимость")]
        public int DeclaredCost { get; set; }

        [Display(Name = "Фактическая стоимость")]
        public int ActualCost { get; set; }
    }

    public class Address
    {
        [Display(Name = "Адрес")] public string AdrName { get; set; }

        [Display(Name = "Полный адрес")] public string AdrFull { get; set; }

        [Display(Name = "ISO  код страны")] public string CountryISOCode { get; set; }

        [Display(Name = "Страна")] public string Country { get; set; }

        [Display(Name = "ISO  код региона")] public string RegionISOCode { get; set; }

        [Display(Name = "Регион")] public string Region { get; set; }

        [Display(Name = "Регион с типом")] public string RegionWithType { get; set; }

        [Display(Name = "Город")] public string City { get; set; }

        [Display(Name = "Город с типом")] public string CityWithType { get; set; }

        [Display(Name = "Маркер столицы")] public int CapitalMarker { get; set; }

        [Display(Name = "Улица")] public string Street { get; set; }

        [Display(Name = "Улица с типом")] public string StreetWithType { get; set; }

        [Display(Name = "Дом")] public string House { get; set; }

        [Display(Name = "Корпус")] public string Block { get; set; }

        [Display(Name = "Широта")] public string Lat { get; set; }

        [Display(Name = "Долгота")] public string Lon { get; set; }

        [Display(Name = "Качество данных")] public string Qc { get; set; }

        [Display(Name = "Поселение")] public string Settlement { get; set; }

        [Display(Name = "Поселение с типом")] public string SettlementWithType { get; set; }

        [Display(Name = "Почтовый индекс")] public string PostalCode { get; set; }
    }
}
