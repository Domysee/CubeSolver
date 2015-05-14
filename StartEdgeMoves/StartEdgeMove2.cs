using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.StartEdgeMoves
{
	/// <summary>
	/// corner piece is at the bottom, white side left
	/// </summary>
	public class StartEdgeMove2 : IStartEdgeMove
	{
		public void Apply(Cube cube, RelativeCornerPosition corner)
		{
			Sides frontSide, leftSide;
			Helper.GetFrontLeftFromCorner(corner, out frontSide, out leftSide);
			cube.RotateBottomCCW();
			cube.RotateSideCCW(frontSide);
			cube.RotateBottomCW();
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
			if (left.GetCornerField(RelativeCornerPosition.BottomRight) == cube.Top.Color &&
				(front.GetCornerField(RelativeCornerPosition.BottomLeft) == left.Color || front.GetCornerField(RelativeCornerPosition.BottomLeft) == front.Color) &&
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
