using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngleMaps.API
{
    public class ThoughtController : ApiController
    {
        // GET: api/Thought
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Thought/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Thought
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Thought/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Thought/5
        public void Delete(int id)
        {
        }
    }
}
