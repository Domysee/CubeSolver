﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.StartCrossMoves
{
	/// <summary>
	/// represents the situation where the edge is on the opposite side, but adjacent to the correct color
	/// opposite side, edge top
	/// </summary>
	public class StartCrossMove1 : IStartCrossMove
	{
		public void Apply(Cube cube, RelativeSidePosition side)
		{
			cube.RotateSideCW(Helper.GetRelativeSide(Sides.Top, side));
			cube.RotateSideCW(Helper.GetRelativeSide(Sides.Top, side));
		}

		public double Applicable(Cube cube, RelativeSidePosition side)
		{
			RelativeSidePosition relativeSidePosition;
			RelativeEdgePosition relativeEdgePosition;
			cube.GetRelativeEdgePosition(cube.Top.CubeSide, cube.Top.Color, cube.Top.GetRelativeSide(side).Color,
				out relativeSidePosition, out relativeEdgePosition);

			RelativeSidePosition expectedSidePositon = RelativeSidePosition.Opposite;
			RelativeEdgePosition expectedEdgePosition = Helper.ConvertRelativeSidePositionToRelativeEdgePosition(side);
			expectedEdgePosition = Helper.SwapTopBottom(expectedEdgePosition); //because on the opposite side bottom and top are inverted

			if (relativeSidePosition == expectedSidePositon && relativeEdgePosition == expectedEdgePosition)
				return 1;
			else
				return 0;
		}
	}
}
