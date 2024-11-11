using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWar
{
	public class WarDiceCup
	{
		private List<Dice> dices = new List<Dice>();

		public WarDiceCup(int diceCount)
		{
			for (int i = 0; i < diceCount; i++)
			{
				dices.Add(new WarDice());
			}
		}

		public void RollAll()
		{
			foreach (var dice in dices)
			{
				dice.Roll();
			}
		}

		public int GetTotalPoints()
		{
			return dices.Sum(d => d.Point());
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			foreach (var dice in dices)
			{
				sb.Append($"[{dice.Value}]");
			}
			return sb.ToString();
		}
	}
}
