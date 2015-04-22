using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
	/// <summary>
	/// identifies a side relative to another side
	/// </summary>
	public enum RelativeSidePosition
	{
		Self, Opposite, Left, Right, Top, Bottom, NotExisting
	}
}
