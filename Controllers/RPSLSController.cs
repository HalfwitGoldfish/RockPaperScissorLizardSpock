using Microsoft.AspNetCore.Mvc;
using RockPaperScissorLizardSpock.Services;

namespace RockPaperScissorLizardSpock.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RPSLSController : ControllerBase
    {
        private readonly RPSLSServices _rpslsServices;

        public RPSLSController(RPSLSServices rpslsServices)
        {
            _rpslsServices = rpslsServices;
        }

        [HttpGet]
        [Route("rpsls")]
        public string DidWin()
        {
            return _rpslsServices.DidWin();
        }
    }
}