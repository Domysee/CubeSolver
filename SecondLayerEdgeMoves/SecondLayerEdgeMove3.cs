using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.SecondLayerEdgeMoves
{
	/// <summary>
	/// moves out the right edge piece 
	/// if it is not an edge piece of the top side
	/// 
	/// a similar move for the left side is not needed
	/// because the algorithm will move through each side (front, left, back, right), which covers all edges of the second layer
	/// </summary>
	public class SecondLayerEdgeMove3 : ISecondLayerEdgeMove
	{
		public void Apply(Cube cube, Sides side)
		{
			cube.RotateBottomCCW();
			cube.RotateSideCCW(Helper.GetRelativeSide(side, RelativeSidePosition.Right));
			cube.RotateBottomCW();
			cube.RotateSideCW(Helper.GetRelativeSide(side, RelativeSidePosition.Right));
			cube.RotateBottomCW();
			cube.RotateSideCW(side);
			cube.RotateBottomCCW();
			cube.RotateSideCCW(side);
		}

		public double Applicable(Cube cube, Sides side)
		{
			Side solveSide = cube.GetSideFromEnum(side);
			if (Helper.IsOfColor(cube.GetSideFromEnum(side).Fields[1, 2], cube.Front.Color, cube.Left.Color, cube.Back.Color, cube.Right.Color)&&
				Helper.IsOfColor(cube.GetSideFromEnum(side).Right.Fields[1, 0], cube.Front.Color, cube.Left.Color, cube.Back.Color, cube.Right.Color))
			{
				return 1;
			}
			return 0;
		}
	}
}
