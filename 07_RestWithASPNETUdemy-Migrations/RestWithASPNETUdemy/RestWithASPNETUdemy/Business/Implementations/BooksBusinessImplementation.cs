using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository.Implementations;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class BooksBusinessImplementation : IBooksBusiness
    {
        private readonly IBooksRepository _repository;

        public BooksBusinessImplementation(IBooksRepository repository)
        {
            _repository = repository;
        }

        public List<Books> FindAll()
        {
            return _repository.FindAll();
        }

        public Books FindByID(long id)
        {
            return _repository.FindById(id);
        }

        public Books Create(Books books)
        {
            return _repository.Create(books);
        }
        
        public Books Update(Books books)
        {
            return _repository.Update(books);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
