using AutoMapper;
using Microsoft.AspNetCore.Mvc;


namespace Store.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        public readonly IMapper _mapper;
        public Controller(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
