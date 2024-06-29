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
                Descrizione = "Scopri il massimo comfort e stile con le Salomon XT-6 LTR Cord Wren, perfette per l'uomo attivo." +
                " Queste scarpe da ginnastica combinano un design elegante con una costruzione robusta, ideali per affrontare" +
                " qualsiasi avventura urbana o naturale.",
                Prezzo = 114,
                Immagine = "https://static.flexdog.it/flexdog-7/products/images/069c6138-2f79-4c34-a4a9-834778632846_instyle_ai.jpg?width=375&quality=90",
                Immagine1 = "https://cdn.afew-store.com/assets/40/406723/1200/salomon-xt-6-expanse-ltr-bungee-cord-wren-almond-milk-l47294900-footwear%20%3E%20sneaker-packshots-150.jpg",
                Immagine2 = "https://www.mrporter.com/variants/images/1647597316585346/ou/w2000_q60.jpg"
            },
            new Prodotto
            {
                Id = 2,
                Nome = "New Balance U9060PB",
                Descrizione = "Le New Balance U9060PB sono scarpe da corsa per uomo che offrono un perfetto equilibrio tra comfort e prestazioni." +
                " Con il loro design innovativo e il supporto ottimale, queste scarpe ti accompagneranno in ogni tua sfida sportiva.",
                Prezzo = 158,
                Immagine = "https://static.flexdog.it/flexdog-8/products/images/a03bdb21-0428-46ca-9f6f-5eebd9991d6a_instyle_ai.jpeg?width=375&quality=90",
                Immagine1 = "https://www.loggishop.com/cdn/shop/products/47768_1400x.jpg?v=1709313629",
                Immagine2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAUTkJ3pA-FmMODM_Gx29ZIaqdQ_8qt4_Klw&s"
            },
            new Prodotto
            {
                Id = 3,
                Nome = "adidas Originals Campus 00s",
                Descrizione = "Affronta i sentieri con stile con le adidas Originals Campus 00s. Queste scarpe da trekking per uomo combinano durata e comfort," +
                " permettendoti di esplorare nuovi percorsi con fiducia e stile.",
                Prezzo = 137,
                Immagine = "https://static.flexdog.it/flexdog-f/products/images/7a73d579-980f-4707-bd26-1d2e776bc970_instyle_ai.jpeg?width=375&quality=90",
                Immagine1 = "https://images.asos-media.com/products/adidas-originals-campus-00-sneakers-bianche-e-nere/203978808-1-white?$n_640w$&wid=513&fit=constrain",
                Immagine2 = "https://i.ebayimg.com/images/g/BvgAAOSwSoVk3eyV/s-l1200.jpg"
            },

             new Prodotto
            {
                Id = 4,
                Nome = "Gel Kayano Legacy Pure Silver",
                Descrizione = "Con un look audace e moderno, le Gel Kayano Legacy Pure Silver sono perfette per l'uomo che ama distinguersi. Ideali per una passeggiata in città o un'uscita serale," +
                 " queste scarpe combinano comfort e stile unico.",
                Prezzo = 115,
                Immagine = "https://static.flexdog.it/flexdog-a/products/images/f8b171d4-9073-4aac-90d3-913af264cafa_instyle_ai.png?width=375&quality=90",
                Immagine1 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT4kCM0f1AgPyS9vU3znBJgGrZGdp3Sg_pmXg&s",
                Immagine2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHnaSB1KIAuXHruJIQkI6m6XMQeZhIKCx_eClyhK6F7bD0h-DmbWpT7XbxMSbqLUjLACc&usqp=CAU"
            },
              new Prodotto
            {
                Id = 5,
                Nome = "P-6000 Metallic Silver",
                Descrizione = " Le P-6000 Metallic Silver sono scarpe da maranzina per donna che combinano un design futuristico con un comfort eccellente. Perfette per aggiungere un tocco" +
                  " di brillantezza al tuo guardaroba quotidiano.",
                Prezzo = 57,
                Immagine = "https://static.flexdog.it/flexdog-f/products/images/2229172e-a86b-464e-b545-5e05c32f5cf1_instyle_ai.png?width=375&quality=90",
                Immagine1 = "https://static.ftshp.digital/img/p/2/2/6/5/5/1/226551.jpg",
                Immagine2 = "https://www.snipes.it/dw/image/v2/BDCB_PRD/on/demandware.static/-/Sites-snse-master-eu/default/dwadd6f11c/2280997_P6.jpg?sw=450&sh=450&sm=fit&sfrm=png"
            },
               new Prodotto
            {
                Id = 6,
                Nome = "Dunk Low LX Gorge Green W",
                Descrizione = "Perfette per la musicista in carriera, le Dunk Low LX Gorge Green W offrono uno stile inconfondibile e un comfort eccezionale. Queste scarpe ti accompagnano" +
                   " dalla sala prove al palco, con un look che cattura l'attenzione.",
                Prezzo = 88,
                Immagine = "https://static.flexdog.it/flexdog-1/products/images/988565ad-3d0c-4118-ad91-a0e817533ca8.png?width=375&quality=90",
                Immagine1 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRx_GSQ7hhfD4AU0-th0O6z_Cq1z_wnjBb4yw&s",
                Immagine2 = "https://static.ftshp.digital/img/p/1/0/8/4/9/5/7/1084957-full_product.jpg"
            },
              new Prodotto
            {
                Id = 7,
                Nome = "Gazelle Indoor Bliss Pink Purple",
                Descrizione = "Le Gazelle Indoor Bliss Pink Purple sono scarpe da donna per chi ama osare con gusti particolari. Queste scarpe combinano un design audace con un comfort duraturo," +
                  " perfette per chi non teme di distinguersi.",
                Prezzo = 25,
                Immagine = "https://static.flexdog.it/flexdog-a/products/images/6ad92338-fad2-4f51-86a9-ea41ee92b776_instyle_ai.jpeg?width=375&quality=90",
                Immagine1 = "https://i.ebayimg.com/images/g/QjkAAOSwZItkrxx0/s-l400.jpg",
                Immagine2 = "https://www.sneakerhype.eu/cdn/shop/files/Shopifyproductfoto_s_17a583cd-99cd-48fa-aeed-649c4a159ba0.png?v=1712649580"
            },
                new Prodotto
            {
                Id = 8,
                Nome = "Air Force 1 '07 Triple White",
                Descrizione = "Le iconiche Air Force 1 '07 Triple White sono le scarpe del Sium, simbolo di stile senza tempo e versatilità. Con il loro design pulito e raffinato, sono perfette per qualsiasi occasione," +
                    " dal casual all'elegante.",
                Prezzo = 457,
                Immagine = "https://static.flexdog.it/flexdog-d/products/images/1e77f94e-69fd-461b-aeec-991614c427e2_instyle_ai.jpeg?width=375&quality=90",
                Immagine1 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwFUech5sKcCtX-VNkX7R7VUdM0AChTLwqBg&s",
                Immagine2 = "https://i.ebayimg.com/images/g/OgAAAOSwU~xjH6K~/s-l400.jpg"
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
