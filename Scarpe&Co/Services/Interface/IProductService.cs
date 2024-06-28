using Scarpe_Co.Entities;
namespace Scarpe_Co.Services.Interface
{
    public interface IProductService
    {
        IEnumerable<Prodotto> GetAll();
        Prodotto GetProductById(int id);
        void Add(Prodotto product);
        void Update(Prodotto product);
        void Delete(int id);
    }
}
