using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;


namespace dockerapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> GetValues()
        {
            return new string[] { "value1", "value2" };
        }

        //[HttpGet]
        //public string Value(int id)
        //{
        //    return "value";
        //}

        [HttpPost]
        public void SaveNewValue([FromBody]string value)
        {
        }

        [HttpPut]
        public void UpdateValue(int id, [FromBody]string value)
        {
        }

        [HttpDelete]
        public void RemoveValue(int id)
        {
        }
    }
}
