﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
	/// <summary>
	/// represents a set of moves to solve the corners of the third layer
	/// </summary>
	public interface IOLLCornerMove
	{
		/// <summary>
		/// applies the move onto the given cube
		/// </summary>
		/// <param name="cube"></param>
		/// <param name="side"></param>
		void Apply(Cube cube);

		/// <summary>
		/// returns a applicability factor 
		/// 1 = this move will do what it is supposed to do
		/// 0 = this move has a negative effect
		/// 0.5 = this move will do nothing				
		/// </summary>
		/// <param name="cube"></param>
		/// <param name="side"></param>
		/// <returns></returns>
		double Applicable(Cube cube);
	}
}
