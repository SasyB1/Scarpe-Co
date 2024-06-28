using Scarpe_Co.Services.Interface;
using Scarpe_Co.Entities;
namespace Scarpe_Co.Services
{
    public class ProductService : IProductService
    {
        private static List<Prodotto> products = new List<Prodotto>
        {
            new Prodotto
            {
                Id = 1,
                Nome = "Salomon XT-6 LTR Cord Wren",
                Descrizione = "Scarpe da ginnastica per uomo",
                Prezzo = 114,
                Immagine = "https://www.sotf.com/upload/articoli/thumbs/SWIMSHORT-TITANIUM-SOTF_70993_thumb.jpg",
                Immagine1 = "https://www.sotf.com/upload/articoli/thumbs/SWIMSHORT-TITANIUM-SOTF_70993_thumb.jpg",
                Immagine2 = "https://www.sotf.com/upload/articoli/thumbs/SWIMSHORT-TITANIUM-SOTF_70993_thumb.jpg"
            },
            new Prodotto
            {
                Id = 2,
                Nome = "New Balance U9060PB",
                Descrizione = "Scarpe da corsa per uomo",
                Prezzo = 158,
                Immagine = "scarpe-corsa.jpg",
                Immagine1 = "scarpe-corsa1.jpg",
                Immagine2 = "scarpe-corsa2.jpg"
            },
            new Prodotto
            {
                Id = 3,
                Nome = "adidas Originals Campus 00s",
                Descrizione = "Scarpe da trekking per uomo",
                Prezzo = 97,
                Immagine = "scarpe-trekking.jpg",
                Immagine1 = "scarpe-trekking1.jpg",
                Immagine2 = "scarpe-trekking2.jpg"
            }
        };

        public IEnumerable<Prodotto> GetAll() => products;

        public Prodotto GetProductById(int id) => products.FirstOrDefault(p => p.Id == id);

        public void Add(Prodotto product)
        {
            var lastId = products.Select(p => p.Id).DefaultIfEmpty(0).Max();
            product.Id = lastId + 1;
            products.Add(product);
        }
        public void Update(Prodotto product)
        {
            var ProdottoTargettato = GetProductById(product.Id);
            if (ProdottoTargettato != null)          
            ProdottoTargettato.Nome = product.Nome;
            ProdottoTargettato.Descrizione = product.Descrizione;
            ProdottoTargettato.Prezzo = product.Prezzo;
            ProdottoTargettato.Immagine = product.Immagine;
            ProdottoTargettato.Immagine1 = product.Immagine1;
            ProdottoTargettato.Immagine2 = product.Immagine2;
        }

        public void Delete(int id)
        {
            var product = GetProductById(id);
            if (product != null)
                products.Remove(product);
        }

        
    }
}
