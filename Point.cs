﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Snake
{
	class Point
	{
		public int x;
		public int y;
		public char symbol;

		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(symbol);
		}

	}
}
