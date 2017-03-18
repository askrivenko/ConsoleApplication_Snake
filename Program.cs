using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Snake
{
	class Program
	{
		static void Main(string[] args)
		{

			Point p = new Point { x = 10, y = 10, symbol = '*' };
			p.Draw();
			Point p2 = new Point { x = 100, y = 10, symbol = '*' };
			p2.Draw();

			Console.ReadKey();
		}

	}
}
