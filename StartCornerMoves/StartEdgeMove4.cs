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

			//if the front bottom left field is of the top color
			//and the other fields are either the left color or the front color
			if (Helper.IsOfColor(front.GetCornerField(RelativeCornerPosition.TopLeft), cube.Top.Color) ||
				Helper.IsOfColor(left.GetCornerField(RelativeCornerPosition.TopRight), cube.Top.Color))
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
