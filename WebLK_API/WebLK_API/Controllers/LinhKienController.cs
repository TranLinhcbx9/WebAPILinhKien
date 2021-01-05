using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebLK_Data.DAO;
using WebLK_Data.DTO;

namespace WebLK_API.Controllers
{
    public class LinhKienController : ApiController
    {
        // GET: api/LinhKien
        [Route("listlinhkien")]

        public IHttpActionResult Get()
        {
            List<LinhKien> item = LinhKienDAO.Instance.GetListLinhKien();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // GET: api/LinhKien/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LinhKien
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LinhKien/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LinhKien/5
        public void Delete(int id)
        {
        }
    }
}
