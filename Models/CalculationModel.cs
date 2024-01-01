namespace RockPaperScissors.Models
{
    public class CalculationModel
    {
        public bool UserIsWinner { get; set; }
        public bool IsTie { get; set; }
        public CalculationModel(string userSelection, string compSelection)
        {
            UserIsWinner = CalculateWinner(userSelection, compSelection);
        }
        public bool CalculateWinner(string userSelection, string compSelection)
        {
            if (userSelection == "Rock" && compSelection =="Scissors" ||
                userSelection == "Paper" && compSelection == "Rock" ||
                userSelection == "Scissors" && compSelection == "Paper")
            {
                return true;
            }
            else if (userSelection == "Rock" && compSelection == "Paper" ||
                userSelection == "Paper" && compSelection == "Scissors" ||
                userSelection == "Scissors" && compSelection == "Rock")
            {
                return false;
            }
            else
            {
                IsTie = true;
                return false;
            }
        }
    }
}
