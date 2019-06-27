using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThesaurusAPI.Services;

namespace ThesaurusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThesaurusController : ControllerBase
    {
        private ThesaurusService service = new ThesaurusService {};

        // GET: api/Thesaurus
        [HttpGet]
        public IEnumerable<string> Get()
        {
            yield return service.getAllWords();
            //return new string[] { "value55", "value234" };
        }

        // GET: api/Thesaurus/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return service.getSynonyms("re");
        }


        // PUT: api/Thesaurus/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            Console.WriteLine("vad e id: " + id);
            Console.WriteLine("vad e value: " + value);
        }

    }
}
