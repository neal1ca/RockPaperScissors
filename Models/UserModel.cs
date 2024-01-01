namespace RockPaperScissors.Models
{
	public class UserModel
	{
		public string Selection { get; set; }
		public bool IsRock { get; set; }
		public bool IsPaper { get; set; }
		public bool IsScissors { get; set; }

		public UserModel()
		{
		}

		public void GetUserSelection()
		{
			if (IsRock && !IsPaper && !IsScissors)
			{
				Selection= "Rock";
			}
			else if (!IsRock && !IsPaper && !IsScissors)
			{
				Selection = "Paper";
			}
			else if (!IsRock && !IsPaper && !IsScissors)
			{
				Selection = "Scissors";
			}
		}
	}
}
