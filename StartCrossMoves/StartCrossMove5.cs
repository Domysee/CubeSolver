﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.StartCrossMoves
{
	/// <summary>
	/// represents the situation where the edge is in the same position as in StartCrossMove2, but rotated wrongly
	/// on the front side, edge on the left
	/// </summary>
	public class StartCrossMove5 : IStartCrossMove
	{
		public void Apply(Cube cube, RelativeSidePosition side)
		{
			cube.RotateTopCW();
			cube.RotateSideCCW(Helper.GetRelativeSide(Helper.GetRelativeSide(Sides.Top, side), RelativeSidePosition.Left));
			cube.RotateTopCCW();
		}

		public double Applicable(Cube cube, RelativeSidePosition side)
		{
			RelativeSidePosition relativeSidePosition;
			RelativeEdgePosition relativeEdgePosition;
			cube.GetRelativeEdgePosition(cube.Top.CubeSide, cube.Top.Color, cube.Top.GetRelativeSide(side).Color,
				out relativeSidePosition, out relativeEdgePosition);

			RelativeSidePosition expectedSidePositon = Helper.GetRotationNeutralRelativeSidePosition(cube.Top, RelativeSidePosition.Bottom, Helper.ConvertRelativeSidePositionToRelativeEdgePosition(side));
			RelativeEdgePosition expectedEdgePosition = RelativeEdgePosition.Left;

			if (relativeSidePosition == expectedSidePositon && relativeEdgePosition == expectedEdgePosition)
				return 1;
			else
				return 0;
		}
	}
}
