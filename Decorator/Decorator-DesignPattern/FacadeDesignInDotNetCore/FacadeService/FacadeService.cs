using FacadeDesignInDotNetCore.Services.LoginUser;
using FacadeDesignInDotNetCore.Services.RegisterUser;

namespace FacadeDesignInDotNetCore.FacadeDesign
{
    public class FacadeService : IFacadeService
    {
        private ILoginUser _loginUser;
        public ILoginUser LoginUser { get => _loginUser = _loginUser ?? new LoginUser(); }

        private IRegisterUser _registerUser;
        public IRegisterUser RegisterUser { get => _registerUser = _registerUser ?? new RegisterUser(); }
    }
}
