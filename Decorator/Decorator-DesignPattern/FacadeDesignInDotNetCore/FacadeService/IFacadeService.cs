using FacadeDesignInDotNetCore.Services.LoginUser;
using FacadeDesignInDotNetCore.Services.RegisterUser;

namespace FacadeDesignInDotNetCore.FacadeDesign
{
    public interface IFacadeService
    {
        public ILoginUser LoginUser { get; }
        public IRegisterUser RegisterUser { get; }
    }
}
