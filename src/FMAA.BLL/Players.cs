using FMAA.BLL.Interfaces;
using FMAA.Web.Api.Models.Return;
using System.Collections.Generic;
using System.Linq;

namespace FMAA.BLL
{
    public class Players : AbstractBase, IPlayers
    {
        public Players(BLL bll) : base(bll)
        {
        }

        public IEnumerable<PlayerModel> GetAll()
        {
            var players = UnitOfWork.PlayerRepository.GetAll();
            return players.Select(q => new PlayerModel() { ID = q.PlayerID, Name = q.Name });
        }
    }
}
