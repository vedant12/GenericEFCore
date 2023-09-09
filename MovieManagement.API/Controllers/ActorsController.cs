using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Domain.Repository;

namespace MovieManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        public IUnitOfWork _unitOfWork { get; }
        public ActorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_unitOfWork.Actor.GetAll());
        }

        [HttpGet("GetActorsWithMovies")]
        public ActionResult GetActorsWithMovies()
        {
            return Ok(_unitOfWork.Actor.GetActorsWithMovies());
        }

    }
}
