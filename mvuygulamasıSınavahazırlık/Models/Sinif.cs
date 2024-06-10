namespace mvuygulamasıSınavahazırlık.Models
{
    public class Sinif
    {
        public int SinifId { get; set; }
        public string SinifAdi { get; set; }
        public string SinifKodu { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
