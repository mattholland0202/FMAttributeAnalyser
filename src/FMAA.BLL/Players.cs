using FMAA.BLL.Interfaces;
using FMAA.DAL.Interfaces;
using FMAA.Web.Api.Models.Return;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FMAA.BLL
{
    public class Players : IPlayers
    {
        private readonly IUnitOfWork unitOfWork;


        public Players(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<PlayerModel> GetAll()
        {
            var players = unitOfWork.PlayerRepository.GetAll();
            return players.Select(q => new PlayerModel() { ID = q.PlayerID, Name = q.Name });
        }
    }
}
