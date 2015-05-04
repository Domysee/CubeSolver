using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.StartCrossMoves
{
	/// <summary>
	/// on the back side, edge right
	/// </summary>
	public class StartCrossMove23 : IStartCrossMove
	{
		public void Apply(Cube cube, RelativeSidePosition side)
		{
			cube.RotateTopCW();
			cube.RotateSideCW(Helper.GetRelativeSide(Helper.GetRelativeSide(Sides.Top, side), RelativeSidePosition.Left));
			cube.RotateTopCCW();
		}

		public double Applicable(Cube cube, RelativeSidePosition side)
		{
			RelativeSidePosition relativeSidePosition;
			RelativeEdgePosition relativeEdgePosition;
			cube.GetRelativeEdgePosition(cube.Top.CubeSide, cube.Top.Color, cube.Top.GetRelativeSide(side).Color,
				out relativeSidePosition, out relativeEdgePosition);

			RelativeSidePosition expectedSidePositon = Helper.GetRotationNeutralRelativeSidePosition(cube.Top, RelativeSidePosition.Top, Helper.ConvertRelativeSidePositionToRelativeEdgePosition(side));
			RelativeEdgePosition expectedEdgePosition = RelativeEdgePosition.Right;

			if (relativeSidePosition == expectedSidePositon && relativeEdgePosition == expectedEdgePosition)
				return 1;
			else
				return 0;
		}
	}
}
