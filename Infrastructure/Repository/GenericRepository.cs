using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //!AhmedShaban: object to hold the context
        private DataContext _context = null;
        //!AhmedShaban: Table that represents the repository
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this._context = new DataContext();
            table = _context.Set<T>();
        }
        /* !AhmedShaban: Constructor to inject the DataContext dependency.
         * It originally represents the EF Core.
         */
        public GenericRepository(DataContext context)
        {
            _context = context;
            //!AhmedShaban: Associate the database table to table variable
            table = context.Set<T>();
        }
        public void Delete(object id)
        {
            //Find the ID
            T existing = GetById(id);
            //Remove it
            table.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T entity)
        {
            table.Add(entity);
        }

        public void Update(T entity)
        {
            //!AhmedShaban: Modify the the entity
            table.Attach(entity);
            //!Ahmedshaban: Update the state of the entity
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
