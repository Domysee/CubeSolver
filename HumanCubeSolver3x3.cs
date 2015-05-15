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
		private RelativeCornerPosition[] relativeCornerPositions = { RelativeCornerPosition.BottomLeft, RelativeCornerPosition.BottomRight, RelativeCornerPosition.TopLeft, RelativeCornerPosition.TopRight };
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

		public void SolveTopEdges(Cube cube)
		{
			while (!cube.IsTopEdgesSolved())
			{
				//3 is the limit because after 3 rotations of the bottom side it will be as before (4 rotations have no effect)
				for (int i = 0; i < 3; i++)
				{
					//first, move any edges that are in the correct bottom position on the correct top position
					//go through every edge
					foreach (var corner in relativeCornerPositions)
					{
						//go through every possible move
						foreach (var move in Moves.StartEdgeMoves)
						{
							if (move.Applicable(cube, corner) == 1)
							{
								move.Apply(cube, corner);
							}
						}
					}

					if (cube.IsTopEdgesSolved())
					{
						break;
					}
					else
					{
						//rotate the bottom side, maybe then there will be corner pieces in the correct position
						cube.RotateBottomCW();
					}
				}

				//move corner pieces that are in the correct position but wrongly rotated to the bottom
				//if there are no such pieces then the moves are not applied, therefore no check for the solved state is needed
				foreach (var corner in relativeCornerPositions)
				{
					if (Moves.StartEdgeMoveDownMove.Applicable(cube, corner) == 1)
					{
						Moves.StartEdgeMoveDownMove.Apply(cube, corner);
					}
				}
			}
		}

		public void SolveSecondLayer(Cube cube)
		{
			while (!cube.IsSecondLayerSolved())
			{
				//3 is the limit because after 3 rotations of the bottom side it will be as before (4 rotations have no effect)
				for (int i = 0; i < 3; i++)
				{
					//first, move any edges that are in the correct bottom position on the correct top position
					//go through every edge
					foreach (var side in new Sides[] { Sides.Front, Sides.Left, Sides.Back, Sides.Right })
					{
						//go through every possible move
						foreach (var move in Moves.SecondLayerEdgeMoves)
						{
							if (move.Applicable(cube, side) == 1)
							{
								move.Apply(cube, side);
							}
						}
					}

					if (cube.IsSecondLayerSolved())
					{
						break;
					}
					else
					{
						//rotate the bottom side, maybe then there will be edge pieces in the correct position
						cube.RotateBottomCW();
					}
				}

				//move edge pieces that are in the correct position but wrongly rotated to the bottom
				//if there are no such pieces then the moves are not applied, therefore no check for the solved state is needed
				foreach (var side in new Sides[] { Sides.Front, Sides.Left, Sides.Back, Sides.Right })
				{
					if (Moves.SecondLayerOutMove.Applicable(cube, side) == 1)
					{
						Moves.SecondLayerOutMove.Apply(cube, side);
					}
				}
			}
		}
	}
}
