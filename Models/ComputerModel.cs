namespace RockPaperScissors.Models
{
    using System;
    public class ComputerModel
    {
        public string Selection { get; set; }

        public ComputerModel() 
        {
            Selection = GettingComputerSelection();
        }

        private string GettingComputerSelection()
        {
            Random rnd = new Random();
            int random = rnd.Next(3);
            return ConvertNumberToResponse(random);
        }
        private string ConvertNumberToResponse(int selection)
        {
            if(selection == 0)
            {
                return "Rock";
            }
            if(selection == 1)
            {
                return "Paper";
            }
            return "Scissors"; 
        }
    }
}
