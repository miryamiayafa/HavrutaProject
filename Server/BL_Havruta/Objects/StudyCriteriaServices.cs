﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL_Havruta.Interface;
using DAL_Havruta.Interfase;
using DTO_Havruta.Model;

namespace BL_Havruta.Objects;

public class StudyCriteriaServices : IStudyCriteriaServices
{
    DAL_Havruta.Interface.IDal dal = DAL_Havruta.Objects.DAL.Instance;
    private readonly IMapper mapper;

    public StudyCriteriaServices (IMapper mapper)
    {
        this.mapper = mapper;
     
    }
    public bool AddNew(StudyCriterion studyCriterion)
    {
        return dal.studyCriteriaDal.AddNew(mapper.Map<DAL_Havruta.Model.StudyCriterion>(studyCriterion));    
    }
    public IEnumerable<DTO_Havruta.Model.StudyCriterion> GetAll()
    {
        try
        {
            IEnumerable<DAL_Havruta.Model.StudyCriterion> studyCriteria = dal.studyCriteriaDal.GetAll();
            MapperConfiguration configuration = new MapperConfiguration(mcfg => mcfg.CreateMap<DTO_Havruta.Model.StudyCriterion, DAL_Havruta.Model.StudyCriterion>()
            .ReverseMap());
            var mapper = configuration.CreateMapper();
            IEnumerable<DTO_Havruta.Model.StudyCriterion> studyCriteriaList = studyCriteria.Select(x => mapper.Map<DTO_Havruta.Model.StudyCriterion>(x));
            return studyCriteriaList;   
        }
        catch (Exception ex) 
        {
            throw new Exception();
        }

    }
    public StudyCriterion GetById(int id)
    {
        StudyCriterion getByIdStudyCriterionBL;
        getByIdStudyCriterionBL = mapper.Map<DTO_Havruta.Model.StudyCriterion>(dal.studyCriteriaDal.GetById(id));
        return getByIdStudyCriterionBL; 
    }
    
    public bool Delete(StudyCriterion studyCriterion)
    {
        return dal.studyCriteriaDal.Delete(mapper.Map<DAL_Havruta.Model.StudyCriterion>(studyCriterion));
    }

    public bool Update(StudyCriterion studyCriterion)
    {
        return dal.studyCriteriaDal.Update(mapper.Map<DAL_Havruta.Model.StudyCriterion>(studyCriterion));
    }
}
