using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.OLLCornerMoves
{
	public class OLLCornerMove1 : IOLLCornerMove
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
				cube.Left.GetCornerField(RelativeCornerPosition.BottomLeft) == cube.Bottom.Color)
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
			if (upCorners == 2 &&
				cube.Back.GetCornerField(RelativeCornerPosition.BottomRight) == cube.Bottom.Color)
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
