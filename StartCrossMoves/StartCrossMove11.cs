using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.StartCrossMoves
{
	/// <summary>
	/// represents the situation where the edge is in the same position as in StartCrossMove1, but rotated wrongly
	/// on the front side, edge bottom
	/// </summary>
	public class StartCrossMove11 : IStartCrossMove
	{
		public void Apply(Cube cube, RelativeSidePosition side)
		{
			cube.RotateSideCW(Helper.GetRelativeSide(Helper.GetRelativeSide(Sides.Top, side), RelativeSidePosition.Left));
			cube.RotateSideCW(Helper.GetRelativeSide(Sides.Top, side));
		}

		public double Applicable(Cube cube, RelativeSidePosition side)
		{
			RelativeSidePosition relativeSidePosition;
			RelativeEdgePosition relativeEdgePosition;
			cube.GetRelativeEdgePosition(cube.Top.CubeSide, cube.Top.Color, cube.Top.GetRelativeSide(side).Color,
				out relativeSidePosition, out relativeEdgePosition);

			RelativeSidePosition expectedSidePositon = Helper.GetRotationNeutralRelativeSidePosition(cube.Top, RelativeSidePosition.Left, Helper.ConvertRelativeSidePositionToRelativeEdgePosition(side));
			RelativeEdgePosition expectedEdgePosition = RelativeEdgePosition.Top;

			if (relativeSidePosition == expectedSidePositon && relativeEdgePosition == expectedEdgePosition)
				return 1;
			else
				return 0;
		}
	}
}
