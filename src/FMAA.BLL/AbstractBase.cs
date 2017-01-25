using FMAA.BLL.Interfaces;
using FMAA.DAL.Interfaces;

namespace FMAA.BLL
{
    public abstract class AbstractBase
    {
        internal IUnitOfWork UnitOfWork { get; }
        internal BLL BLL { get; }

        public AbstractBase(BLL bll)
        {
            BLL        = bll;
            UnitOfWork = bll.unitOfWork;
        }
    }
}
