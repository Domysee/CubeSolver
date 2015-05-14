using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.StartEdgeMoves
{
	/// <summary>
	/// corner piece is at the bottom, white side bottom
	/// </summary>
	public class StartEdgeMove3 : IStartEdgeMove
	{
		public void Apply(Cube cube, RelativeCornerPosition corner)
		{
			Sides frontSide, leftSide;
			Helper.GetFrontLeftFromCorner(corner, out frontSide, out leftSide);
			cube.RotateSideCCW(frontSide);
			cube.RotateBottomCW();
			cube.RotateSideCW(frontSide);
			cube.RotateBottomCW();
			cube.RotateBottomCW();
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
			if (cube.Bottom.GetCornerField(Helper.SwapTopBottom(corner)) == cube.Top.Color &&
				(front.GetCornerField(RelativeCornerPosition.BottomLeft) == left.Color || front.GetCornerField(RelativeCornerPosition.BottomLeft) == front.Color) &&
				(left.GetCornerField(RelativeCornerPosition.BottomRight) == left.Color || left.GetCornerField(RelativeCornerPosition.BottomRight) == front.Color))
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
