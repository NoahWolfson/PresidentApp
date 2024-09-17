using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresidentApp.Backend
{
    internal class PresidentialAnalyzer(bool isNaturalBornCitizen, string birthDate, int yearsResidedInUs, int numOfTerms, bool isRebellious)
    {
        private bool IsNaturalBornCitizen = isNaturalBornCitizen;
        private string BirthDate { get; set; }= birthDate;
        private int YearsResidedInUs { get; set; } = yearsResidedInUs;
        private int NumOfTerms { get; set; } = numOfTerms;
        private bool IsRebellious = isRebellious;
        private PresidentRequirents presidentRequirents = new PresidentRequirents();

       
        /**
            this method is responsible for checking if user is eligible for president or not 
            @return if user is eligible or not 
        **/
        public bool CheckTermsEligiblity()
        {
            if (NumOfTerms >= presidentRequirents.PresidentialMaxTerms)
            {
                return false;
            }
            return true;
        }
        public bool CheckBirthEligibility()
        {
            DateTime birthday = DateTime.Parse(BirthDate);
            DateTime today = DateTime.Now;
            TimeSpan datediff = today.Subtract(birthday);
            double totalDays = Math.Round(datediff.TotalDays);
            if (totalDays > presidentRequirents.PresidentAgeMinimum)
            {
                return true;
            }
            return false;
        }
        public bool CheckYearsUSResident()
        {
            if (YearsResidedInUs >= presidentRequirents.PresidentResidingMinimum)
            {
                return true;
            }
            return false;
        }
        /**
            this is resposible for returning the response of the program. Ie any errors if there were any improper inputs
        **/
        public string Response()
        {
            string tempResponse = "";
            string response = "";
            if (!IsNaturalBornCitizen)
            {
                tempResponse += "Not a Natural Born Citizen \n";
            }
            if (!CheckTermsEligiblity())
            {
                tempResponse += "To many terms have been served \n";
            }
            if (!CheckBirthEligibility())
            {
                tempResponse += "To young to serve \n";
            }
            if (!CheckYearsUSResident())
            {
                tempResponse += "Residency not acheived to Serve \n";
            }
            if (IsRebellious)
            {
                tempResponse += "Can't serve because corrupt \n";
            }
            if (tempResponse == "")
            {
                response = "You are Eligible For to Run For President";
            }
            else
            {
                response = $"You are not Eligible for the Following Reasons: \n {tempResponse}";
            }
            return response;
        }
    }
}
