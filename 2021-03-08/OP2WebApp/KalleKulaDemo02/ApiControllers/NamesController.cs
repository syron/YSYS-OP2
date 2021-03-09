using KalleKulaDemo02.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalleKulaDemo02.ApiControllers
{
   /// <summary>
   /// /api/names
   /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        /// <summary>
        /// /api/names
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get(string s)
        {
            var namesService = new NamesService();

            return namesService.GetServiceBySubstring(s);
        }

        /// <summary>
        /// /api/names
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ordered")]
        public IEnumerable<string> GetNamesOrderByName()
        {
            var namesService = new NamesService();

            return namesService.GetAllNames().OrderBy(o => o);
        }

        /// <summary>
        /// /api/names
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string Post([FromBody]string name)
        {
            var namesService = new NamesService();
            namesService.Add(name);
            return "Robert";
        }

        /// <summary>
        /// /api/names/{id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        public string Put(int id, [FromBody]string name)
        {
            return "Robert2";
        }

        /// <summary>
        /// /api/names/{id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool Delete(int id)
        {
            return false;
        }
    }
}
