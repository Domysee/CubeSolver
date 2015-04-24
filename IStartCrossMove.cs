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
	/// </summary>
	public interface IStartCrossMove
	{
		/// <summary>
		/// applies the move onto the given cube
		/// The middle field of the startside and the given side define which edge piece to solve
		/// </summary>
		/// <param name="cube"></param>
		/// <param name="side"></param>
		void Apply(Cube cube, RelativeSidePosition side);

		/// <summary>
		/// returns a applicability factor 
		/// 1 = this move will solve the cube
		/// 0 = this move will unsolve the cube
		/// 0.5 = this move will do nothing
		/// The startside of the cube and the given side define on which edge piece the applicability is measured
		/// </summary>
		/// <param name="cube"></param>
		/// <param name="side"></param>
		/// <returns></returns>
		double Applicable(Cube cube, RelativeSidePosition side);
	}
}
