using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lb6
{
	public class Program
	{
		static void Main(string[] args)
		{
			Factory fac = new Factory();
			fac.runParallel();
		}
	}
}
