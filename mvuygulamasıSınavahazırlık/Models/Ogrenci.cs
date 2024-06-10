namespace mvuygulamasıSınavahazırlık.Models
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string ogrenciAdi { get; set; }
        public string ogrenciSoyadi { get; set; }
       public Sinif? Sinif {  get; set; }
        public int SinifId { get; set; }
    }
}
