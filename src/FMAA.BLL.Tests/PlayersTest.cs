using FMAA.BLL.Interfaces;
using FMAA.DAL.Interfaces;
using FMAA.Data.Entities;
using FMAA.Web.Api.Models.Return;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace FMAA.BLL.Tests
{
    [TestFixture]
    public class PlayersTest
    {
        private IBLL BLL;

        private IEnumerable<Player> players;

        [SetUp]
        public void SetUp()
        {
            var mockedUnitOfWork = new Mock<IUnitOfWork>();

            var mockedPlayerRepository = new Mock<IPlayerRepository>();

            players = new List<Player>
            {
                new Player { PlayerID = 1, Name = "Test Player 1" },
                new Player { PlayerID = 2, Name = "Test Player 2" },
                new Player { PlayerID = 3, Name = "Test Player 3" },
            };

            mockedPlayerRepository.Setup(m => m.GetAll())
                .Returns(players);

            mockedUnitOfWork.Setup(m => m.PlayerRepository).Returns(mockedPlayerRepository.Object);

            BLL = new BLL(mockedUnitOfWork.Object);
        }

        [Test]
        public void GetAllPlayers_Test()
        {
            var result = BLL.Players.GetAll();
            Assert.IsInstanceOf<IEnumerable<PlayerModel>>(result);
            Assert.AreEqual(players.Count(), result.Count());
        }
    }
}
