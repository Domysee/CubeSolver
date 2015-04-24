using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.StartCrossMoves
{
	public class StartCrossMove1 : IStartCrossMove
	{
		public void Apply(Cube cube, RelativeSidePosition side)
		{
			throw new NotImplementedException();
		}

		public double Applicable(Cube cube, RelativeSidePosition side)
		{
			RelativeSidePosition relativeSidePosition;
			RelativeEdgePosition relativeEdgePosition;
			cube.GetRelativeEdgePosition(cube.Top.CubeSide, cube.Top.Color, cube.Top.GetRelativeSide(side).Color,
				out relativeSidePosition, out relativeEdgePosition);

			RelativeEdgePosition expectedEdgePosition = Helper.ConvertRelativeSidePositionToRelativeEdgePosition(side);
			if (expectedEdgePosition == RelativeEdgePosition.Top || expectedEdgePosition == RelativeEdgePosition.Bottom)
				expectedEdgePosition = Helper.GetOppositeRelativeEdge(expectedEdgePosition);	//because on the opposite side bottom and top are inverted

			if (relativeSidePosition == RelativeSidePosition.Opposite && relativeEdgePosition == expectedEdgePosition)
				return 1;
			else
				return 0;
		}
	}
}
