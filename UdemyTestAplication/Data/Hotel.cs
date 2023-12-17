using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyTestAplication.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adrees { get; set; }

        public string  Descreption { get; set; }
        public double Rating { get; set; }
        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }

        public Country country { get; set; }
    }
}
