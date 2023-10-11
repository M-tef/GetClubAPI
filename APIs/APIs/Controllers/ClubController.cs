using APIs.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private readonly TMSDbContext tMSDbContext;
        public ClubController(TMSDbContext tMSDbContext) {
            this.tMSDbContext = tMSDbContext;
        }

        [HttpGet("GetClubs")]
        public ActionResult Index()
        {
            return Ok(this.tMSDbContext.Clubs.ToList());
        }

    }
}
