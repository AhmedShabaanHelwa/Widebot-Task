using Core.Entities;
using Infrastructure;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Repository
{
    public class UsersRepository : GenericRepository<User>,IUsersRepository
    {
        /*
        public UsersRepository(DataContext context) : base(context)
        {
        }
        */
    }
}
