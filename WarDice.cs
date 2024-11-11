using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWar
{
	public class WarDice : Dice
	{
		public override int Point()
		{
			if (Value % 2 != 0)
			{
				return Value * 2;
			}
			return Value;
		}
	}
}
