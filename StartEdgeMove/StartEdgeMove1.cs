using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.StartEdgeMove
{
	/// <summary>
	/// corner piece is at the bottom, white side front
	/// </summary>
	public class StartEdgeMove1 : IStartEdgeMove
	{
		public void Apply(Cube cube, RelativeCornerPosition corner)
		{
			Sides frontSide, leftSide;
			Helper.GetFrontLeftFromCorner(corner, out frontSide, out leftSide);
			cube.RotateBottomCW();
			cube.RotateSideCW(leftSide);
			cube.RotateBottomCCW();
			cube.RotateSideCCW(leftSide);
		}

		public double Applicable(Cube cube, RelativeCornerPosition corner)
		{
			Sides frontSide, leftSide;
			Helper.GetFrontLeftFromCorner(corner, out frontSide, out leftSide);
			Side front = cube.GetSideFromEnum(frontSide);
			Side left = cube.GetSideFromEnum(leftSide);

			//if the front bottom left field is of the top color
			//and the other fields are either the left color or the front color
			if (front.GetCornerField(RelativeCornerPosition.BottomLeft) == cube.Top.Color &&
				(left.GetCornerField(RelativeCornerPosition.BottomRight) == left.Color || left.GetCornerField(RelativeCornerPosition.BottomRight) == front.Color) &&
				(cube.Bottom.GetCornerField(Helper.SwapTopBottom(corner)) == left.Color || cube.Bottom.GetCornerField(Helper.SwapTopBottom(corner)) == front.Color))
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
