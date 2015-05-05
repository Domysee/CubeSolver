using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
	public class HumanCubeSolver3x3
	{
		private RelativeSidePosition[] relativeSidePositions = { RelativeSidePosition.Left, RelativeSidePosition.Top, RelativeSidePosition.Right, RelativeSidePosition.Bottom };
		public void SolveTopCross(Cube cube)
		{
			while (!cube.IsTopCrossSolved())
			{
				foreach (var move in Moves.StartCrossMoves)
				{
					foreach (var relativeSidePosition in relativeSidePositions)
					{
						if (move.Applicable(cube, relativeSidePosition) == 1) move.Apply(cube, relativeSidePosition);
					}
				}
			}
		}
	}
}
