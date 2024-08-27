using Crud_MVC.Models;

namespace Crud_MVC.IRepository;

public interface ICategoryRepository :IRepository<Category>
{
    List<Product> GetProducts(int CategoryId);
    List<Product> Search(int CategoryId, string SearchTerm);
}
