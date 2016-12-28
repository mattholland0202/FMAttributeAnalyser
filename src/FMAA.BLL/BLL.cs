using FMAA.BLL.Interfaces;
using FMAA.DAL;
using FMAA.DAL.Interfaces;

namespace FMAA.BLL
{
    public class BLL : IBLL
    {
        private IUnitOfWork unitOfWork;

        /// <summary>
        /// Constructor which creates a new <see cref="UnitOfWork"/> 
        /// </summary>
        public BLL()
        {
            this.unitOfWork = new UnitOfWork();

            Setup();
        }

        /// <summary>
        /// Constructor for injecting an <see cref="IUnitOfWork"/>, which can be mocked for testing
        /// </summary>
        /// <param name="unitOfWork">The Unit Of Work to use</param>
        public BLL(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

            Setup();
        }

        private void Setup()
        {
            this.Players = new Players(unitOfWork);
        }

        public IPlayers Players { get; set; }
    }
}
