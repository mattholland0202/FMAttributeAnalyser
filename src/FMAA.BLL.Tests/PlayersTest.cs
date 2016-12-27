using FMAA.BLL.Interfaces;
using FMAA.DAL;
using FMAA.Web.Api.Models.Return;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMAA.BLL.Tests
{
    [TestFixture]
    public class PlayersTest
    {
        private IBLL BLL;

        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void GetAllPlayers_Test()
        {
            var result = BLL.Players.GetAll();
            Assert.IsInstanceOf<IEnumerable<PlayerModel>>(result);
        }
    }
}
