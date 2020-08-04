using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Repository
{
    /* !AhmedShaban: Interface of Users repository, derived from IGenericRepository */
    public interface IUsersRepository: IGenericRepository<User>
    {

    }
}
