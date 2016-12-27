using FMAA.Web.Api.Models.Return;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMAA.BLL.Interfaces
{
    public interface IPlayers
    {
        IEnumerable<PlayerModel> GetAll();
    }
}
