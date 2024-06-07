using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Havruta.Model;

public class UserInformation
{
    public string fName {  get; set; }
    public int age {  get; set; }
    public string gender { get; set; }
    public string sector { get; set; }  
    public string subject { get; set; }
    public string? SubjectDescription { get; set; }
    public string descriptionMyStudy { get; set; }   

}
