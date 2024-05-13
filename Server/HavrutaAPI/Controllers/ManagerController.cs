using BL_Havruta.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HavrutaAPI.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ManagerController : Controller
{
    // GET: ManagerController
    private readonly BL_Havruta.Interface.IManagerServices _services;
    public ManagerController(IManagerServices services)
    {
        _services = services;
    }


    [HttpGet]
    [EnableCors("AllowAllOrigins")]
    public IEnumerable<DTO_Havruta.Model.Manager> GetManager()
    {
        return _services.GetAll();
    }

    [HttpGet("{id}")]
    [EnableCors("AllowAllOrigins")]
    public DTO_Havruta.Model.Manager GetManager(int id)
    {
        return _services.GetById(id);
    }
    [HttpGet("byMail/{mail}")]
    [EnableCors("AllowAllOrigins")]
    public DTO_Havruta.Model.Manager GetEmaile(string mail)
    {
        return _services.GetByEmail(mail);
    }
    // POST api/<StudyController>
    [HttpPost]
    public void Post(DTO_Havruta.Model.Manager manager)
    {
        _services.AddNew(manager);
    }
    [HttpPut("Edit")]
    public void Edit(int id, [FromBody] DTO_Havruta.Model.Manager manager)
    {
        _services.AddNew(manager);
        _services.Delete(manager);
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _services.Delete(GetManager(id));
    }

}

