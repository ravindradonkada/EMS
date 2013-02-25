using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS.ObjectModel
{
    public class EmployeeObj
    {
        /* Personal Details */
        public string EmpId { get; set; } /* Employee ID */
        public string FName { get; set; } /* First Name */
        public string MName { get; set; } /* Middle Name */
        public string LName { get; set; } /* Last Name*/
        public DateTime DOB { get; set; } /* Date of Birth */
        public string POB { get; set; } /*Place of Birth*/
        public string Domicle { get; set; }
        public string Nationality { get; set; }
        public string DrivingLic { get; set; } /* Driving Licence No */
        public int DrivingLicType { get; set; } /* Two /Four Wheeler */
        public int Sex { get; set; }
        public int NoOfChildern { get; set; }
        public string FatherName { get; set; } 
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public int NoOfSiblings { get; set; }
        public string MartialStatus { get; set; }

        /* Health */
        public string BloodGroup { get; set; }
        public string Vision { get; set; }
        public string LastMjrIllness { get; set; } /* Last Major Illness */
        
        /* Passport */
        public string PassportNo { get; set; }
        public bool IshavingPassport { get; set; }
        public DateTime DOIssue { get; set; }   /* Date of Issue */ 
        public DateTime VThrudt { get; set; }   /* Passport Expiry Date */
        public string IssuedAt { get; set; }
        public string IssuedBy { get; set; }
        
        
        /*Education*/
        public string HQDegree { get; set; } /* Highest Qual. Degree */

        /*Current Employer*/
        public DateTime DOJ { get; set; } /* Date of Joining */
        public string SkillSet { get; set; }
        public DateTime DOR { get; set; } /* Date of Relieving */
    }

    /*Previous Employee Details*/
    public class PrevEmployeeDetails
    {
        public string EmpId { get; set; }
        public DateTime DOJ { get; set; } /* Date of Joining */
        public string Profession { get; set; }
        public DateTime DOR { get; set; } /* Date of Relieving */
        public string Company { get; set; }
        public string Reason { get; set; } /* Reason For Leaving */
    }

    /* Employee ContactInfo*/
    public class EmpContactDetails
    {
        public string EmpId { get; set; }
        public string CAddress { get; set; } /* Current Address */
        public string PAddress { get; set; } /* Perminent Address */
        public string EContactNo { get; set; } /* Emergency ContactNo */
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}