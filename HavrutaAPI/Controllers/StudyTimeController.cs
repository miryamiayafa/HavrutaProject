using BL_Havruta.Interface;
using DAL_Havruta.Objects;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace HavrutaAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class StudyTimeController : ControllerBase
    {
        private readonly BL_Havruta.Interface.IStudyTimeServices _services;
        public StudyTimeController(IStudyTimeServices services)
        {
            _services = services;
        }


        [HttpGet]
        [EnableCors("AllowAllOrigins")]
        public IEnumerable<DTO_Havruta.Model.StudyTime> Get()
        {
            return _services.GetAll();  
        }

        [HttpGet("{id}")]
        [EnableCors("AllowAllOrigins")]
        public DTO_Havruta.Model.StudyTime GetStudyTime(int id)
        {
            return _services.GetById(id);
        }
        [HttpGet("byMail/{mail}")]
        [EnableCors("AllowAllOrigins")]
        
        public void Post(DTO_Havruta.Model.StudyTime studyTime)
        {
            _services.AddNew(studyTime);
        }
        [HttpPut("Edit")]
        public void Edit(int id, [FromBody] DTO_Havruta.Model.StudyTime studyTime)
        {
            _services.AddNew(studyTime);
            _services.Delete(studyTime);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.Delete(GetStudyTime(id));
        }
        public DTO_Havruta.Model.StudyTime UpdateStudyTime(int id, [FromBody] DTO_Havruta.Model.StudyTime studyTime)
        {
            try
            {
     
                DTO_Havruta.Model.StudyTime OldStudyTime = _services.GetById(id);
                if (OldStudyTime != studyTime) 
                {
                    OldStudyTime= studyTime;
                }
                return OldStudyTime;
            } 
            catch(Exception e) 
            {
                throw new Exception();
            }
        }
    }

