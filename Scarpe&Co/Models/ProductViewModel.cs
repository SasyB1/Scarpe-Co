using System.ComponentModel.DataAnnotations;

namespace Scarpe_Co.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome"), Required]
        public string Nome { get; set; }

        [Display(Name = "Descrizione"), Required]
        public string Descrizione { get; set; }

        [Display(Name = "Prezzo"), Required]
        public decimal Prezzo { get; set; }

        [Display(Name = "Immagine "), Required]
        public IFormFile Immagine { get; set; }

        [Display(Name = "Immagine aggiuntiva "), Required]
        public IFormFile Immagine1 { get; set; }

        [Display(Name = "Immagine ulteriore"), Required]
        public IFormFile Immagine2 { get; set; }
    }
}
