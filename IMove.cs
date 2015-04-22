using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
	/// <summary>
	/// represents a set of moves
	/// </summary>
	public interface IMove
	{
		public string Name { get; }

		/// <summary>
		/// applies the move onto the given cube
		/// </summary>
		/// <param name="cube"></param>
		public void Apply(Cube cube);

		/// <summary>
		/// returns a applicability factor 
		/// 1 = this move will solve the cube
		/// 0 = this move will unsolve the cube
		/// 0.5 = this move will do nothing
		/// </summary>
		/// <param name="cube"></param>
		/// <returns></returns>
		public double Applicable(Cube cube);
	}
}
