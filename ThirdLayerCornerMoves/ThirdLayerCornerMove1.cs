using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.ThirdLayerCrossMoves
{
	public class ThirdLayerCornerMove1 : IThirdLayerCornerMove
	{
		/// <summary>
		/// represents the one single move that is needed to solve the corners
		/// </summary>
		/// <param name="cube"></param>
		public void Apply(Cube cube)
		{
			cube.RotateRightCW();
			cube.RotateBottomCW();
			cube.RotateRightCCW();
			cube.RotateBottomCW();
			cube.RotateRightCW();
			cube.RotateBottomCW();
			cube.RotateBottomCW();
			cube.RotateRightCCW();
		}

		public double Applicable(Cube cube)
		{
			int upCorners = 0;
			if (cube.Bottom.GetCornerField(RelativeCornerPosition.BottomLeft) == cube.Bottom.Color) upCorners++;
			if (cube.Bottom.GetCornerField(RelativeCornerPosition.BottomRight) == cube.Bottom.Color) upCorners++;
			if (cube.Bottom.GetCornerField(RelativeCornerPosition.TopLeft) == cube.Bottom.Color) upCorners++;
			if (cube.Bottom.GetCornerField(RelativeCornerPosition.TopRight) == cube.Bottom.Color) upCorners++;

			//case where no corner is up
			if (upCorners == 0 &&
				cube.Left.GetCornerField(RelativeCornerPosition.TopRight) == cube.Bottom.Color)
			{
				return 1;
			}
			//case where one corner is up
			if (upCorners == 1 &&
				cube.Bottom.GetCornerField(RelativeCornerPosition.BottomLeft) == cube.Bottom.Color)
			{
				return 1;
			}
			//case where two corners are up
			if (upCorners == 3 &&
				cube.Front.GetCornerField(RelativeCornerPosition.TopLeft) == cube.Bottom.Color)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}
	}
}
