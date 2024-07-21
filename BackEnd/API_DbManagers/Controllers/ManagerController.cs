using API_DbManagers.Context;
using API_DbManagers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_DbManagers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {

        // import context
        private readonly AppDbContext _context;

        public ManagerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<ManagerController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var managers = _context.Db_Manager.ToList();
                return Ok(managers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ManagerController>/5
        [HttpGet("{id}", Name = "GetManager")]
        public ActionResult Get(int id)
        {
            try
            {
                var manager = _context.Db_Manager.FirstOrDefault(p => p.Id == id);
                return Ok(manager);
                
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST api/<ManagerController>
        [HttpPost]
        public ActionResult Post([FromBody] Db_Manager manager)
        {
            try
            {
                _context.Db_Manager.Add(manager);
                _context.SaveChanges();
                return CreatedAtRoute("GetManager", new { id = manager.Id }, manager);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ManagerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Db_Manager manager)
        {
            try
            {
                if (manager.Id == id)
                {
                    _context.Entry(manager).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetManager", new { id = manager.Id }, manager);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ManagerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var manager = _context.Db_Manager.FirstOrDefault(p => p.Id == id);
                if (manager != null)
                {
                    _context.Db_Manager.Remove(manager);
                    _context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
