using BL_Havruta.Interface;
using DAL_Havruta.Objects;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HavrutaAPI.Controllers;
public class StudyCriteriaController : Controller

{
    private readonly BL_Havruta.Interface.IStudyCriteriaServices _services;
    public StudyCriteriaController(IStudyCriteriaServices services)
    {
        _services = services;
    }


    [HttpGet]
    [EnableCors("AllowAllOrigins")]
    public IEnumerable<DTO_Havruta.Model.StudyCriterion> Get()
    {
        return _services.GetAll();
    }

    [HttpGet("{id}")]
    [EnableCors("AllowAllOrigins")]
    public DTO_Havruta.Model.StudyCriterion GetStudyCriteria(int id)
    {
        return _services.GetById(id);
    }
    [HttpGet("byMail/{mail}")]
    [EnableCors("AllowAllOrigins")]

    public void Post(DTO_Havruta.Model.StudyCriterion studyCriteria)
    {
        _services.AddNew(studyCriteria);
    }
    [HttpPut("Edit")]
    public void Edit(int id, [FromBody] DTO_Havruta.Model.StudyCriterion studyCriteria)
    {
        _services.AddNew(studyCriteria);
        _services.Delete(studyCriteria);
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _services.Delete(GetStudyCriteria(id));
    }
    public DTO_Havruta.Model.StudyCriterion UpdateStudyCriteria(int id, [FromBody] DTO_Havruta.Model.StudyCriterion studyCriteria)
    {
        try
        {

            DTO_Havruta.Model.StudyCriterion OldStudyCriteria = _services.GetById(id);
            if (OldStudyCriteria != studyCriteria)
            {
                OldStudyCriteria = studyCriteria;
            }
            return OldStudyCriteria;
        }
        catch (Exception e)
        {
            throw new Exception();
        }

    }
}
