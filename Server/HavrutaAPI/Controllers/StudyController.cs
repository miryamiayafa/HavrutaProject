using BL_Havruta.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HavrutaAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class StudyController : ControllerBase
    {
        private readonly BL_Havruta.Interface.IStudyServices _services;
        public StudyController(IStudyServices services)
        {
            _services = services;
        }


        [HttpGet]
        [EnableCors("AllowAllOrigins")]
        public IEnumerable<DTO_Havruta.Model.Study> Get()
        {
            return _services.GetAll();
        }

        [HttpGet("{id}")]
        [EnableCors("AllowAllOrigins")]
        public DTO_Havruta.Model.Study GetStudy(int id)
        {
            return _services.GetById(id);
        }
        

        // POST api/<StudyController>
        [HttpPost]
        public void Post(DTO_Havruta.Model.Study study)
        {
            _services.AddNew(study);
        }
        [HttpPut("Edit")]
        public void Edit(int id, [FromBody] DTO_Havruta.Model.Study study)
        {
            _services.AddNew(study);
            _services.Delete(study);
        }

        // DELETE api/<StudyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.Delete(GetStudy(id));
        }
        
        [HttpPut("UpdateStudy")]
        public DTO_Havruta.Model.Study UpdateStudy(int id, [FromBody] DTO_Havruta.Model.Study study)
        {
            try
            {

                DTO_Havruta.Model.Study OldStudy = _services.GetById(id);
                if (OldStudy != study)
                {
                    OldStudy = study;
                }
                return OldStudy;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }

