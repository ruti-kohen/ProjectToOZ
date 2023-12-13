using Microsoft.AspNetCore.Mvc;
using ProjectToOZ.BLL;
using ProjectToOZ.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectToOZ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {

        private readonly ICandidateService _candidateService;

        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        // GET: api/<CandidateController>
        [HttpGet]
        [Route("GetCandidate")]
        public Task<string> Get()
        {
            return _candidateService.GetCandidatesAsync();
        }

        [HttpGet]
        [Route("GetCandidateList")]
        public Task<List<Candidate>> GetList()
        {
            return _candidateService.GetCandidatesAsyncList();
        }


        // GET api/<CandidateController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CandidateController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CandidateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CandidateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}



//private readonly IPresentService _presentService;

//public PresentController(IPresentService presentService)
//{
//    _presentService = presentService;
//}

//[Route("GetPresents")]
//public Task<List<Present>> GetPresents()
//{
//    return _presentService.GetPresentsAsync();
//}