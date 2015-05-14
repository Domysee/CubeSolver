using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.StartCornerMoves
{
	/// <summary>
	/// corner piece is at the top, is moved down
	/// </summary>
	public class StartCornerMove4 : IStartCornerMove
	{
		public void Apply(Cube cube, RelativeCornerPosition corner)
		{
			Sides frontSide, leftSide;
			Helper.GetFrontLeftFromCorner(corner, out frontSide, out leftSide);
			cube.RotateSideCCW(frontSide);
			cube.RotateBottomCCW();
			cube.RotateSideCW(frontSide);
		}

		public double Applicable(Cube cube, RelativeCornerPosition corner)
		{
			Sides frontSide, leftSide;
			Helper.GetFrontLeftFromCorner(corner, out frontSide, out leftSide);
			Side front = cube.GetSideFromEnum(frontSide);
			Side left = cube.GetSideFromEnum(leftSide);

			//check if the corner piece is incorrectly positioned, but one of the 3 colors is the top color
			//moving it down if it is not a top piece is useless
			if ((front.GetCornerField(RelativeCornerPosition.TopLeft) != front.Color ||
				left.GetCornerField(RelativeCornerPosition.TopRight) != left.Color) &&
				(front.GetCornerField(RelativeCornerPosition.TopLeft) == cube.Top.Color ||
				left.GetCornerField(RelativeCornerPosition.TopRight) == cube.Top.Color ||
				cube.Top.GetCornerField(corner) == cube.Top.Color))
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
