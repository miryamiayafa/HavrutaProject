using System;
using DAL_Havruta.Model;
using DAL_Havruta.Interfase;


namespace DAL_Havruta.Objects
{
	public class StudyCriteria : IStudyCriteriaDal
	{
		private readonly DB.HavrutaDbContext context;

		public StudyCriteria(DB.HavrutaDbContext _context)
		{ 
			this.context = _context;
		}	

		public bool AddNew(StudyCriterion studyCriteria)
		{
			try
			{
				if (studyCriteria != null)
				{
					context.StudyCriteria.Add(studyCriteria);
				}

				return true;	


			}
			catch (Exception ex)
			{
				throw new Exception();
			}

		}


	

		public bool Delete(StudyCriterion studyCriteria)
		{
            StudyCriterion StudyCriterionTry = GetById(studyCriteria.Idcriterion);
            try
			{
				if (StudyCriterionTry != null)
					context.StudyCriteria.Remove(StudyCriterionTry);
				return true;
			}
			catch(Exception ex) 
			{
				throw new Exception(); 
			}

				
		
		}

		public bool Update(StudyCriterion studyCriteria)
		{
			StudyCriterion StudyCriteriaTry=GetById(studyCriteria.Idcriterion);
			try
			{
				if(StudyCriteriaTry != null)
					context.StudyCriteria.Update(studyCriteria);	
				return true;	

			}
			catch(Exception ex) 
			{ 
				throw new Exception();
			}
				


		}

		public IEnumerable<StudyCriterion> GetAll() 
		{
			try
			{
				return context.StudyCriteria.ToList();

			}
			catch(Exception ex) 
			{
				throw new Exception(); 	
		    }
		}


		public StudyCriterion GetById(int id) 
		{

			try
			{
				return (StudyCriterion)GetAll().Where(x => x.Idcriterion == id);
			}
			catch(Exception ex)
			{
				throw new Exception();
			}
		
		}


	}
}
