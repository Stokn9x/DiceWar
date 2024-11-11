using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWar
{
	public class Game
	{
		private WarDiceCup player;
		private WarDiceCup computer;

		private int playerScore;
		private int computerScore;

		private int rounds;

		public Game(int diceCount, int rounds)
		{
			player = new WarDiceCup(diceCount);
			computer = new WarDiceCup(diceCount);

			this.rounds = rounds;

			StartGame();
		}

		public void PlayRound()
		{
			player.RollAll();
			computer.RollAll();

			int playerPoints = player.GetTotalPoints();
			int computerPoints = computer.GetTotalPoints();

			playerScore += playerPoints;
			computerScore += computerPoints;

			
			Console.WriteLine($"Playe rolled: {player}, Player points: {playerPoints}");
			Console.WriteLine($"Computer rolled: {computer}, Computer points: {computerPoints}");
		}

		public void StartGame()
		{
			for (int i = 0; i < rounds; i++)
			{
				Console.WriteLine($"---Round {i}---");
				PlayRound();
				Console.WriteLine("");
			}

			Console.WriteLine($"Game over. Final score - Player: {playerScore}, Computer: {computerScore}");
		}
	}
}
