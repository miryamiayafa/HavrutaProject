
using BL_Havruta.Interface;
using DAL_Havruta.Objects;
using BL_Havruta.Objects;
using DTO_Havruta.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HavrutaAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
   private readonly BL_Havruta.Interface.IUserServices _services;  
    public UserController(IUserServices services)
    {
        _services = services;
    }


    [HttpGet]
    [EnableCors("AllowAllOrigins")]
    public IEnumerable<DTO_Havruta.Model.User> GetUsers() 
    {
        return _services.GetAll();
    }

    [HttpGet("{id}")]
    [EnableCors("AllowAllOrigins")]
    public DTO_Havruta.Model.User GetUser(int id)
    {
        return _services.GetById(id);   
    }
    [HttpGet("byMail/{mail}")]
    [EnableCors("AllowAllOrigins")]
    public DTO_Havruta.Model.User GetEmaile(string mail)
    {
        return _services.GetByEmail(mail);  
    }
    public void Post(DTO_Havruta.Model.User user)
    {
        _services.AddNew(user);
    }
    [HttpPut("Edit")]
    public void Edit (int id, [FromBody] DTO_Havruta.Model.User user) 
    {
        _services.AddNew(user);
        _services.Delete(user); 
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _services.Delete(GetUser(id));
    }

}
