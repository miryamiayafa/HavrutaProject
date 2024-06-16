using BL_Havruta.Interface;
using DAL_Havruta.Objects;
using BL_Havruta.Objects;
using DTO_Havruta.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System;
using System.Collections.Generic;
using DAL_Havruta.Migrations.Model;

namespace HavrutaAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController  : ControllerBase
{
   private readonly BL_Havruta.Interface.IBL  _services = BL_Havruta.Objects.BL.Instance;  
    public UserController()
    {

    }


    [HttpGet]
    [EnableCors("AllowAllOrigins")]
    public IEnumerable<DTO_Havruta.Model.User> GetUsers() 
    {
        return _services.userServices.GetAll();
    }

    [HttpGet("{id}")]
    [EnableCors("AllowAllOrigins")]
    public DTO_Havruta.Model.User GetUser(int id)
    {
        return _services.userServices.GetById(id);   
    }
    [HttpGet("byMail/{mail}")]
    [EnableCors("AllowAllOrigins")]
    public DTO_Havruta.Model.User GetEmaile(string mail)
    {
        return _services.userServices.GetByEmail(mail);  
    }

    // POST api/<UserController>
    [HttpPost("SignIn")]
    public IActionResult SignIn(DTO_Havruta.Model.User user)
    {
        try
        {
            int ans = _services.userServices.AddNew(user);
            if (ans > 0)
                return Ok(ans);
            return Ok(false);
        }
        catch (Exception ex)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message); // נחזיר תשובת 500 עם הודעת השגיאה
        }
    }
    [HttpPut("Edit")]
    public void Edit(int id, [FromBody] DTO_Havruta.Model.User user) 
    {
        _services.userServices.AddNew(user);
        _services.userServices.Delete(user); 
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _services.userServices.Delete(GetUser(id));
    }



    /// <summary>
    /// For alerting view. get the number of new messanges and evant for a user.
    /// </summary>
    /// <param name="id">The user id</param>
    /// <returns>[new messages number, today events number]</returns>
    [HttpGet("GetTheNumberOfAlerts")]
    public IActionResult GetTheNumberOfAlerts(int id)
    {
        try
        {
            bool isExist = _services.userServices.IsExist(id);

            if (isExist)
            {
                List<int> result = new List<int>();
                result.Add(_services.RequestServices.GetNumberOfRequestForUser(id));
                result.Add(_services.StudyTimeServices.GetTheNuberOfTodayStudyForUser(id));

                //IBl =>  BL.Instance

                return Ok(result);
            }
            else
            {
                return NotFound(); // אם המשתמש לא קיים, נחזיר תשובת 404
            }
        }
        catch (Exception ex)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message); // נחזיר תשובת 500 עם הודעת השגיאה
        }
    }

    [HttpPost("Login")]
    public IActionResult Login(DTO_Havruta.Model.LoginUser loginUser)
    {
        try
        {
            int id = _services.userServices.Login(loginUser);
            if (id == -1)
                return BadRequest();
            return Ok(id);
        }
        catch (Exception ex)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message); // נחזיר תשובת 500 עם הודעת השגיאה
        }

    }
    [HttpGet("UserInformation")]
    public IActionResult UserInformation()
    {
        try
        {
            var userInfo = _services.userServices.GetUserSubjectInfo();
            if (userInfo == null)
            {
                // רישום במקרה של null
                Console.WriteLine("No user information found.");
                return NotFound("No user information found.");
            }

            // רישום של הנתונים שהתקבלו
            Console.WriteLine("User information retrieved successfully.");
            Console.WriteLine(userInfo);

            return Ok(userInfo);
        }
        catch (Exception ex)
        {
            // רישום במקרה של שגיאה
            Console.WriteLine($"An error occurred: {ex.Message}");
            return StatusCode(500, "Internal server error");
        }
    }

}
