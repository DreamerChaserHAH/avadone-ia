using Avadone_ia.Application.Common.Interfaces.Persistence;
using Avadone_ia.Domain;
using System.Linq.Expressions;

namespace Avadone_ia.Infrastructure.Persistence;

public class TodoRepository : ITodoRepository
{
    public void Add(ToDo entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(ToDo entity)
    {
        throw new NotImplementedException();
    }

    public bool Find(Expression<Func<ToDo, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IList<ToDo> GetAll()
    {
        throw new NotImplementedException();
    }

    public ToDo GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(ToDo entity)
    {
        throw new NotImplementedException();
    }
}
