using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.SecondLayerEdgeMoves
{
	/// <summary>
	/// left edge piece is in the correct position 
	/// </summary>
	public class SecondLayerEdgeMove2 : ISecondLayerEdgeMove
	{
		public void Apply(Cube cube, Sides side)
		{
			cube.RotateBottomCW();
			cube.RotateSideCW(Helper.GetRelativeSide(side, RelativeSidePosition.Left));
			cube.RotateBottomCCW();
			cube.RotateSideCCW(Helper.GetRelativeSide(side, RelativeSidePosition.Left));
			cube.RotateBottomCCW();
			cube.RotateSideCCW(side);
			cube.RotateBottomCW();
			cube.RotateSideCW(side);
		}

		public double Applicable(Cube cube, Sides side)
		{
			Side solveSide = cube.GetSideFromEnum(side);
			if (solveSide.Fields[2, 1] == solveSide.Color)
			{
				//check bottom color of the piece, dependent on which side to solve
				if ((solveSide.CubeSide == Sides.Front && cube.Bottom.Fields[0, 1] == solveSide.Left.Color) ||
					(solveSide.CubeSide == Sides.Left && cube.Bottom.Fields[1, 0] == solveSide.Left.Color) ||
					(solveSide.CubeSide == Sides.Back && cube.Bottom.Fields[2, 1] == solveSide.Left.Color) ||
					(solveSide.CubeSide == Sides.Right && cube.Bottom.Fields[1, 2] == solveSide.Left.Color))
				{
					return 1;
				}
			}
			return 0;
		}
	}
}
