using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMAA.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IPlayerRepository PlayerRepository { get; set; }

        void SaveChanges(object o);
        void SaveOrUpdateChanges(object o);
    }
}
