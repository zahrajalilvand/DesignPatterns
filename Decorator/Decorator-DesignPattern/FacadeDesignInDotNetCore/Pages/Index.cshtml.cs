using FacadeDesignInDotNetCore.FacadeDesign;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FacadeDesignInDotNetCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IFacadeService _facadeService;
        //public IndexModel(IFacadeService facadeService)
        //{
        //    _facadeService = facadeService;
        //}

        public IndexModel(ILogger<IndexModel> logger, IFacadeService facadeService)
        {
            _logger = logger;
            _facadeService = facadeService;
        }

        public void OnGet()
        {
            _facadeService.RegisterUser.Execute();
            _facadeService.LoginUser.Execute();
        }
    }
}