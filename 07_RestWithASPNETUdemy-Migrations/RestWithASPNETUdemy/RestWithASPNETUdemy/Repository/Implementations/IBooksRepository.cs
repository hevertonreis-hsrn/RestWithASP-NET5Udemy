using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository.Implementations
{
    public interface IBooksRepository
    {
        Books Create(Books books);
        Books FindById(long id);
        List<Books> FindAll();
        Books Update(Books books);
        void Delete(long id);
        bool Exists(long id);
    }
}
