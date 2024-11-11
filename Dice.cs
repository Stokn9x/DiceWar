using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWar
{
	public class Dice
	{
		public int Value { get; private set; }

		public void Roll()
		{
			Random random = new Random();
			Value = random.Next(1, 7);
		}

		public virtual int Point()
		{
			return Value;
		}

		public override String ToString()
		{
			return $"[{Value.ToString()}]";
		}
	}
}
