using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.StartCrossMoves
{
	/// <summary>
	/// represents the situation where the edge is on the correct side (top), but on the top (when it should be bottom)
	/// </summary>
	public class StartCrossMove9 : IStartCrossMove
	{
		public void Apply(Cube cube, RelativeSidePosition side)
		{
			cube.RotateSideCW(Helper.GetRelativeSide(Helper.GetRelativeSide(Sides.Top, side), RelativeSidePosition.Opposite));
			cube.RotateTopCW();
			cube.RotateTopCW();
			cube.RotateSideCCW(Helper.GetRelativeSide(Helper.GetRelativeSide(Sides.Top, side), RelativeSidePosition.Opposite));
			cube.RotateTopCW();
			cube.RotateTopCW();
		}

		public double Applicable(Cube cube, RelativeSidePosition side)
		{
			RelativeSidePosition relativeSidePosition;
			RelativeEdgePosition relativeEdgePosition;
			cube.GetRelativeEdgePosition(cube.Top.CubeSide, cube.Top.Color, cube.Top.GetRelativeSide(side).Color,
				out relativeSidePosition, out relativeEdgePosition);

			RelativeSidePosition expectedSidePositon = Helper.GetRotationNeutralRelativeSidePosition(cube.Top, RelativeSidePosition.Self, Helper.ConvertRelativeSidePositionToRelativeEdgePosition(side));
			RelativeEdgePosition expectedEdgePosition = Helper.GetRelativeEdge(Helper.ConvertRelativeSidePositionToRelativeEdgePosition(side), RelativeEdgePosition.Top);

			if (relativeSidePosition == expectedSidePositon && relativeEdgePosition == expectedEdgePosition)
				return 1;
			else
				return 0;
		}
	}
}
