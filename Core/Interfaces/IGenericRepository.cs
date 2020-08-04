using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    /* !AhmedShaban: An Interface for operations of Repository Pattern.
     * The interface is generic to accept different types of models
     * Recall that the Repository
     */
    public interface IGenericRepository<T> where T : class
    {
        //Operation 1: Retrieving All data of a certain type
        IEnumerable<T> GetAll();
        //Operation 2: Single-element retrieving. Generalized to return an object of object
        T GetById(object id);
        //Operation 3: Insertion operation
        void Insert(T entity);
        //Operation 4: Update a particular operation
        void Update(T entity);
        //Operation 5: Delete an Element. Id of the element is required
        void Delete(object id);
        //Operation 6: Save the operations. Best practice is to be in Unit of Work DP
        void Save();
    }
}
