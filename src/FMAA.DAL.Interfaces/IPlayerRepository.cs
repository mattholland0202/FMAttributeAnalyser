using FMAA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMAA.DAL.Interfaces
{
    public interface IPlayerRepository
    {
        void Add(Player player);

        IEnumerable<Player> GetAll();
    }
}
