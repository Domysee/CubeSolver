using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
	/// <summary>
	/// represents a set of moves to solve the first cross
	/// Top is takes as start side
	/// 
	/// The neutral corner position is bottom left
	/// Every corner is treated as if the cube was rotated so that it is the bottom left corner
	/// </summary>
	public interface IStartCornerMove
	{
		/// <summary>
		/// applies the move onto the given cube
		/// The middle field of the startside and the sides adjacent to the corner define which edge piece to solve
		/// </summary>
		/// <param name="cube"></param>
		/// <param name="side"></param>
		void Apply(Cube cube, RelativeCornerPosition corner);

		/// <summary>
		/// returns a applicability factor 
		/// 1 = this move will do what it is supposed to do
		/// 0 = this move has a negative effect
		/// 0.5 = this move will do nothing				
		/// The startside of the cube and the the sides adjacent to the corner define on which edge piece the applicability is measured
		/// </summary>
		/// <param name="cube"></param>
		/// <param name="side"></param>
		/// <returns></returns>
		double Applicable(Cube cube, RelativeCornerPosition corner);
	}
}
