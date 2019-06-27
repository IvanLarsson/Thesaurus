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

        // GET: api/Thesaurus/test
        [HttpGet("{word}", Name = "Get")]
        public string Get(string word)
        {
            Console.WriteLine("vad e inc word: " + word);
            return service.getSynonyms("re");
        }


        // PUT: api/Thesaurus/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) => service.putWord(value);

    }
}
